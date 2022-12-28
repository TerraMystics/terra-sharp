using Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.lightclients.solomachine.v2
{
    [global::ProtoBuf.ProtoContract()]
    public partial class ClientState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"is_frozen")]
        public bool IsFrozen { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"consensus_state")]
        public ConsensusState ConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"allow_update_after_proposal")]
        public bool AllowUpdateAfterProposal { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConsensusState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        public global::Google.Protobuf.WellKnownTypes.Any PublicKey { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"diversifier")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Diversifier { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"timestamp")]
        public ulong Timestamp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Header : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"timestamp")]
        public ulong Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signature")]
        public byte[] Signature { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"new_public_key")]
        public global::Google.Protobuf.WellKnownTypes.Any NewPublicKey { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"new_diversifier")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NewDiversifier { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Misbehaviour : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signature_one")]
        public SignatureAndData SignatureOne { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"signature_two")]
        public SignatureAndData SignatureTwo { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignatureAndData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data_type")]
        public DataType DataType { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"timestamp")]
        public ulong Timestamp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TimestampedSignatureData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature_data")]
        public byte[] SignatureData { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"timestamp")]
        public ulong Timestamp { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignBytes : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"timestamp")]
        public ulong Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"diversifier")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Diversifier { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"data_type")]
        public DataType DataType { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HeaderData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"new_pub_key")]
        public global::Google.Protobuf.WellKnownTypes.Any NewPubKey { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"new_diversifier")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NewDiversifier { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClientStateData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConsensusStateData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConnectionStateData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"connection")]
        public ConnectionEnd Connection { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ChannelStateData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"channel")]
        public Channel Channel { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PacketCommitmentData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"commitment")]
        public byte[] Commitment { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PacketAcknowledgementData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"acknowledgement")]
        public byte[] Acknowledgement { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PacketReceiptAbsenceData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NextSequenceRecvData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        public byte[] Path { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"next_seq_recv")]
        public ulong NextSeqRecv { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum DataType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_UNINITIALIZED_UNSPECIFIED")]
        DataTypeUninitializedUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_CLIENT_STATE")]
        DataTypeClientState = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_CONSENSUS_STATE")]
        DataTypeConsensusState = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_CONNECTION_STATE")]
        DataTypeConnectionState = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_CHANNEL_STATE")]
        DataTypeChannelState = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_PACKET_COMMITMENT")]
        DataTypePacketCommitment = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_PACKET_ACKNOWLEDGEMENT")]
        DataTypePacketAcknowledgement = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_PACKET_RECEIPT_ABSENCE")]
        DataTypePacketReceiptAbsence = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_NEXT_SEQUENCE_RECV")]
        DataTypeNextSequenceRecv = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"DATA_TYPE_HEADER")]
        DataTypeHeader = 9,
    }
}
