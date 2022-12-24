namespace TerraProto.CSharp.third_party.proto.cosmos.slashing.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class ValidatorSigningInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"start_height")]
        public long StartHeight { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"index_offset")]
        public long IndexOffset { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"jailed_until", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? JailedUntil { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"tombstoned")]
        public bool Tombstoned { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"missed_blocks_counter")]
        public long MissedBlocksCounter { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signed_blocks_window")]
        public long SignedBlocksWindow { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"min_signed_per_window")]
        public byte[] MinSignedPerWindow { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"downtime_jail_duration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? DowntimeJailDuration { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"slash_fraction_double_sign")]
        public byte[] SlashFractionDoubleSign { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"slash_fraction_downtime")]
        public byte[] SlashFractionDowntime { get; set; }
    }
}
