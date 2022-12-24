namespace TerraProto.CSharp.third_party.proto.ibc.core.client.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"clients")]
        public global::System.Collections.Generic.List<IdentifiedClientState> Clients { get; } = new global::System.Collections.Generic.List<IdentifiedClientState>();

        [global::ProtoBuf.ProtoMember(2, Name = @"clients_consensus")]
        public global::System.Collections.Generic.List<ClientConsensusStates> ClientsConsensus { get; } = new global::System.Collections.Generic.List<ClientConsensusStates>();

        [global::ProtoBuf.ProtoMember(3, Name = @"clients_metadata")]
        public global::System.Collections.Generic.List<IdentifiedGenesisMetadata> ClientsMetadatas { get; } = new global::System.Collections.Generic.List<IdentifiedGenesisMetadata>();

        [global::ProtoBuf.ProtoMember(4, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"create_localhost")]
        public bool CreateLocalhost { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"next_client_sequence")]
        public ulong NextClientSequence { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisMetadata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        public byte[] Value { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IdentifiedGenesisMetadata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"client_metadata")]
        public global::System.Collections.Generic.List<GenesisMetadata> ClientMetadatas { get; } = new global::System.Collections.Generic.List<GenesisMetadata>();
    }
}
