using PROTO = TerraProto.CSharp.third_party.proto.cosmos.distribution.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using TerraSharp.Rest.Tx.Transaction;

namespace TerraSharp.Core.Distrobution.Msgs
{
    public class MsgSetWithdrawAddress : SignerData
    {
        public readonly string delegator_address;
        public readonly string withdraw_address;

        public MsgSetWithdrawAddress(string delegator_address, string withdraw_address)
        {
            this.delegator_address = delegator_address;
            this.withdraw_address = withdraw_address;
        }

        public static MsgSetWithdrawAddress FromAmino(MsgSetWithdrawAddressAminoArgs data)
        {
            return new MsgSetWithdrawAddress(data.Value.Delegator_Address, data.Value.Withdraw_Address);
        }

        public static MsgSetWithdrawAddress FromData(MsgSetWithdrawAddressDataArgs data)
        {
            return new MsgSetWithdrawAddress(data.Delegator_Address, data.Withdraw_Address);
        }

        public static MsgSetWithdrawAddress FromProto(PROTO.MsgSetWithdrawAddress data)
        {
            return new MsgSetWithdrawAddress(data.DelegatorAddress, data.WithdrawAddress);
        }

        public MsgSetWithdrawAddressAminoArgs ToAmino()
        {
            return new MsgSetWithdrawAddressAminoArgs()
            {
                Value = new MsgSetWithdrawAddressValueAminoArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Withdraw_Address = this.withdraw_address,
                }
            };
        }

        public MsgSetWithdrawAddressDataArgs ToData()
        {
            return new MsgSetWithdrawAddressDataArgs()
            {
                Delegator_Address = this.delegator_address,
                Withdraw_Address = this.withdraw_address,
            };
        }
        public PROTO.MsgSetWithdrawAddress ToProtoWithType()
        {
            return new PROTO.MsgSetWithdrawAddress()
            {
                DelegatorAddress = this.delegator_address,
                WithdrawAddress = this.withdraw_address,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MsgSetWithdrawAddressAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgSetWithdrawAddressValueAminoArgs Value { get; set; }
        public MsgSetWithdrawAddressAminoArgs()
        {
            this.Type = DistributionConstants.DISTRIBUTION_MSG_MODIFY_WITHDRAWADDRESS;
        }
    }

    public class MsgSetWithdrawAddressValueAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Withdraw_Address { get; set; }
    }

    public class MsgSetWithdrawAddressDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Delegator_Address { get; set; }
        public string Withdraw_Address { get; set; }

        public MsgSetWithdrawAddressDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_DISTRIBUTION_MSG_SETWITHDRAWADDRESS;
        }
    }
}
