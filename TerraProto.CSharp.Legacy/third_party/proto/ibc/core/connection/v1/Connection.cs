
using TerraProto.CSharp.third_party.proto.ibc.core.commitment.v1;

namespace TerraProto.CSharp.third_party.proto.ibc.core.connection.v1
{
    [global::ProtoBuf.ProtoContract()]
    public enum State
    {
        [global::ProtoBuf.ProtoEnum(Name = @"STATE_UNINITIALIZED_UNSPECIFIED")]
        StateUninitializedUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"STATE_INIT")]
        StateInit = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"STATE_TRYOPEN")]
        StateTryopen = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"STATE_OPEN")]
        StateOpen = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConnectionEnd : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"versions")]
        public global::System.Collections.Generic.List<Version> Versions { get; } = new global::System.Collections.Generic.List<Version>();

        [global::ProtoBuf.ProtoMember(3, Name = @"state")]
        public State State { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"counterparty")]
        public Counterparty Counterparty { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"delay_period")]
        public ulong DelayPeriod { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IdentifiedConnection : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"versions")]
        public global::System.Collections.Generic.List<Version> Versions { get; } = new global::System.Collections.Generic.List<Version>();

        [global::ProtoBuf.ProtoMember(4, Name = @"state")]
        public State State { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"counterparty")]
        public Counterparty Counterparty { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"delay_period")]
        public ulong DelayPeriod { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Counterparty : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConnectionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"prefix")]
        public MerklePrefix Prefix { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClientPaths : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"paths")]
        public global::System.Collections.Generic.List<string> Paths { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConnectionPaths : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"paths")]
        public global::System.Collections.Generic.List<string> Paths { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Version : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"identifier")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Identifier { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"features")]
        public global::System.Collections.Generic.List<string> Features { get; set; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_expected_time_per_block")]
        public ulong MaxExpectedTimePerBlock { get; set; }

    }
}
