namespace Terra.Microsoft.ProtoBufs.proto.oracle.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgAggregateExchangeRatePrevote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hash")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Hash { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"feeder")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Feeder { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"validator")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Validator { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgAggregateExchangeRatePrevoteResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgAggregateExchangeRateVote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"salt")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Salt { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"exchange_rates")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExchangeRates { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"feeder")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Feeder { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"validator")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Validator { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgAggregateExchangeRateVoteResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDelegateFeedConsent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"operator")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Operator { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"delegate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Delegate { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDelegateFeedConsentResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgAggregateExchangeRatePrevoteResponse> AggregateExchangeRatePrevoteAsync(MsgAggregateExchangeRatePrevote value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgAggregateExchangeRateVoteResponse> AggregateExchangeRateVoteAsync(MsgAggregateExchangeRateVote value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgDelegateFeedConsentResponse> DelegateFeedConsentAsync(MsgDelegateFeedConsent value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
