namespace TerraProto.CSharp.third_party.proto.cosmos.authz.v1beta1
{
    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgGrantResponse> GrantAsync(MsgGrant value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgExecResponse> ExecAsync(MsgExec value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgRevokeResponse> RevokeAsync(MsgRevoke value, global::ProtoBuf.Grpc.CallContext context = default);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgRevokeResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgGrant : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"grant")]
        public Grant Grant { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgExecResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"results")]
        public global::System.Collections.Generic.List<byte[]> Results { get; } = new global::System.Collections.Generic.List<byte[]>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgExec : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"msgs")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> Msgs { get; set; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgGrantResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgRevoke : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"msg_type_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MsgTypeUrl { get; set; } = "";
    }
}
