using cosmos.ibase.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.bank.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"from_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FromAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"to_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ToAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public global::System.Collections.Generic.List<Coin> Amounts { get; set; } = new global::System.Collections.Generic.List<Coin>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSendResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgMultiSend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"inputs")]
        public global::System.Collections.Generic.List<Input> Inputs { get; set; } = new global::System.Collections.Generic.List<Input>();

        [global::ProtoBuf.ProtoMember(2, Name = @"outputs")]
        public global::System.Collections.Generic.List<Output> Outputs { get; set; } = new global::System.Collections.Generic.List<Output>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgMultiSendResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
