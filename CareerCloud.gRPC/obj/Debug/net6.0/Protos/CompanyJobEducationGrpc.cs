// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobEducation.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class CompanyJobEducationService
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.CompanyJobEducationService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest> __Marshaller_CareerCloud_gRPC_CompanyJobEducationIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobEducation> __Marshaller_CareerCloud_gRPC_CompanyJobEducation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyJobEducation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobEducations> __Marshaller_CareerCloud_gRPC_CompanyJobEducations = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.CompanyJobEducations.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest, global::CareerCloud.gRPC.Protos.CompanyJobEducation> __Method_GetCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest, global::CareerCloud.gRPC.Protos.CompanyJobEducation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducationIdRequest,
        __Marshaller_CareerCloud_gRPC_CompanyJobEducation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.CompanyJobEducations> __Method_GetCompanyJobEducations = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.CompanyJobEducations>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompanyJobEducations",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_CareerCloud_gRPC_CompanyJobEducations);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducations,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducations,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducations,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobEducationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyJobEducationService</summary>
    [grpc::BindServiceMethod(typeof(CompanyJobEducationService), "BindService")]
    public abstract partial class CompanyJobEducationServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyJobEducation> GetCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyJobEducations> GetCompanyJobEducations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducations request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducations request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducations request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CompanyJobEducationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCompanyJobEducation, serviceImpl.GetCompanyJobEducation)
          .AddMethod(__Method_GetCompanyJobEducations, serviceImpl.GetCompanyJobEducations)
          .AddMethod(__Method_AddCompanyJobEducation, serviceImpl.AddCompanyJobEducation)
          .AddMethod(__Method_UpdateCompanyJobEducation, serviceImpl.UpdateCompanyJobEducation)
          .AddMethod(__Method_DeleteCompanyJobEducation, serviceImpl.DeleteCompanyJobEducation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CompanyJobEducationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest, global::CareerCloud.gRPC.Protos.CompanyJobEducation>(serviceImpl.GetCompanyJobEducation));
      serviceBinder.AddMethod(__Method_GetCompanyJobEducations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.CompanyJobEducations>(serviceImpl.GetCompanyJobEducations));
      serviceBinder.AddMethod(__Method_AddCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.AddCompanyJobEducation));
      serviceBinder.AddMethod(__Method_UpdateCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateCompanyJobEducation));
      serviceBinder.AddMethod(__Method_DeleteCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducations, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCompanyJobEducation));
    }

  }
}
#endregion
