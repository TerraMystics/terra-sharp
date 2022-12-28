using Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenInit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"port_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PortId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"channel")]
        public Channel Channel { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenInitResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenTry : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"port_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PortId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"previous_channel_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PreviousChannelId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"channel")]
        public Channel Channel { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"counterparty_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CounterpartyVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"proof_init")]
        public byte[] ProofInit { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenTryResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenAck : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"counterparty_channel_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CounterpartyChannelId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"counterparty_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CounterpartyVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"proof_try")]
        public byte[] ProofTry { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenAckResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenConfirm : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_ack")]
        public byte[] ProofAck { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelOpenConfirmResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelCloseInit : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelCloseInitResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelCloseConfirm : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_init")]
        public byte[] ProofInit { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgChannelCloseConfirmResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgRecvPacket : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"packet")]
        public Packet Packet { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof_commitment")]
        public byte[] ProofCommitment { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgRecvPacketResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgTimeout : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"packet")]
        public Packet Packet { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof_unreceived")]
        public byte[] ProofUnreceived { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"next_sequence_recv")]
        public ulong NextSequenceRecv { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgTimeoutResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgTimeoutOnClose : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"packet")]
        public Packet Packet { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof_unreceived")]
        public byte[] ProofUnreceived { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_close")]
        public byte[] ProofClose { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"next_sequence_recv")]
        public ulong NextSequenceRecv { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgTimeoutOnCloseResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgAcknowledgement : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"packet")]
        public Packet Packet { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"acknowledgement")]
        public byte[] Acknowledgement { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_acked")]
        public byte[] ProofAcked { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgAcknowledgementResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }
}
