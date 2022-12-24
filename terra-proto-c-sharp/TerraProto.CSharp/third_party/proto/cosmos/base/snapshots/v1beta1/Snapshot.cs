namespace TerraProto.CSharp.third_party.proto.cosmos.ibase.snapshots.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Snapshot : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public ulong Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"format")]
        public uint Format { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"chunks")]
        public uint Chunks { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"hash")]
        public byte[] Hash { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"metadata")]
        public Metadata Metadata { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Metadata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"chunk_hashes")]
        public global::System.Collections.Generic.List<byte[]> ChunkHashes { get; } = new global::System.Collections.Generic.List<byte[]>();

    }
}
