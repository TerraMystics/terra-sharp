namespace Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types
{
    [global::ProtoBuf.ProtoContract()]
    public partial class ConsensusParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block")]
        public BlockParams Block { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"evidence")]
        public EvidenceParams Evidence { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"validator")]
        public ValidatorParams Validator { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"version")]
        public VersionParams Version { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BlockParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_bytes")]
        public long MaxBytes { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"max_gas")]
        public long MaxGas { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"time_iota_ms")]
        public long TimeIotaMs { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EvidenceParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_age_num_blocks")]
        public long MaxAgeNumBlocks { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"max_age_duration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? MaxAgeDuration { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"max_bytes")]
        public long MaxBytes { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pub_key_types")]
        public global::System.Collections.Generic.List<string> PubKeyTypes { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VersionParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"app_version")]
        public ulong AppVersion { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HashedParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_max_bytes")]
        public long BlockMaxBytes { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"block_max_gas")]
        public long BlockMaxGas { get; set; }

    }
}
