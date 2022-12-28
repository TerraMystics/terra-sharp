namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.slashing.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUnjail : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddr { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUnjailResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgUnjailResponse> UnjailAsync(MsgUnjail value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
