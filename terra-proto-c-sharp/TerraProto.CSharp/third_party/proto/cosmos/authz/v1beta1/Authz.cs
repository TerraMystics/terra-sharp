namespace TerraProto.CSharp.third_party.proto.cosmos.authz.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenericAuthorization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"msg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Msg { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Grant : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"authorization")]
        public global::Google.Protobuf.WellKnownTypes.Any Authorization { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"expiration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Expiration { get; set; }
    }
}
