using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgCreateValidator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"description")]
        public Description Description { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"commission")]
        public CommissionRates Commission { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"min_self_delegation")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MinSelfDelegation { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"pubkey")]
        public global::Google.Protobuf.WellKnownTypes.Any Pubkey { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"value")]
        public Coin Value { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgCreateValidatorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgEditValidator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"description")]
        public Description Description { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"commission_rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CommissionRate { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"min_self_delegation")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MinSelfDelegation { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgEditValidatorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDelegate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public Coin Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDelegateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgBeginRedelegate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_src_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorSrcAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"validator_dst_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorDstAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"amount")]
        public Coin Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgBeginRedelegateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"completion_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? CompletionTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUndelegate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public Coin Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUndelegateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"completion_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? CompletionTime { get; set; }
    }

    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgCreateValidatorResponse> CreateValidatorAsync(MsgCreateValidator value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgEditValidatorResponse> EditValidatorAsync(MsgEditValidator value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgDelegateResponse> DelegateAsync(MsgDelegate value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgBeginRedelegateResponse> BeginRedelegateAsync(MsgBeginRedelegate value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgUndelegateResponse> UndelegateAsync(MsgUndelegate value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
