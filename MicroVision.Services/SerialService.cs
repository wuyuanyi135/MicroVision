﻿using System;
using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using MicroVision.Core.Events;
using MicroVision.Core.Exceptions;
using MicroVision.Core.Models;
using MicroVision.Services.Annotations;
using MicroVision.Services.GrpcReference;
using Prism.Events;
using Services;

namespace MicroVision.Services
{
    public interface ISerialService
    {
        /// <summary>
        /// Connect to the serial port
        /// </summary>
        /// <param name="s"> com port name</param>
        /// <returns>whether the port is connected successfully</returns>
        void Connect(string s);

        /// <summary>
        /// Disconnect from the current port
        /// </summary>
        /// <returns>whether the port is disconnected successfully</returns>
        void Disconnect();

        Object DispatchCommand(SerialCommand serialCommand);

        /// <summary>
        /// get the com list
        /// </summary>
        /// <returns>null for failure</returns>
        List<string> UpdateComList();

        /// <summary>
        /// Assert if serial port is already connected
        /// </summary>
        /// <returns></returns>
        bool IsConnected();

        /// <summary>
        /// Control the power configuration.
        /// </summary>
        /// <param name="master">Master power</param>
        /// <param name="fan">Fan power</param>
        /// <param name="motor">Motor power</param>
        /// <param name="laser">Laser power</param>
        void ControlPower(bool master, bool fan, bool motor, bool laser);

        /// <summary>
        /// Read the power code. Throw ComRunTimeException if error occured.
        /// </summary>
        /// <returns>power code</returns>
        int ReadPower();

        /// <summary>
        /// Control the focus motor
        /// </summary>
        /// <param name="steps">Movement steps</param>
        /// <param name="slowdown">Slow down factor</param>
        /// <param name="autoPower">Always true</param>
        /// <param name="driverPower">Always true</param>
        void ControlFocus(int steps, int slowdown = 1000, bool autoPower = true, bool driverPower = true);

        double GetCurrent();
        CameraControllerTrigger StreamTrigger();
    }

    public class SerialService : ISerialService
    {
        private const string CameraControllerConnectionErrorPrompt =
            "Failed to connect to camera controller server. Please check if the server is running and check if the server uri is correct in app.config. Please restart the software";

        private readonly ILogService _log;
        private readonly IEventAggregator _eventAggregator;
        private readonly IRpcService _rpcService;


        public SerialService(ILogService log, IEventAggregator eventAggregator,
            IRpcService rpcService)
        {
            _log = log;

            _eventAggregator = eventAggregator;
            _rpcService = rpcService;
            _eventAggregator.GetEvent<ShutDownEvent>().Subscribe(RestoreRpcStatus);
        }


        /// <summary>
        /// Rpc invocation wrapper
        /// </summary>
        /// <typeparam name="TReturnType"></typeparam>
        /// <param name="func"></param>
        /// <param name="runtimeExceptionPrompt"></param>
        /// <param name="connectionExceptionPrompt"></param>
        /// <param name="rethrow"></param>
        /// <param name="checkError"></param>
        /// <param name="notifyError">when the error is insiginficant it may not be notified</param>
        /// <param name="onError"></param>
        /// <returns></returns>
        private TReturnType TryInvoke<TReturnType>([NotNull] Func<TReturnType> func,
            string runtimeExceptionPrompt, string connectionExceptionPrompt = CameraControllerConnectionErrorPrompt,
            bool rethrow = false, bool checkError = true, bool notifyError = true, Action<string> onError = null)
        {
            var ret = default(TReturnType);
            try
            {
                ret = func.Invoke();
            }
            catch (Exception e)
            {
                _log.Logger.Error(e);
                _eventAggregator.GetEvent<ExceptionEvent>()
                    .Publish(new CameraControllerRpcServerConnectionException(connectionExceptionPrompt));
                if (rethrow) throw;
                return ret;
            }

            bool hasError = false;
            Error error = null;

            if (checkError)
            {
                try
                {
                    // what will happen if the object does not contain error at all?
                    error = (Error) typeof(TReturnType).GetProperty("Error")?.GetValue(ret);
                    if (error != null) hasError = true;
                }
                catch (Exception e)
                {
                    error = new Error()
                    {
                        Level = Error.Types.Level.Error,
                        Message = e.Message,
                        Timestamp = Timestamp.FromDateTime(DateTime.Now)
                    };
                    hasError = true;
                }
            }

            if (ret == null || hasError)
            {
                onError?.Invoke(error?.Message);

                if (notifyError)
                    _eventAggregator.GetEvent<ExceptionEvent>()
                    .Publish(new Exception($"{runtimeExceptionPrompt} {error?.Message}"));
            }

            return ret;
        }

