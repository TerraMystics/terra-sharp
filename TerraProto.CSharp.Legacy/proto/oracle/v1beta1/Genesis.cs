namespace Terra.Microsoft.ProtoBufs.proto.oracle.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"feeder_delegations")]
        public global::System.Collections.Generic.List<FeederDelegation> FeederDelegations { get; } = new global::System.Collections.Generic.List<FeederDelegation>();

        [global::ProtoBuf.ProtoMember(3, Name = @"exchange_rates")]
        public global::System.Collections.Generic.List<ExchangeRateTuple> ExchangeRates { get; } = new global::System.Collections.Generic.List<ExchangeRateTuple>();

        [global::ProtoBuf.ProtoMember(4, Name = @"miss_counters")]
        public global::System.Collections.Generic.List<MissCounter> MissCounters { get; } = new global::System.Collections.Generic.List<MissCounter>();

        [global::ProtoBuf.ProtoMember(5, Name = @"aggregate_exchange_rate_prevotes")]
        public global::System.Collections.Generic.List<AggregateExchangeRatePrevote> AggregateExchangeRatePrevotes { get; } = new global::System.Collections.Generic.List<AggregateExchangeRatePrevote>();

        [global::ProtoBuf.ProtoMember(6, Name = @"aggregate_exchange_rate_votes")]
        public global::System.Collections.Generic.List<AggregateExchangeRateVote> AggregateExchangeRateVotes { get; } = new global::System.Collections.Generic.List<AggregateExchangeRateVote>();

        [global::ProtoBuf.ProtoMember(7, Name = @"tobin_taxes")]
        public global::System.Collections.Generic.List<TobinTax> TobinTaxes { get; } = new global::System.Collections.Generic.List<TobinTax>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FeederDelegation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"feeder_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FeederAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MissCounter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        public ulong miss_counter { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TobinTax : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Denom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tobin_tax { get; set; } = "";

    }
}
