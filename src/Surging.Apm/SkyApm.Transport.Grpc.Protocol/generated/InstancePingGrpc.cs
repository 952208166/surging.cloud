// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: register/InstancePing.proto
// </auto-generated>
// Original file comments:
//
// Licensed to the Apache Software Foundation (ASF) under one or more
// contributor license agreements.  See the NOTICE file distributed with
// this work for additional information regarding copyright ownership.
// The ASF licenses this file to You under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with
// the License.  You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SkyWalking.NetworkProtocol {
  public static partial class ServiceInstancePing
  {
    static readonly string __ServiceName = "ServiceInstancePing";

    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg> __Marshaller_ServiceInstancePingPkg = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.Commands> __Marshaller_Commands = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SkyWalking.NetworkProtocol.Commands.Parser.ParseFrom);

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg, global::SkyWalking.NetworkProtocol.Commands> __Method_doPing = new grpc::Method<global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg, global::SkyWalking.NetworkProtocol.Commands>(
        grpc::MethodType.Unary,
        __ServiceName,
        "doPing",
        __Marshaller_ServiceInstancePingPkg,
        __Marshaller_Commands);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SkyWalking.NetworkProtocol.InstancePingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServiceInstancePing</summary>
    public abstract partial class ServiceInstancePingBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.Commands> doPing(global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServiceInstancePing</summary>
    public partial class ServiceInstancePingClient : grpc::ClientBase<ServiceInstancePingClient>
    {
      /// <summary>Creates a new client for ServiceInstancePing</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ServiceInstancePingClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServiceInstancePing that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ServiceInstancePingClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ServiceInstancePingClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ServiceInstancePingClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SkyWalking.NetworkProtocol.Commands doPing(global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return doPing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SkyWalking.NetworkProtocol.Commands doPing(global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_doPing, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.Commands> doPingAsync(global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return doPingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SkyWalking.NetworkProtocol.Commands> doPingAsync(global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_doPing, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ServiceInstancePingClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceInstancePingClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ServiceInstancePingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_doPing, serviceImpl.doPing).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServiceInstancePingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_doPing, serviceImpl.doPing);
    }

  }
}
#endregion
