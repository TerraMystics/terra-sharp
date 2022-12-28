namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgCreateClient : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgCreateClientResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUpdateClient : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"header")]
        public global::Google.Protobuf.WellKnownTypes.Any Header { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUpdateClientResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUpgradeClient : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_upgrade_client")]
        public byte[] ProofUpgradeClient { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"proof_upgrade_consensus_state")]
        public byte[] ProofUpgradeConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUpgradeClientResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSubmitMisbehaviour : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"misbehaviour")]
        public global::Google.Protobuf.WellKnownTypes.Any Misbehaviour { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signer { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSubmitMisbehaviourResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
