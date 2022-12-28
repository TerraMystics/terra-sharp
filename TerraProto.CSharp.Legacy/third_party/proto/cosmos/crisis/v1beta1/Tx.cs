namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crisis.v1beta1
{
    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgVerifyInvariantResponse> VerifyInvariantAsync(MsgVerifyInvariant value, global::ProtoBuf.Grpc.CallContext context = default);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgVerifyInvariant : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"invariant_module_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InvariantModuleName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"invariant_route")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InvariantRoute { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgVerifyInvariantResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
