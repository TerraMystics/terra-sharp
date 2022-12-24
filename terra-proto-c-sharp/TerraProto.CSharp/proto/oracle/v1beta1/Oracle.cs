namespace TerraProto.CSharp.proto.oracle.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"vote_period")]
        public ulong VotePeriod { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"vote_threshold")]
        [global::System.ComponentModel.DefaultValue("")]
        public string VoteThreshold { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"reward_band")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardBand { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"reward_distribution_window")]
        public ulong RewardDistributionWindow { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"whitelist")]
        public global::System.Collections.Generic.List<Denom> Whitelists { get; } = new global::System.Collections.Generic.List<Denom>();

        [global::ProtoBuf.ProtoMember(6, Name = @"slash_fraction")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SlashFraction { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"slash_window")]
        public ulong SlashWindow { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"min_valid_per_window")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MinValidPerWindow { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Denom : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"tobin_tax")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TobinTax { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AggregateExchangeRatePrevote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hash")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Hash { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"submit_block")]
        public ulong SubmitBlock { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AggregateExchangeRateVote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"exchange_rate_tuples")]
        public global::System.Collections.Generic.List<ExchangeRateTuple> ExchangeRateTuples { get; set; } = new global::System.Collections.Generic.List<ExchangeRateTuple>();

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExchangeRateTuple : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Denom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"exchange_rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExchangeRate { get; set; } = "";

    }
}
