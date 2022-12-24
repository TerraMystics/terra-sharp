using TerraProto.CSharp.third_party.proto.ibc.core.client.v1;

namespace TerraProto.CSharp.third_party.proto.ibc.lightclients.localhost.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class ClientState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"chain_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChainId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"height")]
        public Height Height { get; set; }

    }
}
