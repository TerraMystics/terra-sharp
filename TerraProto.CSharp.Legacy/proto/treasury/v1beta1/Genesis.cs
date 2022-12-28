
using cosmos.ibase.v1beta1;

namespace Terra.Microsoft.ProtoBufs.proto.treasury.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tax_rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TaxRate { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"reward_weight")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardWeight { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"tax_caps")]
        public global::System.Collections.Generic.List<TaxCap> TaxCaps { get; } = new global::System.Collections.Generic.List<TaxCap>();

        [global::ProtoBuf.ProtoMember(5, Name = @"tax_proceeds")]
        public global::System.Collections.Generic.List<Coin> TaxProceeds { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(6, Name = @"epoch_initial_issuance")]
        public global::System.Collections.Generic.List<Coin> EpochInitialIssuances { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(7, Name = @"epoch_states")]
        public global::System.Collections.Generic.List<EpochState> EpochStates { get; } = new global::System.Collections.Generic.List<EpochState>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TaxCap : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Denom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tax_cap { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EpochState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"epoch")]
        public ulong Epoch { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tax_reward")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TaxReward { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"seigniorage_reward")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SeigniorageReward { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"total_staked_luna")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TotalStakedLuna { get; set; } = "";
    }
}
