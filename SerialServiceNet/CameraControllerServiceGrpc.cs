// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CameraControllerService.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Services {
  public static partial class CameraController
  {
    static readonly string __ServiceName = "Services.CameraController";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.VersionInfo> __Marshaller_VersionInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.VersionInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.ConnectionResponse> __Marshaller_ConnectionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.ConnectionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.ComListRequest> __Marshaller_ComListRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.ComListRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.ComList> __Marshaller_ComList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.ComList.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.ConnectionRequest> __Marshaller_ConnectionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.ConnectionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.PowerStatusRequest> __Marshaller_PowerStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.PowerStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.PowerStatusResponse> __Marshaller_PowerStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.PowerStatusResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.CurrentStatusRequest> __Marshaller_CurrentStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.CurrentStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.CurrentStatusResponse> __Marshaller_CurrentStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.CurrentStatusResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.FocusStatusRequest> __Marshaller_FocusStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.FocusStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.FocusStatusResponse> __Marshaller_FocusStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.FocusStatusResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.LaserStatusRequest> __Marshaller_LaserStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.LaserStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.LaserStatusResponse> __Marshaller_LaserStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.LaserStatusResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.ArmTriggerRequest> __Marshaller_ArmTriggerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.ArmTriggerRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.ArmTriggerResponse> __Marshaller_ArmTriggerResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.ArmTriggerResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Services.HardwareResetStatus> __Marshaller_HardwareResetStatus = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.HardwareResetStatus.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Services.VersionInfo> __Method_GetInfo = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Services.VersionInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetInfo",
        __Marshaller_Empty,
        __Marshaller_VersionInfo);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Services.ConnectionResponse> __Method_IsConnected = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Services.ConnectionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsConnected",
        __Marshaller_Empty,
        __Marshaller_ConnectionResponse);

    static readonly grpc::Method<global::Services.ComListRequest, global::Services.ComList> __Method_RequestComList = new grpc::Method<global::Services.ComListRequest, global::Services.ComList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestComList",
        __Marshaller_ComListRequest,
        __Marshaller_ComList);

    static readonly grpc::Method<global::Services.ConnectionRequest, global::Services.ConnectionResponse> __Method_RequestConnectToPort = new grpc::Method<global::Services.ConnectionRequest, global::Services.ConnectionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestConnectToPort",
        __Marshaller_ConnectionRequest,
        __Marshaller_ConnectionResponse);

    static readonly grpc::Method<global::Services.PowerStatusRequest, global::Services.PowerStatusResponse> __Method_RequestPowerStatus = new grpc::Method<global::Services.PowerStatusRequest, global::Services.PowerStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestPowerStatus",
        __Marshaller_PowerStatusRequest,
        __Marshaller_PowerStatusResponse);

    static readonly grpc::Method<global::Services.CurrentStatusRequest, global::Services.CurrentStatusResponse> __Method_RequestCurrentStatus = new grpc::Method<global::Services.CurrentStatusRequest, global::Services.CurrentStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestCurrentStatus",
        __Marshaller_CurrentStatusRequest,
        __Marshaller_CurrentStatusResponse);

    static readonly grpc::Method<global::Services.FocusStatusRequest, global::Services.FocusStatusResponse> __Method_RequestFocusStatus = new grpc::Method<global::Services.FocusStatusRequest, global::Services.FocusStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestFocusStatus",
        __Marshaller_FocusStatusRequest,
        __Marshaller_FocusStatusResponse);

    static readonly grpc::Method<global::Services.LaserStatusRequest, global::Services.LaserStatusResponse> __Method_RequestLaserStatus = new grpc::Method<global::Services.LaserStatusRequest, global::Services.LaserStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestLaserStatus",
        __Marshaller_LaserStatusRequest,
        __Marshaller_LaserStatusResponse);

    static readonly grpc::Method<global::Services.ArmTriggerRequest, global::Services.ArmTriggerResponse> __Method_RequestArmTrigger = new grpc::Method<global::Services.ArmTriggerRequest, global::Services.ArmTriggerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestArmTrigger",
        __Marshaller_ArmTriggerRequest,
        __Marshaller_ArmTriggerResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Services.HardwareResetStatus> __Method_RequestHardwareReset = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Services.HardwareResetStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestHardwareReset",
        __Marshaller_Empty,
        __Marshaller_HardwareResetStatus);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Services.CameraControllerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CameraController</summary>
    public abstract partial class CameraControllerBase
    {
      /// <summary>
      /// get version information
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Services.VersionInfo> GetInfo(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// check if connected to the com port
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Services.ConnectionResponse> IsConnected(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// get available com port list
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Services.ComList> RequestComList(global::Services.ComListRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// connection
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Services.ConnectionResponse> RequestConnectToPort(global::Services.ConnectionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// operation, R/W
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Services.PowerStatusResponse> RequestPowerStatus(global::Services.PowerStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Services.CurrentStatusResponse> RequestCurrentStatus(global::Services.CurrentStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Services.FocusStatusResponse> RequestFocusStatus(global::Services.FocusStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Services.LaserStatusResponse> RequestLaserStatus(global::Services.LaserStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Services.ArmTriggerResponse> RequestArmTrigger(global::Services.ArmTriggerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Services.HardwareResetStatus> RequestHardwareReset(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CameraController</summary>
    public partial class CameraControllerClient : grpc::ClientBase<CameraControllerClient>
    {
      /// <summary>Creates a new client for CameraController</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CameraControllerClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CameraController that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CameraControllerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CameraControllerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CameraControllerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// get version information
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.VersionInfo GetInfo(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get version information
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.VersionInfo GetInfo(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetInfo, null, options, request);
      }
      /// <summary>
      /// get version information
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.VersionInfo> GetInfoAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get version information
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.VersionInfo> GetInfoAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetInfo, null, options, request);
      }
      /// <summary>
      /// check if connected to the com port
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.ConnectionResponse IsConnected(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return IsConnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// check if connected to the com port
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.ConnectionResponse IsConnected(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IsConnected, null, options, request);
      }
      /// <summary>
      /// check if connected to the com port
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.ConnectionResponse> IsConnectedAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return IsConnectedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// check if connected to the com port
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.ConnectionResponse> IsConnectedAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IsConnected, null, options, request);
      }
      /// <summary>
      /// get available com port list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.ComList RequestComList(global::Services.ComListRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestComList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get available com port list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.ComList RequestComList(global::Services.ComListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestComList, null, options, request);
      }
      /// <summary>
      /// get available com port list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.ComList> RequestComListAsync(global::Services.ComListRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestComListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// get available com port list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.ComList> RequestComListAsync(global::Services.ComListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestComList, null, options, request);
      }
      /// <summary>
      /// connection
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.ConnectionResponse RequestConnectToPort(global::Services.ConnectionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestConnectToPort(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// connection
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.ConnectionResponse RequestConnectToPort(global::Services.ConnectionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestConnectToPort, null, options, request);
      }
      /// <summary>
      /// connection
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.ConnectionResponse> RequestConnectToPortAsync(global::Services.ConnectionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestConnectToPortAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// connection
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.ConnectionResponse> RequestConnectToPortAsync(global::Services.ConnectionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestConnectToPort, null, options, request);
      }
      /// <summary>
      /// operation, R/W
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.PowerStatusResponse RequestPowerStatus(global::Services.PowerStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestPowerStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// operation, R/W
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Services.PowerStatusResponse RequestPowerStatus(global::Services.PowerStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestPowerStatus, null, options, request);
      }
      /// <summary>
      /// operation, R/W
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.PowerStatusResponse> RequestPowerStatusAsync(global::Services.PowerStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestPowerStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// operation, R/W
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Services.PowerStatusResponse> RequestPowerStatusAsync(global::Services.PowerStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestPowerStatus, null, options, request);
      }
      public virtual global::Services.CurrentStatusResponse RequestCurrentStatus(global::Services.CurrentStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestCurrentStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Services.CurrentStatusResponse RequestCurrentStatus(global::Services.CurrentStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestCurrentStatus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Services.CurrentStatusResponse> RequestCurrentStatusAsync(global::Services.CurrentStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestCurrentStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Services.CurrentStatusResponse> RequestCurrentStatusAsync(global::Services.CurrentStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestCurrentStatus, null, options, request);
      }
      public virtual global::Services.FocusStatusResponse RequestFocusStatus(global::Services.FocusStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestFocusStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Services.FocusStatusResponse RequestFocusStatus(global::Services.FocusStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestFocusStatus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Services.FocusStatusResponse> RequestFocusStatusAsync(global::Services.FocusStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestFocusStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Services.FocusStatusResponse> RequestFocusStatusAsync(global::Services.FocusStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestFocusStatus, null, options, request);
      }
      public virtual global::Services.LaserStatusResponse RequestLaserStatus(global::Services.LaserStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestLaserStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Services.LaserStatusResponse RequestLaserStatus(global::Services.LaserStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestLaserStatus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Services.LaserStatusResponse> RequestLaserStatusAsync(global::Services.LaserStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestLaserStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Services.LaserStatusResponse> RequestLaserStatusAsync(global::Services.LaserStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestLaserStatus, null, options, request);
      }
      public virtual global::Services.ArmTriggerResponse RequestArmTrigger(global::Services.ArmTriggerRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestArmTrigger(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Services.ArmTriggerResponse RequestArmTrigger(global::Services.ArmTriggerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestArmTrigger, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Services.ArmTriggerResponse> RequestArmTriggerAsync(global::Services.ArmTriggerRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestArmTriggerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Services.ArmTriggerResponse> RequestArmTriggerAsync(global::Services.ArmTriggerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestArmTrigger, null, options, request);
      }
      public virtual global::Services.HardwareResetStatus RequestHardwareReset(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestHardwareReset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Services.HardwareResetStatus RequestHardwareReset(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestHardwareReset, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Services.HardwareResetStatus> RequestHardwareResetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestHardwareResetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Services.HardwareResetStatus> RequestHardwareResetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestHardwareReset, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CameraControllerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CameraControllerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CameraControllerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetInfo, serviceImpl.GetInfo)
          .AddMethod(__Method_IsConnected, serviceImpl.IsConnected)
          .AddMethod(__Method_RequestComList, serviceImpl.RequestComList)
          .AddMethod(__Method_RequestConnectToPort, serviceImpl.RequestConnectToPort)
          .AddMethod(__Method_RequestPowerStatus, serviceImpl.RequestPowerStatus)
          .AddMethod(__Method_RequestCurrentStatus, serviceImpl.RequestCurrentStatus)
          .AddMethod(__Method_RequestFocusStatus, serviceImpl.RequestFocusStatus)
          .AddMethod(__Method_RequestLaserStatus, serviceImpl.RequestLaserStatus)
          .AddMethod(__Method_RequestArmTrigger, serviceImpl.RequestArmTrigger)
          .AddMethod(__Method_RequestHardwareReset, serviceImpl.RequestHardwareReset).Build();
    }

  }
}
#endregion