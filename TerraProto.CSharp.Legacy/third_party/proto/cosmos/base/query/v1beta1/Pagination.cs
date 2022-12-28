namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.query.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class PageRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"offset")]
        public ulong Offset { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"limit")]
        public ulong Limit { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"count_total")]
        public bool CountTotal { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"reverse")]
        public bool Reverse { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PageResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"next_key")]
        public byte[] NextKey { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"total")]
        public ulong Total { get; set; }
    }
}
