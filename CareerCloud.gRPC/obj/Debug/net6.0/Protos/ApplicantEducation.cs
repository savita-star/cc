// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantEducation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantEducation.proto</summary>
  public static partial class ApplicantEducationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantEducation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantEducationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvQXBwbGljYW50RWR1Y2F0aW9uLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGh9nb29nbGUvcHJvdG9idWYvVGltZXN0YW1wLnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9l",
            "bXB0eS5wcm90byIpChtBcHBsaWNhbnRFZHVjYXRpb25JZFJlcXVlc3QSCgoC",
            "SWQYASABKAki9wEKEkFwcGxpY2FudEVkdWNhdGlvbhIKCgJJZBgBIAEoCRIR",
            "CglBcHBsaWNhbnQYAiABKAkSDQoFTWFqb3IYAyABKAkSGgoSQ2VydGlmaWNh",
            "dGVEaXBsb21hGAQgASgJEi0KCVN0YXJ0RGF0ZRgFIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5UaW1lc3RhbXASMgoOQ29tcGxldGlvbkRhdGUYBiABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wEjQKD0NvbXBsZXRlUGVyY2VudBgH",
            "IAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQzMlZhbHVlIksKE0FwcGxpY2Fu",
            "dEVkdWNhdGlvbnMSNAoGQXBwRWR1GAEgAygLMiQuQ2FyZWVyQ2xvdWQuZ1JQ",
            "Qy5BcHBsaWNhbnRFZHVjYXRpb24y8AMKGUFwcGxpY2FudEVkdWNhdGlvblNl",
            "cnZpY2USbAoVR2V0QXBwbGljYW50RWR1Y2F0aW9uEi0uQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5BcHBsaWNhbnRFZHVjYXRpb25JZFJlcXVlc3QaJC5DYXJlZXJDbG91",
            "ZC5nUlBDLkFwcGxpY2FudEVkdWNhdGlvbhJXChZHZXRBcHBsaWNhbnRFZHVj",
            "YXRpb25zEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GiUuQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5BcHBsaWNhbnRFZHVjYXRpb25zElYKFUFkZEFwcGxpY2FudEVkdWNh",
            "dGlvbhIlLkNhcmVlckNsb3VkLmdSUEMuQXBwbGljYW50RWR1Y2F0aW9ucxoW",
            "Lmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJZChhVcGRhdGVBcHBsaWNhbnRFZHVj",
            "YXRpb24SJS5DYXJlZXJDbG91ZC5nUlBDLkFwcGxpY2FudEVkdWNhdGlvbnMa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkSWQoYRGVsZXRlQXBwbGljYW50RWR1",
            "Y2F0aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNhbnRFZHVjYXRpb25z",
            "GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QhqqAhdDYXJlZXJDbG91ZC5nUlBD",
            "LlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantEducationIdRequest), global::CareerCloud.gRPC.Protos.ApplicantEducationIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantEducation), global::CareerCloud.gRPC.Protos.ApplicantEducation.Parser, new[]{ "Id", "Applicant", "Major", "CertificateDiploma", "StartDate", "CompletionDate", "CompletePercent" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantEducations), global::CareerCloud.gRPC.Protos.ApplicantEducations.Parser, new[]{ "AppEdu" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ApplicantEducationIdRequest : pb::IMessage<ApplicantEducationIdRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ApplicantEducationIdRequest> _parser = new pb::MessageParser<ApplicantEducationIdRequest>(() => new ApplicantEducationIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ApplicantEducationIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantEducationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducationIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducationIdRequest(ApplicantEducationIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducationIdRequest Clone() {
      return new ApplicantEducationIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ApplicantEducationIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ApplicantEducationIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ApplicantEducationIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ApplicantEducation : pb::IMessage<ApplicantEducation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ApplicantEducation> _parser = new pb::MessageParser<ApplicantEducation>(() => new ApplicantEducation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ApplicantEducation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantEducationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducation(ApplicantEducation other) : this() {
      id_ = other.id_;
      applicant_ = other.applicant_;
      major_ = other.major_;
      certificateDiploma_ = other.certificateDiploma_;
      startDate_ = other.startDate_ != null ? other.startDate_.Clone() : null;
      completionDate_ = other.completionDate_ != null ? other.completionDate_.Clone() : null;
      CompletePercent = other.CompletePercent;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducation Clone() {
      return new ApplicantEducation(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Applicant" field.</summary>
    public const int ApplicantFieldNumber = 2;
    private string applicant_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Applicant {
      get { return applicant_; }
      set {
        applicant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Major" field.</summary>
    public const int MajorFieldNumber = 3;
    private string major_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Major {
      get { return major_; }
      set {
        major_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CertificateDiploma" field.</summary>
    public const int CertificateDiplomaFieldNumber = 4;
    private string certificateDiploma_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CertificateDiploma {
      get { return certificateDiploma_; }
      set {
        certificateDiploma_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StartDate" field.</summary>
    public const int StartDateFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }

    /// <summary>Field number for the "CompletionDate" field.</summary>
    public const int CompletionDateFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp completionDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CompletionDate {
      get { return completionDate_; }
      set {
        completionDate_ = value;
      }
    }

    /// <summary>Field number for the "CompletePercent" field.</summary>
    public const int CompletePercentFieldNumber = 7;
    private static readonly pb::FieldCodec<int?> _single_completePercent_codec = pb::FieldCodec.ForStructWrapper<int>(58);
    private int? completePercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? CompletePercent {
      get { return completePercent_; }
      set {
        completePercent_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ApplicantEducation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ApplicantEducation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Applicant != other.Applicant) return false;
      if (Major != other.Major) return false;
      if (CertificateDiploma != other.CertificateDiploma) return false;
      if (!object.Equals(StartDate, other.StartDate)) return false;
      if (!object.Equals(CompletionDate, other.CompletionDate)) return false;
      if (CompletePercent != other.CompletePercent) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Applicant.Length != 0) hash ^= Applicant.GetHashCode();
      if (Major.Length != 0) hash ^= Major.GetHashCode();
      if (CertificateDiploma.Length != 0) hash ^= CertificateDiploma.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (completionDate_ != null) hash ^= CompletionDate.GetHashCode();
      if (completePercent_ != null) hash ^= CompletePercent.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Applicant.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Applicant);
      }
      if (Major.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Major);
      }
      if (CertificateDiploma.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CertificateDiploma);
      }
      if (startDate_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(StartDate);
      }
      if (completionDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CompletionDate);
      }
      if (completePercent_ != null) {
        _single_completePercent_codec.WriteTagAndValue(output, CompletePercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Applicant.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Applicant);
      }
      if (Major.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Major);
      }
      if (CertificateDiploma.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CertificateDiploma);
      }
      if (startDate_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(StartDate);
      }
      if (completionDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CompletionDate);
      }
      if (completePercent_ != null) {
        _single_completePercent_codec.WriteTagAndValue(ref output, CompletePercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Applicant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Applicant);
      }
      if (Major.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Major);
      }
      if (CertificateDiploma.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CertificateDiploma);
      }
      if (startDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartDate);
      }
      if (completionDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CompletionDate);
      }
      if (completePercent_ != null) {
        size += _single_completePercent_codec.CalculateSizeWithTag(CompletePercent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ApplicantEducation other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Applicant.Length != 0) {
        Applicant = other.Applicant;
      }
      if (other.Major.Length != 0) {
        Major = other.Major;
      }
      if (other.CertificateDiploma.Length != 0) {
        CertificateDiploma = other.CertificateDiploma;
      }
      if (other.startDate_ != null) {
        if (startDate_ == null) {
          StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartDate.MergeFrom(other.StartDate);
      }
      if (other.completionDate_ != null) {
        if (completionDate_ == null) {
          CompletionDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CompletionDate.MergeFrom(other.CompletionDate);
      }
      if (other.completePercent_ != null) {
        if (completePercent_ == null || other.CompletePercent != 0) {
          CompletePercent = other.CompletePercent;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Applicant = input.ReadString();
            break;
          }
          case 26: {
            Major = input.ReadString();
            break;
          }
          case 34: {
            CertificateDiploma = input.ReadString();
            break;
          }
          case 42: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 50: {
            if (completionDate_ == null) {
              CompletionDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CompletionDate);
            break;
          }
          case 58: {
            int? value = _single_completePercent_codec.Read(input);
            if (completePercent_ == null || value != 0) {
              CompletePercent = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Applicant = input.ReadString();
            break;
          }
          case 26: {
            Major = input.ReadString();
            break;
          }
          case 34: {
            CertificateDiploma = input.ReadString();
            break;
          }
          case 42: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 50: {
            if (completionDate_ == null) {
              CompletionDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CompletionDate);
            break;
          }
          case 58: {
            int? value = _single_completePercent_codec.Read(ref input);
            if (completePercent_ == null || value != 0) {
              CompletePercent = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ApplicantEducations : pb::IMessage<ApplicantEducations>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ApplicantEducations> _parser = new pb::MessageParser<ApplicantEducations>(() => new ApplicantEducations());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ApplicantEducations> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantEducationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducations() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducations(ApplicantEducations other) : this() {
      appEdu_ = other.appEdu_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ApplicantEducations Clone() {
      return new ApplicantEducations(this);
    }

    /// <summary>Field number for the "AppEdu" field.</summary>
    public const int AppEduFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.ApplicantEducation> _repeated_appEdu_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.ApplicantEducation.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.ApplicantEducation> appEdu_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.ApplicantEducation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.ApplicantEducation> AppEdu {
      get { return appEdu_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ApplicantEducations);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ApplicantEducations other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!appEdu_.Equals(other.appEdu_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= appEdu_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      appEdu_.WriteTo(output, _repeated_appEdu_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      appEdu_.WriteTo(ref output, _repeated_appEdu_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += appEdu_.CalculateSize(_repeated_appEdu_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ApplicantEducations other) {
      if (other == null) {
        return;
      }
      appEdu_.Add(other.appEdu_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            appEdu_.AddEntriesFrom(input, _repeated_appEdu_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            appEdu_.AddEntriesFrom(ref input, _repeated_appEdu_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
