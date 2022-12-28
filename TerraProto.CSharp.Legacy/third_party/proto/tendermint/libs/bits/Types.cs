namespace Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.libs.bits
{
    [global::ProtoBuf.ProtoContract()]
    public partial class BitArray : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"bits")]
        public long Bits { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"elems", IsPacked = true)]
        public ulong[] Elems { get; set; }
    }
}
