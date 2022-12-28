using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.query.v1beta1;
using Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class QueryChannelRequest : global::ProtoBuf.IExtensible
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
    public partial class QueryChannelResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"channel")]
        public Channel Channel { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryChannelsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryChannelsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"channels")]
        public global::System.Collections.Generic.List<IdentifiedChannel> Channels { get; } = new global::System.Collections.Generic.List<IdentifiedChannel>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionChannelsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Connection { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionChannelsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"channels")]
        public global::System.Collections.Generic.List<IdentifiedChannel> Channels { get; } = new global::System.Collections.Generic.List<IdentifiedChannel>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryChannelClientStateRequest : global::ProtoBuf.IExtensible
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
    public partial class QueryChannelClientStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"identified_client_state")]
        public IdentifiedClientState IdentifiedClientState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryChannelConsensusStateRequest : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"revision_number")]
        public ulong RevisionNumber { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"revision_height")]
        public ulong RevisionHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryChannelConsensusStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketCommitmentRequest : global::ProtoBuf.IExtensible
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

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketCommitmentResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"commitment")]
        public byte[] Commitment { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketCommitmentsRequest : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketCommitmentsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"commitments")]
        public global::System.Collections.Generic.List<PacketState> Commitments { get; } = new global::System.Collections.Generic.List<PacketState>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketReceiptRequest : global::ProtoBuf.IExtensible
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

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketReceiptResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"received")]
        public bool Received { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketAcknowledgementRequest : global::ProtoBuf.IExtensible
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

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketAcknowledgementResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"acknowledgement")]
        public byte[] Acknowledgement { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketAcknowledgementsRequest : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryPacketAcknowledgementsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"acknowledgements")]
        public global::System.Collections.Generic.List<PacketState> Acknowledgements { get; } = new global::System.Collections.Generic.List<PacketState>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUnreceivedPacketsRequest : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"packet_commitment_sequences", IsPacked = true)]
        public ulong[] PacketCommitmentSequences { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUnreceivedPacketsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sequences", IsPacked = true)]
        public ulong[] Sequences { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUnreceivedAcksRequest : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"packet_ack_sequences", IsPacked = true)]
        public ulong[] PacketAckSequences { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUnreceivedAcksResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sequences", IsPacked = true)]
        public ulong[] Sequences { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryNextSequenceReceiveRequest : global::ProtoBuf.IExtensible
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
    public partial class QueryNextSequenceReceiveResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"next_sequence_receive")]
        public ulong NextSequenceReceive { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }
}
