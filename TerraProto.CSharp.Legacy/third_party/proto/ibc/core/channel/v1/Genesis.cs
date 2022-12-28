namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"channels")]
        public global::System.Collections.Generic.List<IdentifiedChannel> Channels { get; } = new global::System.Collections.Generic.List<IdentifiedChannel>();

        [global::ProtoBuf.ProtoMember(2, Name = @"acknowledgements")]
        public global::System.Collections.Generic.List<PacketState> Acknowledgements { get; } = new global::System.Collections.Generic.List<PacketState>();

        [global::ProtoBuf.ProtoMember(3, Name = @"commitments")]
        public global::System.Collections.Generic.List<PacketState> Commitments { get; } = new global::System.Collections.Generic.List<PacketState>();

        [global::ProtoBuf.ProtoMember(4, Name = @"receipts")]
        public global::System.Collections.Generic.List<PacketState> Receipts { get; } = new global::System.Collections.Generic.List<PacketState>();

        [global::ProtoBuf.ProtoMember(5, Name = @"send_sequences")]
        public global::System.Collections.Generic.List<PacketSequence> SendSequences { get; } = new global::System.Collections.Generic.List<PacketSequence>();

        [global::ProtoBuf.ProtoMember(6, Name = @"recv_sequences")]
        public global::System.Collections.Generic.List<PacketSequence> RecvSequences { get; } = new global::System.Collections.Generic.List<PacketSequence>();

        [global::ProtoBuf.ProtoMember(7, Name = @"ack_sequences")]
        public global::System.Collections.Generic.List<PacketSequence> AckSequences { get; } = new global::System.Collections.Generic.List<PacketSequence>();

        [global::ProtoBuf.ProtoMember(8, Name = @"next_channel_sequence")]
        public ulong NextChannelSequence { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PacketSequence : global::ProtoBuf.IExtensible
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

    }
}
