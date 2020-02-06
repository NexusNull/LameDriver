// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents/envs/communicator_objects/unity_rl_input.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents/envs/communicator_objects/unity_rl_input.proto</summary>
  public static partial class UnityRlInputReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents/envs/communicator_objects/unity_rl_input.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityRlInputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdtbGFnZW50cy9lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X3Js",
            "X2lucHV0LnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cxo1bWxhZ2VudHMv",
            "ZW52cy9jb21tdW5pY2F0b3Jfb2JqZWN0cy9hZ2VudF9hY3Rpb24ucHJvdG8a",
            "MG1sYWdlbnRzL2VudnMvY29tbXVuaWNhdG9yX29iamVjdHMvY29tbWFuZC5w",
            "cm90byL+AgoRVW5pdHlSTElucHV0UHJvdG8SUAoNYWdlbnRfYWN0aW9ucxgB",
            "IAMoCzI5LmNvbW11bmljYXRvcl9vYmplY3RzLlVuaXR5UkxJbnB1dFByb3Rv",
            "LkFnZW50QWN0aW9uc0VudHJ5EjMKB2NvbW1hbmQYBCABKA4yIi5jb21tdW5p",
            "Y2F0b3Jfb2JqZWN0cy5Db21tYW5kUHJvdG8SFAoMc2lkZV9jaGFubmVsGAUg",
            "ASgMGk0KFExpc3RBZ2VudEFjdGlvblByb3RvEjUKBXZhbHVlGAEgAygLMiYu",
            "Y29tbXVuaWNhdG9yX29iamVjdHMuQWdlbnRBY3Rpb25Qcm90bxpxChFBZ2Vu",
            "dEFjdGlvbnNFbnRyeRILCgNrZXkYASABKAkSSwoFdmFsdWUYAiABKAsyPC5j",
            "b21tdW5pY2F0b3Jfb2JqZWN0cy5Vbml0eVJMSW5wdXRQcm90by5MaXN0QWdl",
            "bnRBY3Rpb25Qcm90bzoCOAFKBAgCEANKBAgDEARCH6oCHE1MQWdlbnRzLkNv",
            "bW11bmljYXRvck9iamVjdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.AgentActionReflection.Descriptor, global::MLAgents.CommunicatorObjects.CommandReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityRLInputProto), global::MLAgents.CommunicatorObjects.UnityRLInputProto.Parser, new[]{ "AgentActions", "Command", "SideChannel" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto), global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto.Parser, new[]{ "Value" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnityRLInputProto : pb::IMessage<UnityRLInputProto> {
    private static readonly pb::MessageParser<UnityRLInputProto> _parser = new pb::MessageParser<UnityRLInputProto>(() => new UnityRLInputProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityRLInputProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.UnityRlInputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInputProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInputProto(UnityRLInputProto other) : this() {
      agentActions_ = other.agentActions_.Clone();
      command_ = other.command_;
      sideChannel_ = other.sideChannel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInputProto Clone() {
      return new UnityRLInputProto(this);
    }

    /// <summary>Field number for the "agent_actions" field.</summary>
    public const int AgentActionsFieldNumber = 1;
    private static readonly pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto>.Codec _map_agentActions_codec
        = new pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto.Parser), 10);
    private readonly pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto> agentActions_ = new pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto> AgentActions {
      get { return agentActions_; }
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int CommandFieldNumber = 4;
    private global::MLAgents.CommunicatorObjects.CommandProto command_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.CommandProto Command {
      get { return command_; }
      set {
        command_ = value;
      }
    }

    /// <summary>Field number for the "side_channel" field.</summary>
    public const int SideChannelFieldNumber = 5;
    private pb::ByteString sideChannel_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SideChannel {
      get { return sideChannel_; }
      set {
        sideChannel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityRLInputProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityRLInputProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!AgentActions.Equals(other.AgentActions)) return false;
      if (Command != other.Command) return false;
      if (SideChannel != other.SideChannel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= AgentActions.GetHashCode();
      if (Command != 0) hash ^= Command.GetHashCode();
      if (SideChannel.Length != 0) hash ^= SideChannel.GetHashCode();
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
      agentActions_.WriteTo(output, _map_agentActions_codec);
      if (Command != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Command);
      }
      if (SideChannel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(SideChannel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += agentActions_.CalculateSize(_map_agentActions_codec);
      if (Command != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Command);
      }
      if (SideChannel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SideChannel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityRLInputProto other) {
      if (other == null) {
        return;
      }
      agentActions_.Add(other.agentActions_);
      if (other.Command != 0) {
        Command = other.Command;
      }
      if (other.SideChannel.Length != 0) {
        SideChannel = other.SideChannel;
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
            agentActions_.AddEntriesFrom(input, _map_agentActions_codec);
            break;
          }
          case 32: {
            command_ = (global::MLAgents.CommunicatorObjects.CommandProto) input.ReadEnum();
            break;
          }
          case 42: {
            SideChannel = input.ReadBytes();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UnityRLInputProto message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class ListAgentActionProto : pb::IMessage<ListAgentActionProto> {
        private static readonly pb::MessageParser<ListAgentActionProto> _parser = new pb::MessageParser<ListAgentActionProto>(() => new ListAgentActionProto());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ListAgentActionProto> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::MLAgents.CommunicatorObjects.UnityRLInputProto.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentActionProto() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentActionProto(ListAgentActionProto other) : this() {
          value_ = other.value_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentActionProto Clone() {
          return new ListAgentActionProto(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private static readonly pb::FieldCodec<global::MLAgents.CommunicatorObjects.AgentActionProto> _repeated_value_codec
            = pb::FieldCodec.ForMessage(10, global::MLAgents.CommunicatorObjects.AgentActionProto.Parser);
        private readonly pbc::RepeatedField<global::MLAgents.CommunicatorObjects.AgentActionProto> value_ = new pbc::RepeatedField<global::MLAgents.CommunicatorObjects.AgentActionProto>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::MLAgents.CommunicatorObjects.AgentActionProto> Value {
          get { return value_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ListAgentActionProto);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ListAgentActionProto other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!value_.Equals(other.value_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= value_.GetHashCode();
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
          value_.WriteTo(output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += value_.CalculateSize(_repeated_value_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ListAgentActionProto other) {
          if (other == null) {
            return;
          }
          value_.Add(other.value_);
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
                value_.AddEntriesFrom(input, _repeated_value_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