        private void RestoreRpcStatus()
        {
            try
            {
                _rpcService.CameraControllerClient.RequestSoftwareReset(new Empty());
            }
            catch (Exception e)
            {
                // ignored
            }

            Disconnect();
        }

        public static void ParsePowerCode(int powerCode, out bool master, out bool fan, out bool motor, out bool laser)
        {
            //int powerCode = Convert.ToInt32(master) << 0 | Convert.ToInt32(laser) << 1 | Convert.ToInt32(motor) << 2 |
            //                Convert.ToInt32(fan) << 3;
            master = Convert.ToBoolean(powerCode & (1 << 0));
            laser = Convert.ToBoolean(powerCode & (1 << 1));
            motor = Convert.ToBoolean(powerCode & (1 << 2));
            fan = Convert.ToBoolean(powerCode & (1 << 3));
        }

        #region Service methods

        /// <summary>
        /// Connect to the serial port
        /// </summary>
        /// <param name="s"> com port name</param>
        public void Connect(string s)
        {
            var ret = TryInvoke(() => _rpcService.CameraControllerClient.RequestConnectToPort(
                new ConnectionRequest() {ComPort = s, Connect = true}), $"Failed to connect to {s}");

            if (!ret.IsConnected)
            {
                _eventAggregator.GetEvent<ExceptionEvent>()
                    .Publish(new ComListException("COM port is not connected"));
            }
            else
            {
                _eventAggregator.GetEvent<ComConnectedEvent>().Publish();
                _eventAggregator.GetEvent<NotifyOperationEvent>().Publish($"{s} successfully connected");
            }
        }

        /// <summary>
        /// Disconnect from the current port
        /// </summary>
        /// <returns>whether the port is disconnected successfully</returns>
        public bool Disconnect()
        {
            var ret = TryInvoke(() => _rpcService.CameraControllerClient.RequestConnectToPort(
                new ConnectionRequest() {Connect = false}), "Failed to disconnect");
            if (ret?.Error != null || ret == null) return false;
            _eventAggregator.GetEvent<ComDisconnectedEvent>().Publish(true);
            _eventAggregator.GetEvent<NotifyOperationEvent>().Publish("COM port successfully closed");
            return true;
        }


        public Object DispatchCommand(SerialCommand serialCommand)
        {
            object ret = null;
            var failedPrompt = $"Failed to invoke {serialCommand.Command.ToString()}";
            switch (serialCommand.Command)
            {
                case SerialCommand.RpcSerialCommand.GetInfo:
                    ret = TryInvoke(() => _rpcService.CameraControllerClient.GetInfo(new Empty()),
                        failedPrompt);
                    break;
                case SerialCommand.RpcSerialCommand.IsConnected:
                    ret = TryInvoke(() => _rpcService.CameraControllerClient.IsConnected(new Empty()),
                        failedPrompt);
                    break;

                case SerialCommand.RpcSerialCommand.RequestPowerStatus:
                    ret = !(serialCommand.Argument is PowerStatusRequest powerStatusRequest)
                        ? null
                        : TryInvoke(() => _rpcService.CameraControllerClient.RequestPowerStatus(powerStatusRequest),
                            failedPrompt);
                    break;

                case SerialCommand.RpcSerialCommand.RequestCurrentStatus:
                    ret = TryInvoke(
                        () => _rpcService.CameraControllerClient.RequestCurrentStatus(new CurrentStatusRequest()),
                        failedPrompt);
                    break;

                case SerialCommand.RpcSerialCommand.RequestFocusStatus:
                    ret = !(serialCommand.Argument is FocusStatusRequest focusStatusRequest)
                        ? null
                        : TryInvoke(() => _rpcService.CameraControllerClient.RequestFocusStatus(focusStatusRequest),
                            failedPrompt);
                    break;

                case SerialCommand.RpcSerialCommand.RequestLaserStatus:
                    ret = !(serialCommand.Argument is LaserStatusRequest laserStatusRequest)
                        ? null
                        : TryInvoke(() => _rpcService.CameraControllerClient.RequestLaserStatus(laserStatusRequest),
                            failedPrompt);
                    break;

                case SerialCommand.RpcSerialCommand.RequestArmTrigger:
                    ret = !(serialCommand.Argument is ArmTriggerRequest armTriggerRequest)
                        ? null
                        : TryInvoke(() => _rpcService.CameraControllerClient.RequestArmTrigger(armTriggerRequest),
                            failedPrompt);
                    break;

                case SerialCommand.RpcSerialCommand.RequestSoftwareReset:
                    ret = TryInvoke(() => _rpcService.CameraControllerClient.RequestSoftwareReset(new Empty()),
                        failedPrompt);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return ret;
        }

        /// <summary>
        /// get the com list
        /// </summary>
        /// <returns>null for failure</returns>
        public List<string> UpdateComList()
        {
            var comList = TryInvoke(() => _rpcService.CameraControllerClient.RequestComList(new ComListRequest()),
                "Failed to update the serial port list");
            return comList?.ComPort == null ? new List<string>() : new List<string>(comList.ComPort);
        }

        public CameraControllerTrigger StreamTrigger()
        {
            var trigger = _rpcService.CameraControllerClient.StreamRequestArmTrigger();
            return new CameraControllerTrigger(trigger);
        }

        #region Invocation helpers

        /// <summary>
        /// Assert if serial port is already connected
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            var ret =
                DispatchCommand(new SerialCommand() {Command = SerialCommand.RpcSerialCommand.IsConnected}) as
                    ConnectionResponse;
            if (ret == null || ret?.Error != null) throw new ComRuntimeException("Cannot get connection status");
            return ret.IsConnected;
        }

