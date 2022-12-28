using cosmos.ibase.v1beta1;

namespace Terra.Microsoft.ProtoBufs.proto.treasury.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tax_policy")]
        public PolicyConstraints TaxPolicy { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"reward_policy")]
        public PolicyConstraints RewardPolicy { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"seigniorage_burden_target")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SeigniorageBurdenTarget { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"mining_increment")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MiningIncrement { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"window_short")]
        public ulong WindowShort { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"window_long")]
        public ulong WindowLong { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"window_probation")]
        public ulong WindowProbation { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PolicyConstraints : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"rate_min")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RateMin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"rate_max")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RateMax { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"cap")]
        public Coin Cap { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"change_rate_max")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChangeRateMax { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EpochTaxProceeds : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tax_proceeds")]
        public global::System.Collections.Generic.List<Coin> TaxProceeds { get; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EpochInitialIssuance : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"issuance")]
        public global::System.Collections.Generic.List<Coin> Issuances { get; } = new global::System.Collections.Generic.List<Coin>();

    }
}
