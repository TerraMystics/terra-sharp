namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.store.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class CommitInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version")]
        public long Version { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"store_infos")]
        public global::System.Collections.Generic.List<StoreInfo> StoreInfos { get; } = new global::System.Collections.Generic.List<StoreInfo>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StoreInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"commit_id")]
        public CommitID CommitId { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CommitID : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version")]
        public long Version { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"hash")]
        public byte[] Hash { get; set; }
    }
}
