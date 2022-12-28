using Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenInit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"counterparty")]
        public Counterparty Counterparty { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"version")]
        public Version Version { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"delay_period")]
        public ulong DelayPeriod { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenInitResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenTry : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"previous_connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PreviousConnectionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"counterparty")]
        public Counterparty Counterparty { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"delay_period")]
        public ulong DelayPeriod { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"counterparty_versions")]
        public global::System.Collections.Generic.List<Version> CounterpartyVersions { get; set; } = new global::System.Collections.Generic.List<Version>();

        [global::ProtoBuf.ProtoMember(7, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"proof_init")]
        public byte[] ProofInit { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"proof_client")]
        public byte[] ProofClient { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"proof_consensus")]
        public byte[] ProofConsensus { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"consensus_height")]
        public Height ConsensusHeight { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenTryResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConnectionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"counterparty_connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CounterpartyConnectionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"version")]
        public Version Version { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"proof_try")]
        public byte[] ProofTry { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"proof_client")]
        public byte[] ProofClient { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"proof_consensus")]
        public byte[] ProofConsensus { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"consensus_height")]
        public Height ConsensusHeight { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenAckResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenConfirm : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConnectionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"proof_ack")]
        public byte[] ProofAck { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgConnectionOpenConfirmResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
