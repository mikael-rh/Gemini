// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: simulation/simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GeminiOSPInterface {

  /// <summary>Holder for reflection information generated from simulation/simulation.proto</summary>
  public static partial class SimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for simulation/simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtzaW11bGF0aW9uL3NpbXVsYXRpb24ucHJvdG8SEkdlbWluaU9TUEludGVy",
            "ZmFjZSI0CgRQb3NlEg0KBW5vcnRoGAEgASgCEgwKBGVhc3QYAiABKAISDwoH",
            "aGVhZGluZxgDIAEoAiJcCgtTdGVwUmVxdWVzdBItCgtWZXNzZWxQb3NlcxgB",
            "IAMoCzIYLkdlbWluaU9TUEludGVyZmFjZS5Qb3NlEgwKBHRpbWUYAiABKAIS",
            "EAoIc3RlcFNpemUYAyABKAIiHwoMU3RlcFJlc3BvbnNlEg8KB3N1Y2Nlc3MY",
            "ASABKAgiIwoTU2V0U3RhcnRUaW1lUmVxdWVzdBIMCgR0aW1lGAEgASgJIicK",
            "FFNldFN0YXJ0VGltZVJlc3BvbnNlEg8KB3N1Y2Nlc3MYASABKAgywAEKClNp",
            "bXVsYXRpb24STQoGRG9TdGVwEh8uR2VtaW5pT1NQSW50ZXJmYWNlLlN0ZXBS",
            "ZXF1ZXN0GiAuR2VtaW5pT1NQSW50ZXJmYWNlLlN0ZXBSZXNwb25zZSIAEmMK",
            "DFNldFN0YXJ0VGltZRInLkdlbWluaU9TUEludGVyZmFjZS5TZXRTdGFydFRp",
            "bWVSZXF1ZXN0GiguR2VtaW5pT1NQSW50ZXJmYWNlLlNldFN0YXJ0VGltZVJl",
            "c3BvbnNlIgBCMgocYXV0b2ZlcnJ5LmNsaWVudHMuc2ltdWxhdGlvbkIKc2lt",
            "dWxhdGlvblABogIDSExXYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GeminiOSPInterface.Pose), global::GeminiOSPInterface.Pose.Parser, new[]{ "North", "East", "Heading" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GeminiOSPInterface.StepRequest), global::GeminiOSPInterface.StepRequest.Parser, new[]{ "VesselPoses", "Time", "StepSize" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GeminiOSPInterface.StepResponse), global::GeminiOSPInterface.StepResponse.Parser, new[]{ "Success" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GeminiOSPInterface.SetStartTimeRequest), global::GeminiOSPInterface.SetStartTimeRequest.Parser, new[]{ "Time" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GeminiOSPInterface.SetStartTimeResponse), global::GeminiOSPInterface.SetStartTimeResponse.Parser, new[]{ "Success" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Pose : pb::IMessage<Pose> {
    private static readonly pb::MessageParser<Pose> _parser = new pb::MessageParser<Pose>(() => new Pose());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Pose> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GeminiOSPInterface.SimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pose() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pose(Pose other) : this() {
      north_ = other.north_;
      east_ = other.east_;
      heading_ = other.heading_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pose Clone() {
      return new Pose(this);
    }

    /// <summary>Field number for the "north" field.</summary>
    public const int NorthFieldNumber = 1;
    private float north_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float North {
      get { return north_; }
      set {
        north_ = value;
      }
    }

    /// <summary>Field number for the "east" field.</summary>
    public const int EastFieldNumber = 2;
    private float east_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float East {
      get { return east_; }
      set {
        east_ = value;
      }
    }

    /// <summary>Field number for the "heading" field.</summary>
    public const int HeadingFieldNumber = 3;
    private float heading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Heading {
      get { return heading_; }
      set {
        heading_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Pose);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Pose other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(North, other.North)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(East, other.East)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Heading, other.Heading)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (North != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(North);
      if (East != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(East);
      if (Heading != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Heading);
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
      if (North != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(North);
      }
      if (East != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(East);
      }
      if (Heading != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Heading);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (North != 0F) {
        size += 1 + 4;
      }
      if (East != 0F) {
        size += 1 + 4;
      }
      if (Heading != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Pose other) {
      if (other == null) {
        return;
      }
      if (other.North != 0F) {
        North = other.North;
      }
      if (other.East != 0F) {
        East = other.East;
      }
      if (other.Heading != 0F) {
        Heading = other.Heading;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            North = input.ReadFloat();
            break;
          }
          case 21: {
            East = input.ReadFloat();
            break;
          }
          case 29: {
            Heading = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StepRequest : pb::IMessage<StepRequest> {
    private static readonly pb::MessageParser<StepRequest> _parser = new pb::MessageParser<StepRequest>(() => new StepRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StepRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GeminiOSPInterface.SimulationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepRequest(StepRequest other) : this() {
      vesselPoses_ = other.vesselPoses_.Clone();
      time_ = other.time_;
      stepSize_ = other.stepSize_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepRequest Clone() {
      return new StepRequest(this);
    }

    /// <summary>Field number for the "VesselPoses" field.</summary>
    public const int VesselPosesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GeminiOSPInterface.Pose> _repeated_vesselPoses_codec
        = pb::FieldCodec.ForMessage(10, global::GeminiOSPInterface.Pose.Parser);
    private readonly pbc::RepeatedField<global::GeminiOSPInterface.Pose> vesselPoses_ = new pbc::RepeatedField<global::GeminiOSPInterface.Pose>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GeminiOSPInterface.Pose> VesselPoses {
      get { return vesselPoses_; }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 2;
    private float time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "stepSize" field.</summary>
    public const int StepSizeFieldNumber = 3;
    private float stepSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float StepSize {
      get { return stepSize_; }
      set {
        stepSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StepRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StepRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!vesselPoses_.Equals(other.vesselPoses_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Time, other.Time)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StepSize, other.StepSize)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= vesselPoses_.GetHashCode();
      if (Time != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Time);
      if (StepSize != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StepSize);
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
      vesselPoses_.WriteTo(output, _repeated_vesselPoses_codec);
      if (Time != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Time);
      }
      if (StepSize != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(StepSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vesselPoses_.CalculateSize(_repeated_vesselPoses_codec);
      if (Time != 0F) {
        size += 1 + 4;
      }
      if (StepSize != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StepRequest other) {
      if (other == null) {
        return;
      }
      vesselPoses_.Add(other.vesselPoses_);
      if (other.Time != 0F) {
        Time = other.Time;
      }
      if (other.StepSize != 0F) {
        StepSize = other.StepSize;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            vesselPoses_.AddEntriesFrom(input, _repeated_vesselPoses_codec);
            break;
          }
          case 21: {
            Time = input.ReadFloat();
            break;
          }
          case 29: {
            StepSize = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StepResponse : pb::IMessage<StepResponse> {
    private static readonly pb::MessageParser<StepResponse> _parser = new pb::MessageParser<StepResponse>(() => new StepResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StepResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GeminiOSPInterface.SimulationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepResponse(StepResponse other) : this() {
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StepResponse Clone() {
      return new StepResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StepResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StepResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StepResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetStartTimeRequest : pb::IMessage<SetStartTimeRequest> {
    private static readonly pb::MessageParser<SetStartTimeRequest> _parser = new pb::MessageParser<SetStartTimeRequest>(() => new SetStartTimeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetStartTimeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GeminiOSPInterface.SimulationReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetStartTimeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetStartTimeRequest(SetStartTimeRequest other) : this() {
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetStartTimeRequest Clone() {
      return new SetStartTimeRequest(this);
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private string time_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Time {
      get { return time_; }
      set {
        time_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetStartTimeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetStartTimeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time != other.Time) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Time.Length != 0) hash ^= Time.GetHashCode();
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
      if (Time.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Time);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Time.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Time);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetStartTimeRequest other) {
      if (other == null) {
        return;
      }
      if (other.Time.Length != 0) {
        Time = other.Time;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Time = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetStartTimeResponse : pb::IMessage<SetStartTimeResponse> {
    private static readonly pb::MessageParser<SetStartTimeResponse> _parser = new pb::MessageParser<SetStartTimeResponse>(() => new SetStartTimeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetStartTimeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GeminiOSPInterface.SimulationReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetStartTimeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetStartTimeResponse(SetStartTimeResponse other) : this() {
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetStartTimeResponse Clone() {
      return new SetStartTimeResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetStartTimeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetStartTimeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetStartTimeResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
