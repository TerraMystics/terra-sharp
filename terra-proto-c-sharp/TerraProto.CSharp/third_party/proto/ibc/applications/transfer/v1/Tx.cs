using cosmos.ibase.v1beta1;
using TerraProto.CSharp.third_party.proto.ibc.core.client.v1;

namespace TerraProto.CSharp.third_party.proto.ibc.applications.transfer.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgTransfer : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"source_port")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourcePort { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"source_channel")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceChannel { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"token")]
        public Coin Token { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"receiver")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Receiver { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"timeout_height")]
        public Height TimeoutHeight { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"timeout_timestamp")]
        public ulong TimeoutTimestamp { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgTransferResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
