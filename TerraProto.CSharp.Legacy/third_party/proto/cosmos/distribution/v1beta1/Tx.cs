using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.distribution.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSetWithdrawAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"withdraw_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string WithdrawAddress { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSetWithdrawAddressResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgWithdrawDelegatorReward : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgWithdrawDelegatorRewardResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgWithdrawValidatorCommission : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgWithdrawValidatorCommissionResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgFundCommunityPool : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"amount")]
        public global::System.Collections.Generic.List<Coin> Amounts { get; set; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(2, Name = @"depositor")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Depositor { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgFundCommunityPoolResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }
}
