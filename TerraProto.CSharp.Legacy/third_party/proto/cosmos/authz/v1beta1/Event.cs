namespace TerraProto.CSharp.third_party.proto.cosmos.authz.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class EventGrant : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"msg_type_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MsgTypeUrl { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EventRevoke : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"msg_type_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MsgTypeUrl { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";
    }
}
