using tendermint.types;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Block : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"header")]
        public Header Header { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public Data Data { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"evidence")]
        public EvidenceList Evidence { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"last_commit")]
        public Commit LastCommit { get; set; }
    }
}
