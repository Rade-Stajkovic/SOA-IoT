// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/airpi.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService.Protos {

  /// <summary>Holder for reflection information generated from Protos/airpi.proto</summary>
  public static partial class AirpiReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/airpi.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AirpiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvYWlycGkucHJvdG8SBWFpcnBpIhoKDEFpclBpVmFsdWVJZBIK",
            "CgJpZBgBIAEoCSL2AQoKQWlyUGlWYWx1ZRIKCgJpZBgBIAEoCRIQCghkYXRl",
            "dGltZRgCIAEoCRIOCgZ2b2x1bWUYAyABKAESEwoLbGlnaHRfbGV2ZWwYBCAB",
            "KAESFwoPdGVtcGVyYXR1cmVfZGh0GAUgASgBEhAKCHByZXNzdXJlGAYgASgB",
            "EhcKD3RlbXBlcmF0dXJlX2JtcBgHIAEoARIZChFyZWxhdGl2ZV9odW1pZGl0",
            "eRgIIAEoARITCgthaXJfcXVhbGl0eRgJIAEoARIXCg9jYXJib25fbW9ub3hp",
            "ZGUYCiABKAESGAoQbml0cm9nZW5fZGlveGlkZRgLIAEoASJSCgxWYWx1ZU1l",
            "c3NhZ2USCgoCaWQYASABKAkSDwoHbWVzc2FnZRgCIAEoCRIlCgphaXJwaXZh",
            "bHVlGAMgASgLMhEuYWlycGkuQWlyUGlWYWx1ZTLqAQoFQWlyUGkSPQoRR2V0",
            "QWlyUGlWYWx1ZUJ5SWQSEy5haXJwaS5BaXJQaVZhbHVlSWQaEy5haXJwaS5W",
            "YWx1ZU1lc3NhZ2USMgoIQWRkVmFsdWUSES5haXJwaS5BaXJQaVZhbHVlGhMu",
            "YWlycGkuVmFsdWVNZXNzYWdlEjcKC0RlbGV0ZVZhbHVlEhMuYWlycGkuQWly",
            "UGlWYWx1ZUlkGhMuYWlycGkuVmFsdWVNZXNzYWdlEjUKC1VwZGF0ZVZhbHVl",
            "EhEuYWlycGkuQWlyUGlWYWx1ZRoTLmFpcnBpLlZhbHVlTWVzc2FnZUIVqgIS",
            "R3JwY1NlcnZpY2UuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Protos.AirPiValueId), global::GrpcService.Protos.AirPiValueId.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Protos.AirPiValue), global::GrpcService.Protos.AirPiValue.Parser, new[]{ "Id", "Datetime", "Volume", "LightLevel", "TemperatureDht", "Pressure", "TemperatureBmp", "RelativeHumidity", "AirQuality", "CarbonMonoxide", "NitrogenDioxide" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Protos.ValueMessage), global::GrpcService.Protos.ValueMessage.Parser, new[]{ "Id", "Message", "Airpivalue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AirPiValueId : pb::IMessage<AirPiValueId>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AirPiValueId> _parser = new pb::MessageParser<AirPiValueId>(() => new AirPiValueId());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AirPiValueId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Protos.AirpiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AirPiValueId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AirPiValueId(AirPiValueId other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AirPiValueId Clone() {
      return new AirPiValueId(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AirPiValueId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AirPiValueId other) {
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
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
    public void MergeFrom(AirPiValueId other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
            Id = input.ReadString();
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
            Id = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AirPiValue : pb::IMessage<AirPiValue>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AirPiValue> _parser = new pb::MessageParser<AirPiValue>(() => new AirPiValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AirPiValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Protos.AirpiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AirPiValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AirPiValue(AirPiValue other) : this() {
      id_ = other.id_;
      datetime_ = other.datetime_;
      volume_ = other.volume_;
      lightLevel_ = other.lightLevel_;
      temperatureDht_ = other.temperatureDht_;
      pressure_ = other.pressure_;
      temperatureBmp_ = other.temperatureBmp_;
      relativeHumidity_ = other.relativeHumidity_;
      airQuality_ = other.airQuality_;
      carbonMonoxide_ = other.carbonMonoxide_;
      nitrogenDioxide_ = other.nitrogenDioxide_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AirPiValue Clone() {
      return new AirPiValue(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "datetime" field.</summary>
    public const int DatetimeFieldNumber = 2;
    private string datetime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Datetime {
      get { return datetime_; }
      set {
        datetime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "volume" field.</summary>
    public const int VolumeFieldNumber = 3;
    private double volume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Volume {
      get { return volume_; }
      set {
        volume_ = value;
      }
    }

    /// <summary>Field number for the "light_level" field.</summary>
    public const int LightLevelFieldNumber = 4;
    private double lightLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LightLevel {
      get { return lightLevel_; }
      set {
        lightLevel_ = value;
      }
    }

    /// <summary>Field number for the "temperature_dht" field.</summary>
    public const int TemperatureDhtFieldNumber = 5;
    private double temperatureDht_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double TemperatureDht {
      get { return temperatureDht_; }
      set {
        temperatureDht_ = value;
      }
    }

    /// <summary>Field number for the "pressure" field.</summary>
    public const int PressureFieldNumber = 6;
    private double pressure_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Pressure {
      get { return pressure_; }
      set {
        pressure_ = value;
      }
    }

    /// <summary>Field number for the "temperature_bmp" field.</summary>
    public const int TemperatureBmpFieldNumber = 7;
    private double temperatureBmp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double TemperatureBmp {
      get { return temperatureBmp_; }
      set {
        temperatureBmp_ = value;
      }
    }

    /// <summary>Field number for the "relative_humidity" field.</summary>
    public const int RelativeHumidityFieldNumber = 8;
    private double relativeHumidity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double RelativeHumidity {
      get { return relativeHumidity_; }
      set {
        relativeHumidity_ = value;
      }
    }

    /// <summary>Field number for the "air_quality" field.</summary>
    public const int AirQualityFieldNumber = 9;
    private double airQuality_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AirQuality {
      get { return airQuality_; }
      set {
        airQuality_ = value;
      }
    }

    /// <summary>Field number for the "carbon_monoxide" field.</summary>
    public const int CarbonMonoxideFieldNumber = 10;
    private double carbonMonoxide_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CarbonMonoxide {
      get { return carbonMonoxide_; }
      set {
        carbonMonoxide_ = value;
      }
    }

    /// <summary>Field number for the "nitrogen_dioxide" field.</summary>
    public const int NitrogenDioxideFieldNumber = 11;
    private double nitrogenDioxide_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double NitrogenDioxide {
      get { return nitrogenDioxide_; }
      set {
        nitrogenDioxide_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AirPiValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AirPiValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Datetime != other.Datetime) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Volume, other.Volume)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LightLevel, other.LightLevel)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TemperatureDht, other.TemperatureDht)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Pressure, other.Pressure)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TemperatureBmp, other.TemperatureBmp)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(RelativeHumidity, other.RelativeHumidity)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AirQuality, other.AirQuality)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CarbonMonoxide, other.CarbonMonoxide)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NitrogenDioxide, other.NitrogenDioxide)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Datetime.Length != 0) hash ^= Datetime.GetHashCode();
      if (Volume != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Volume);
      if (LightLevel != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LightLevel);
      if (TemperatureDht != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TemperatureDht);
      if (Pressure != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Pressure);
      if (TemperatureBmp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TemperatureBmp);
      if (RelativeHumidity != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(RelativeHumidity);
      if (AirQuality != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AirQuality);
      if (CarbonMonoxide != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CarbonMonoxide);
      if (NitrogenDioxide != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NitrogenDioxide);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Datetime.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Datetime);
      }
      if (Volume != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Volume);
      }
      if (LightLevel != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(LightLevel);
      }
      if (TemperatureDht != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(TemperatureDht);
      }
      if (Pressure != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Pressure);
      }
      if (TemperatureBmp != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(TemperatureBmp);
      }
      if (RelativeHumidity != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(RelativeHumidity);
      }
      if (AirQuality != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(AirQuality);
      }
      if (CarbonMonoxide != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(CarbonMonoxide);
      }
      if (NitrogenDioxide != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(NitrogenDioxide);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Datetime.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Datetime);
      }
      if (Volume != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Volume);
      }
      if (LightLevel != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(LightLevel);
      }
      if (TemperatureDht != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(TemperatureDht);
      }
      if (Pressure != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Pressure);
      }
      if (TemperatureBmp != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(TemperatureBmp);
      }
      if (RelativeHumidity != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(RelativeHumidity);
      }
      if (AirQuality != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(AirQuality);
      }
      if (CarbonMonoxide != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(CarbonMonoxide);
      }
      if (NitrogenDioxide != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(NitrogenDioxide);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Datetime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Datetime);
      }
      if (Volume != 0D) {
        size += 1 + 8;
      }
      if (LightLevel != 0D) {
        size += 1 + 8;
      }
      if (TemperatureDht != 0D) {
        size += 1 + 8;
      }
      if (Pressure != 0D) {
        size += 1 + 8;
      }
      if (TemperatureBmp != 0D) {
        size += 1 + 8;
      }
      if (RelativeHumidity != 0D) {
        size += 1 + 8;
      }
      if (AirQuality != 0D) {
        size += 1 + 8;
      }
      if (CarbonMonoxide != 0D) {
        size += 1 + 8;
      }
      if (NitrogenDioxide != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AirPiValue other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Datetime.Length != 0) {
        Datetime = other.Datetime;
      }
      if (other.Volume != 0D) {
        Volume = other.Volume;
      }
      if (other.LightLevel != 0D) {
        LightLevel = other.LightLevel;
      }
      if (other.TemperatureDht != 0D) {
        TemperatureDht = other.TemperatureDht;
      }
      if (other.Pressure != 0D) {
        Pressure = other.Pressure;
      }
      if (other.TemperatureBmp != 0D) {
        TemperatureBmp = other.TemperatureBmp;
      }
      if (other.RelativeHumidity != 0D) {
        RelativeHumidity = other.RelativeHumidity;
      }
      if (other.AirQuality != 0D) {
        AirQuality = other.AirQuality;
      }
      if (other.CarbonMonoxide != 0D) {
        CarbonMonoxide = other.CarbonMonoxide;
      }
      if (other.NitrogenDioxide != 0D) {
        NitrogenDioxide = other.NitrogenDioxide;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Datetime = input.ReadString();
            break;
          }
          case 25: {
            Volume = input.ReadDouble();
            break;
          }
          case 33: {
            LightLevel = input.ReadDouble();
            break;
          }
          case 41: {
            TemperatureDht = input.ReadDouble();
            break;
          }
          case 49: {
            Pressure = input.ReadDouble();
            break;
          }
          case 57: {
            TemperatureBmp = input.ReadDouble();
            break;
          }
          case 65: {
            RelativeHumidity = input.ReadDouble();
            break;
          }
          case 73: {
            AirQuality = input.ReadDouble();
            break;
          }
          case 81: {
            CarbonMonoxide = input.ReadDouble();
            break;
          }
          case 89: {
            NitrogenDioxide = input.ReadDouble();
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Datetime = input.ReadString();
            break;
          }
          case 25: {
            Volume = input.ReadDouble();
            break;
          }
          case 33: {
            LightLevel = input.ReadDouble();
            break;
          }
          case 41: {
            TemperatureDht = input.ReadDouble();
            break;
          }
          case 49: {
            Pressure = input.ReadDouble();
            break;
          }
          case 57: {
            TemperatureBmp = input.ReadDouble();
            break;
          }
          case 65: {
            RelativeHumidity = input.ReadDouble();
            break;
          }
          case 73: {
            AirQuality = input.ReadDouble();
            break;
          }
          case 81: {
            CarbonMonoxide = input.ReadDouble();
            break;
          }
          case 89: {
            NitrogenDioxide = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ValueMessage : pb::IMessage<ValueMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValueMessage> _parser = new pb::MessageParser<ValueMessage>(() => new ValueMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ValueMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Protos.AirpiReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueMessage(ValueMessage other) : this() {
      id_ = other.id_;
      message_ = other.message_;
      airpivalue_ = other.airpivalue_ != null ? other.airpivalue_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueMessage Clone() {
      return new ValueMessage(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "airpivalue" field.</summary>
    public const int AirpivalueFieldNumber = 3;
    private global::GrpcService.Protos.AirPiValue airpivalue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcService.Protos.AirPiValue Airpivalue {
      get { return airpivalue_; }
      set {
        airpivalue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ValueMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ValueMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Message != other.Message) return false;
      if (!object.Equals(Airpivalue, other.Airpivalue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (airpivalue_ != null) hash ^= Airpivalue.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (airpivalue_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Airpivalue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (airpivalue_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Airpivalue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (airpivalue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Airpivalue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ValueMessage other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.airpivalue_ != null) {
        if (airpivalue_ == null) {
          Airpivalue = new global::GrpcService.Protos.AirPiValue();
        }
        Airpivalue.MergeFrom(other.Airpivalue);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            if (airpivalue_ == null) {
              Airpivalue = new global::GrpcService.Protos.AirPiValue();
            }
            input.ReadMessage(Airpivalue);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            if (airpivalue_ == null) {
              Airpivalue = new global::GrpcService.Protos.AirPiValue();
            }
            input.ReadMessage(Airpivalue);
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
