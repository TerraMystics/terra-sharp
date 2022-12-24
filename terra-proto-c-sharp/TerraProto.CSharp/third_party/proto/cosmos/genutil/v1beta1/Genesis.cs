namespace TerraProto.CSharp.third_party.proto.cosmos.genutil.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"gen_txs")]
        public global::System.Collections.Generic.List<byte[]> GenTxs { get; } = new global::System.Collections.Generic.List<byte[]>();
    }
}
