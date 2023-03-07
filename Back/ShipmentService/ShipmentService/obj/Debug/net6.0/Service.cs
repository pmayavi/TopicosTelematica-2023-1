// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Service.proto</summary>
public static partial class ServiceReflection {

  #region Descriptor
  /// <summary>File descriptor for Service.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ServiceReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1TZXJ2aWNlLnByb3RvIhQKBFNlbmQSDAoEaXRlbRgBIAEoCSIqCg1DaGFu",
          "Z2VQcm9kdWN0EgwKBGl0ZW0YASABKAkSCwoDbnVtGAIgASgFIiUKBFNoaXAS",
          "DwoHYWRkcmVzcxgBIAEoCRIMCgRpdGVtGAIgASgJIjgKE1RyYW5zYWN0aW9u",
          "UmVzcG9uc2USDgoGc3RhdHVzGAEgASgIEhEKCWludmVudG9yeRgCIAEoBTJ0",
          "ChBJbnZlbnRvcnlTZXJ2aWNlEioKCUNoZWNrSXRlbRIFLlNlbmQaFC5UcmFu",
          "c2FjdGlvblJlc3BvbnNlIgASNAoKQ2hhbmdlSXRlbRIOLkNoYW5nZVByb2R1",
          "Y3QaFC5UcmFuc2FjdGlvblJlc3BvbnNlIgAyPAoOUGF5bWVudFNlcnZpY2US",
          "KgoJQ2hlY2tCYW5rEgUuU2VuZBoULlRyYW5zYWN0aW9uUmVzcG9uc2UiADI1",
          "CghTaGlwbWVudBIpCghTaGlwSXRlbRIFLlNoaXAaFC5UcmFuc2FjdGlvblJl",
          "c3BvbnNlIgBiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Send), global::Send.Parser, new[]{ "Item" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ChangeProduct), global::ChangeProduct.Parser, new[]{ "Item", "Num" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Ship), global::Ship.Parser, new[]{ "Address", "Item" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::TransactionResponse), global::TransactionResponse.Parser, new[]{ "Status", "Inventory" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Send : pb::IMessage<Send>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Send> _parser = new pb::MessageParser<Send>(() => new Send());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Send> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServiceReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Send() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Send(Send other) : this() {
    item_ = other.item_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Send Clone() {
    return new Send(this);
  }

  /// <summary>Field number for the "item" field.</summary>
  public const int ItemFieldNumber = 1;
  private string item_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Item {
    get { return item_; }
    set {
      item_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Send);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Send other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Item != other.Item) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Item.Length != 0) hash ^= Item.GetHashCode();
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
    if (Item.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Item);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Item.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Item);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Item.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Item);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Send other) {
    if (other == null) {
      return;
    }
    if (other.Item.Length != 0) {
      Item = other.Item;
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
          Item = input.ReadString();
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
          Item = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class ChangeProduct : pb::IMessage<ChangeProduct>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ChangeProduct> _parser = new pb::MessageParser<ChangeProduct>(() => new ChangeProduct());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ChangeProduct> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServiceReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ChangeProduct() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ChangeProduct(ChangeProduct other) : this() {
    item_ = other.item_;
    num_ = other.num_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ChangeProduct Clone() {
    return new ChangeProduct(this);
  }

  /// <summary>Field number for the "item" field.</summary>
  public const int ItemFieldNumber = 1;
  private string item_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Item {
    get { return item_; }
    set {
      item_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "num" field.</summary>
  public const int NumFieldNumber = 2;
  private int num_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Num {
    get { return num_; }
    set {
      num_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ChangeProduct);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ChangeProduct other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Item != other.Item) return false;
    if (Num != other.Num) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Item.Length != 0) hash ^= Item.GetHashCode();
    if (Num != 0) hash ^= Num.GetHashCode();
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
    if (Item.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Item);
    }
    if (Num != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Num);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Item.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Item);
    }
    if (Num != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Num);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Item.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Item);
    }
    if (Num != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ChangeProduct other) {
    if (other == null) {
      return;
    }
    if (other.Item.Length != 0) {
      Item = other.Item;
    }
    if (other.Num != 0) {
      Num = other.Num;
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
          Item = input.ReadString();
          break;
        }
        case 16: {
          Num = input.ReadInt32();
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
          Item = input.ReadString();
          break;
        }
        case 16: {
          Num = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Ship : pb::IMessage<Ship>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Ship> _parser = new pb::MessageParser<Ship>(() => new Ship());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Ship> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServiceReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Ship() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Ship(Ship other) : this() {
    address_ = other.address_;
    item_ = other.item_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Ship Clone() {
    return new Ship(this);
  }

  /// <summary>Field number for the "address" field.</summary>
  public const int AddressFieldNumber = 1;
  private string address_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Address {
    get { return address_; }
    set {
      address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "item" field.</summary>
  public const int ItemFieldNumber = 2;
  private string item_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Item {
    get { return item_; }
    set {
      item_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Ship);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Ship other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Address != other.Address) return false;
    if (Item != other.Item) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Address.Length != 0) hash ^= Address.GetHashCode();
    if (Item.Length != 0) hash ^= Item.GetHashCode();
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
    if (Address.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Address);
    }
    if (Item.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Item);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Address.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Address);
    }
    if (Item.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Item);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Address.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
    }
    if (Item.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Item);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Ship other) {
    if (other == null) {
      return;
    }
    if (other.Address.Length != 0) {
      Address = other.Address;
    }
    if (other.Item.Length != 0) {
      Item = other.Item;
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
          Address = input.ReadString();
          break;
        }
        case 18: {
          Item = input.ReadString();
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
          Address = input.ReadString();
          break;
        }
        case 18: {
          Item = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class TransactionResponse : pb::IMessage<TransactionResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TransactionResponse> _parser = new pb::MessageParser<TransactionResponse>(() => new TransactionResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TransactionResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServiceReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TransactionResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TransactionResponse(TransactionResponse other) : this() {
    status_ = other.status_;
    inventory_ = other.inventory_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TransactionResponse Clone() {
    return new TransactionResponse(this);
  }

  /// <summary>Field number for the "status" field.</summary>
  public const int StatusFieldNumber = 1;
  private bool status_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Status {
    get { return status_; }
    set {
      status_ = value;
    }
  }

  /// <summary>Field number for the "inventory" field.</summary>
  public const int InventoryFieldNumber = 2;
  private int inventory_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Inventory {
    get { return inventory_; }
    set {
      inventory_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TransactionResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TransactionResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Status != other.Status) return false;
    if (Inventory != other.Inventory) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Status != false) hash ^= Status.GetHashCode();
    if (Inventory != 0) hash ^= Inventory.GetHashCode();
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
    if (Status != false) {
      output.WriteRawTag(8);
      output.WriteBool(Status);
    }
    if (Inventory != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Inventory);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Status != false) {
      output.WriteRawTag(8);
      output.WriteBool(Status);
    }
    if (Inventory != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Inventory);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Status != false) {
      size += 1 + 1;
    }
    if (Inventory != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Inventory);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TransactionResponse other) {
    if (other == null) {
      return;
    }
    if (other.Status != false) {
      Status = other.Status;
    }
    if (other.Inventory != 0) {
      Inventory = other.Inventory;
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
        case 8: {
          Status = input.ReadBool();
          break;
        }
        case 16: {
          Inventory = input.ReadInt32();
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
        case 8: {
          Status = input.ReadBool();
          break;
        }
        case 16: {
          Inventory = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
