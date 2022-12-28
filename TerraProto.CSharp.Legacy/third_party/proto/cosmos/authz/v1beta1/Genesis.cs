namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.authz.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"authorization")]
        public global::System.Collections.Generic.List<GrantAuthorization> Authorizations { get; } = new global::System.Collections.Generic.List<GrantAuthorization>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GrantAuthorization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"authorization")]
        public global::Google.Protobuf.WellKnownTypes.Any Authorization { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"expiration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Expiration { get; set; }
    }
}
