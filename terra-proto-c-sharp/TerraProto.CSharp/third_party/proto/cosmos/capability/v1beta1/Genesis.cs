namespace TerraProto.CSharp.third_party.proto.cosmos.capability.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisOwners : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"index")]
        public ulong Index { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"index_owners")]
        public CapabilityOwners IndexOwners { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"index")]
        public ulong Index { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"owners")]
        public global::System.Collections.Generic.List<GenesisOwners> Owners { get; } = new global::System.Collections.Generic.List<GenesisOwners>();
    }
}
