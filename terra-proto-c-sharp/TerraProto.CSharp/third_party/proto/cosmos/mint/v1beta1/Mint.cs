namespace TerraProto.CSharp.third_party.proto.cosmos.mint.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Minter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"inflation")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Inflation { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"annual_provisions")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AnnualProvisions { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"mint_denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MintDenom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"inflation_rate_change")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InflationRateChange { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"inflation_max")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InflationMax { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"inflation_min")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InflationMin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"goal_bonded")]
        [global::System.ComponentModel.DefaultValue("")]
        public string GoalBonded { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"blocks_per_year")]
        public ulong BlocksPerYear { get; set; }

    }
}
