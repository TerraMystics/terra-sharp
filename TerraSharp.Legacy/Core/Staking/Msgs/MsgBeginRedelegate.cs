using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Staking.Msgs
{
    public class MsgBeginRedelegate : SignerData
    {
        public readonly string delegator_address;
        public readonly string validator_src_address;
        public readonly string validator_dst_address;
        public readonly Coin amount;

        public MsgBeginRedelegate(
            string delegator_address,
            string validator_src_address,
            string validator_dst_address,
            Coin amount)
        {
            this.delegator_address = delegator_address;
            this.validator_src_address = validator_src_address;
            this.validator_dst_address = validator_dst_address;
            this.amount = amount;
        }

        public static MsgBeginRedelegate FromAmino(MsgBeginRedelegateAminoArgs data)
        {
            return new MsgBeginRedelegate(
                data.Value.Delegator_Address,
                data.Value.Validator_src_address,
                data.Value.Validator_dst_address,
                Coin.FromAmino(data.Value.Amount));
        }

        public static MsgBeginRedelegate FromData(MsgBeginRedelegateDataArgs data)
        {
            return new MsgBeginRedelegate(
                data.Delegator_Address,
                data.Validator_src_address,
                data.Validator_dst_address,
                Coin.FromData(data.Amount));
        }

        public static MsgBeginRedelegate FromProto(PROTO.MsgBeginRedelegate data)
        {
            return new MsgBeginRedelegate(
                data.DelegatorAddress,
                data.ValidatorSrcAddress,
                data.ValidatorDstAddress,
                Coin.FromProto(data.Amount));
        }

        public MsgBeginRedelegateAminoArgs ToAmino()
        {
            return new MsgBeginRedelegateAminoArgs()
            {
                Value = new MsgBeginRedelegateValueAminoArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Amount = this.amount.ToAmino(),
                    Validator_dst_address = this.validator_dst_address,
                    Validator_src_address = this.validator_src_address
                }
            };
        }

        public MsgBeginRedelegateDataArgs ToData()
        {
            return new MsgBeginRedelegateDataArgs()
            {
                Delegator_Address = this.delegator_address,
                Amount = this.amount.ToData(),
                Validator_dst_address = this.validator_dst_address,
                Validator_src_address = this.validator_src_address
            };
        }

        public PROTO.MsgBeginRedelegate ToProtoWithType()
        {
            return new PROTO.MsgBeginRedelegate()
            {
                Amount = this.amount.ToProtoWithType(),
                DelegatorAddress = this.delegator_address,
                ValidatorDstAddress = this.validator_dst_address,
                ValidatorSrcAddress = this.validator_src_address
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_STAKING_MSG_BEGIN_REDELEGATE,
                Value = this.ToProto()
            };
        }

        public static MsgBeginRedelegate UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgBeginRedelegate>(msgAny.Value));
        }
    }

    public class MsgBeginRedelegateAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgBeginRedelegateValueAminoArgs Value { get; set; }
        public MsgBeginRedelegateAminoArgs()
        {
            this.Type = StakingConstants.STAKING_MSG_BEGIN_REDELEGATE;
        }
    }

    public class MsgBeginRedelegateValueAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_src_address { get; set; }
        public string Validator_dst_address { get; set; }
        public CoinAminoArgs Amount { get; set; }
    }

    public class MsgBeginRedelegateDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Delegator_Address { get; set; }
        public string Validator_src_address { get; set; }
        public string Validator_dst_address { get; set; }
        public CoinDataArgs Amount { get; set; }

        public MsgBeginRedelegateDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_STAKING_MSG_BEGIN_REDELEGATE;
        }
    }
}