        /// <summary>
        /// Control the power configuration.
        /// </summary>
        /// <param name="master">Master power</param>
        /// <param name="fan">Fan power</param>
        /// <param name="motor">Motor power</param>
        /// <param name="laser">Laser power</param>
        public void ControlPower(bool master, bool fan, bool motor, bool laser)
        {
            int powerCode = Convert.ToInt32(master) << 0 | Convert.ToInt32(laser) << 1 | Convert.ToInt32(motor) << 2 |
                            Convert.ToInt32(fan) << 3;
            var ret =
                DispatchCommand(new SerialCommand()
                    {
                        Command = SerialCommand.RpcSerialCommand.RequestPowerStatus,
                        Argument = new PowerStatusRequest() {PowerCode = powerCode, Write = true}
                    }) as
                    PowerStatusResponse;
            if (ret == null || ret?.Error != null) throw new ComRuntimeException("Cannot control power");
        }

        /// <summary>
        /// Read the power code. Throw ComRunTimeException if error occured.
        /// </summary>
        /// <returns>power code</returns>
        public int ReadPower()
        {
            var ret = DispatchCommand(new SerialCommand()
            {
                Command = SerialCommand.RpcSerialCommand.RequestPowerStatus,
                Argument = new PowerStatusRequest() {Write = false}
            }) as PowerStatusResponse;
            if (ret == null || ret?.Error != null) throw new ComRuntimeException("Cannot get power code");

            return ret.PowerCode;
        }

        /// <summary>
        /// Control the focus motor
        /// </summary>
        /// <param name="steps">Movement steps</param>
        /// <param name="slowdown">Slow down factor</param>
        /// <param name="autoPower">Always true</param>
        /// <param name="driverPower">Always true</param>
        public void ControlFocus(int steps, int slowdown = 1000, bool autoPower = true, bool driverPower = true)
        {
            if (steps == 0) return;
            var ret = DispatchCommand(new SerialCommand()
            {
                Command = SerialCommand.RpcSerialCommand.RequestFocusStatus,
                Argument = new FocusStatusRequest()
                {
                    Steps = steps,
                    SlowdownFactor = slowdown,
                    DriverPower = driverPower,
                    AutoPower = autoPower
                }
            }) as FocusStatusResponse;
            if (ret == null || ret?.Error != null) throw new ComRuntimeException("Cannot control focus");
        }

        public double GetCurrent()
        {
            var ret = DispatchCommand(new SerialCommand()
            {
                Command = SerialCommand.RpcSerialCommand.RequestCurrentStatus
            }) as CurrentStatusResponse;
            if (ret == null || ret?.Error != null) throw new ComRuntimeException("Cannot get current");
            return ret.Current;
        }

        #endregion

        #endregion
    }
}