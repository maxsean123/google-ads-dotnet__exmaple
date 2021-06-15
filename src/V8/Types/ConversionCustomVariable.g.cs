// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/conversion_custom_variable.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/conversion_custom_variable.proto</summary>
  public static partial class ConversionCustomVariableReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/conversion_custom_variable.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionCustomVariableReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMvY29udmVyc2lv",
            "bl9jdXN0b21fdmFyaWFibGUucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY4LnJlc291cmNlcxpFZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjgvZW51bXMv",
            "Y29udmVyc2lvbl9jdXN0b21fdmFyaWFibGVfc3RhdHVzLnByb3RvGh9nb29n",
            "bGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291",
            "cmNlLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIucDChhD",
            "b252ZXJzaW9uQ3VzdG9tVmFyaWFibGUSUAoNcmVzb3VyY2VfbmFtZRgBIAEo",
            "CUI54EEF+kEzCjFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ29udmVyc2lv",
            "bkN1c3RvbVZhcmlhYmxlEg8KAmlkGAIgASgDQgPgQQMSEQoEbmFtZRgDIAEo",
            "CUID4EECEhMKA3RhZxgEIAEoCUIG4EEC4EEFEnAKBnN0YXR1cxgFIAEoDjJg",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LmVudW1zLkNvbnZlcnNpb25DdXN0",
            "b21WYXJpYWJsZVN0YXR1c0VudW0uQ29udmVyc2lvbkN1c3RvbVZhcmlhYmxl",
            "U3RhdHVzEkEKDm93bmVyX2N1c3RvbWVyGAYgASgJQingQQP6QSMKIWdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lcjqKAepBhgEKMWdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9Db252ZXJzaW9uQ3VzdG9tVmFyaWFibGUSUWN1",
            "c3RvbWVycy97Y3VzdG9tZXJfaWR9L2NvbnZlcnNpb25DdXN0b21WYXJpYWJs",
            "ZXMve2NvbnZlcnNpb25fY3VzdG9tX3ZhcmlhYmxlX2lkfUKKAgolY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnY4LnJlc291cmNlc0IdQ29udmVyc2lvbkN1",
            "c3RvbVZhcmlhYmxlUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y4L3Jlc291cmNlcztyZXNv",
            "dXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WOC5SZXNvdXJj",
            "ZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWOFxSZXNvdXJjZXPqAiVHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWODo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.ConversionCustomVariable), global::Google.Ads.GoogleAds.V8.Resources.ConversionCustomVariable.Parser, new[]{ "ResourceName", "Id", "Name", "Tag", "Status", "OwnerCustomer" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A conversion custom variable
  /// See "About custom variables for conversions" at
  /// https://support.google.com/google-ads/answer/9964350
  /// </summary>
  public sealed partial class ConversionCustomVariable : pb::IMessage<ConversionCustomVariable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionCustomVariable> _parser = new pb::MessageParser<ConversionCustomVariable>(() => new ConversionCustomVariable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConversionCustomVariable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Resources.ConversionCustomVariableReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionCustomVariable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionCustomVariable(ConversionCustomVariable other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      tag_ = other.tag_;
      status_ = other.status_;
      ownerCustomer_ = other.ownerCustomer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionCustomVariable Clone() {
      return new ConversionCustomVariable(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the conversion custom variable.
    /// Conversion custom variable resource names have the form:
    ///
    /// `customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private long id_;
    /// <summary>
    /// Output only. The ID of the conversion custom variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the conversion custom variable.
    /// Name should be unique. The maximum length of name is 100 characters.
    /// There should not be any extra spaces before and after.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 4;
    private string tag_ = "";
    /// <summary>
    /// Required. Immutable. The tag of the conversion custom variable. It is used in the event snippet
    /// and sent to Google Ads along with conversion pings. For conversion uploads
    /// in Google Ads API, the resource name of the conversion custom variable is
    /// used.
    /// Tag should be unique. The maximum size of tag is 100 bytes.
    /// There should not be any extra spaces before and after.
    /// Currently only lowercase letters, numbers and underscores are allowed in
    /// the tag.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus status_ = global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Unspecified;
    /// <summary>
    /// The status of the conversion custom variable for conversion event accrual.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "owner_customer" field.</summary>
    public const int OwnerCustomerFieldNumber = 6;
    private string ownerCustomer_ = "";
    /// <summary>
    /// Output only. The resource name of the customer that owns the conversion custom variable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OwnerCustomer {
      get { return ownerCustomer_; }
      set {
        ownerCustomer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConversionCustomVariable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConversionCustomVariable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Tag != other.Tag) return false;
      if (Status != other.Status) return false;
      if (OwnerCustomer != other.OwnerCustomer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Unspecified) hash ^= Status.GetHashCode();
      if (OwnerCustomer.Length != 0) hash ^= OwnerCustomer.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Tag);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (OwnerCustomer.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OwnerCustomer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Tag);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (OwnerCustomer.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OwnerCustomer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (OwnerCustomer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerCustomer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConversionCustomVariable other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.OwnerCustomer.Length != 0) {
        OwnerCustomer = other.OwnerCustomer;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Tag = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus) input.ReadEnum();
            break;
          }
          case 50: {
            OwnerCustomer = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Tag = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V8.Enums.ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus) input.ReadEnum();
            break;
          }
          case 50: {
            OwnerCustomer = input.ReadString();
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
