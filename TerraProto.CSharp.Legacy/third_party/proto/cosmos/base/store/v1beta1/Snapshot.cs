namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.store.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class SnapshotItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"store")]
        public SnapshotStoreItem Store
        {
            get => __pbn__item.Is(1) ? ((SnapshotStoreItem)__pbn__item.Object) : default;
            set => __pbn__item = new global::ProtoBuf.DiscriminatedUnionObject(1, value);
        }
        public bool ShouldSerializeStore() => __pbn__item.Is(1);
        public void ResetStore() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__item, 1);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__item;

        [global::ProtoBuf.ProtoMember(2, Name = @"iavl")]
        public SnapshotIAVLItem Iavl
        {
            get => __pbn__item.Is(2) ? ((SnapshotIAVLItem)__pbn__item.Object) : default;
            set => __pbn__item = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
        }
        public bool ShouldSerializeIavl() => __pbn__item.Is(2);
        public void ResetIavl() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__item, 2);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SnapshotStoreItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SnapshotIAVLItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        public byte[] Value { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"version")]
        public long Version { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"height")]
        public int Height { get; set; }
    }
}
