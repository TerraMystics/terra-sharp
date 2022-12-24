namespace TerraProto.CSharp.third_party.proto.cosmos.ibase.kv.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Pairs : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Pair> pairs { get; } = new global::System.Collections.Generic.List<Pair>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Pair : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        public byte[] Value { get; set; }
    }
}
