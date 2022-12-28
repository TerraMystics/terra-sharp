namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.store.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class StoreKVPair : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"store_key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string StoreKey { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"delete")]
        public bool Delete { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"value")]
        public byte[] Value { get; set; }
    }
}
