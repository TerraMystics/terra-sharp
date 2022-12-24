using TerraProto.CSharp.third_party.proto.ibc.core.client.v1;
using TerraProto.CSharp.third_party.proto.ibc.core.connection.v1;

namespace TerraProto.CSharp.third_party.proto.ibc.core.channel.v1
{
    [global::ProtoBuf.ProtoContract()]
    public enum Order
    {
        [global::ProtoBuf.ProtoEnum(Name = @"ORDER_NONE_UNSPECIFIED")]
        OrderNoneUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ORDER_UNORDERED")]
        OrderUnordered = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"ORDER_ORDERED")]
        OrderOrdered = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Channel : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state")]
        public State State { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ordering")]
        public Order Ordering { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"counterparty")]
        public Counterparty Counterparty { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"connection_hops")]
        public global::System.Collections.Generic.List<string> ConnectionHops { get; set; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(5, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IdentifiedChannel : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state")]
        public State State { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ordering")]
        public Order Ordering { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"counterparty")]
        public Counterparty Counterparty { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"connection_hops")]
        public global::System.Collections.Generic.List<string> ConnectionHops { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(5, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"port_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PortId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"channel_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChannelId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Counterparty : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"port_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PortId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"channel_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChannelId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Packet : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"source_port")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourcePort { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"source_channel")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceChannel { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"destination_port")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DestinationPort { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"destination_channel")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DestinationChannel { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"timeout_height")]
        public Height TimeoutHeight { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"timeout_timestamp")]
        public ulong TimeoutTimestamp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PacketState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"port_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PortId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"channel_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChannelId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Acknowledgement : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(21, Name = @"result")]
        public byte[] Result
        {
            get => __pbn__response.Is(21) ? ((byte[])__pbn__response.Object) : default;
            set => __pbn__response = new global::ProtoBuf.DiscriminatedUnionObject(21, value);
        }
        public bool ShouldSerializeResult() => __pbn__response.Is(21);
        public void ResetResult() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__response, 21);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__response;

        [global::ProtoBuf.ProtoMember(22, Name = @"error")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Error
        {
            get => __pbn__response.Is(22) ? ((string)__pbn__response.Object) : "";
            set => __pbn__response = new global::ProtoBuf.DiscriminatedUnionObject(22, value);
        }
        public bool ShouldSerializeError() => __pbn__response.Is(22);
        public void ResetError() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__response, 22);

    }
}
