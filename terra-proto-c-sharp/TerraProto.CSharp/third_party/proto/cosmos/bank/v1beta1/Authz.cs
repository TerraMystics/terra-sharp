using cosmos.ibase.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.bank.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class SendAuthorization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"spend_limit")]
        public global::System.Collections.Generic.List<Coin> SpendLimits { get; set; } = new global::System.Collections.Generic.List<Coin>();
    }
}
