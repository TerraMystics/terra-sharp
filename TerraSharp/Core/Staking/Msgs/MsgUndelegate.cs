using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Staking.Msgs
{
    public class MsgUndelegate : SignerData
    {
        public readonly string delegator_address;
        public readonly string validator_address;
        public readonly Coin amount;

        public MsgUndelegate(
            string delegator_address,
            string validator_address,
            Coin amount)
        {
            this.delegator_address = delegator_address;
            this.validator_address = validator_address;
            this.amount = amount;
        }

        public static MsgUndelegate FromAmino(MsgUndelegateAminoArgs data)
        {
            return new MsgUndelegate(
                data.Value.Delegator_Address,
                data.Value.Validator_Address,
                Coin.FromAmino(data.Value.Amount));
        }

        public static MsgUndelegate FromData(MsgUndelegateDataArgs data)
        {
            return new MsgUndelegate(
                  data.Delegator_Address,
                  data.Validator_Address,
                  Coin.FromData(data.Amount));
        }

        public static MsgUndelegate FromProto(PROTO.MsgUndelegate data)
        {
            return new MsgUndelegate(
                   data.DelegatorAddress,
                   data.ValidatorAddress,
                   Coin.FromProto(data.Amount));
        }

        public MsgUndelegateAminoArgs ToAmino()
        {
            return new MsgUndelegateAminoArgs()
            {
                Value = new MsgUndelegateValueAminoArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Address = this.validator_address,
                    Amount = this.amount.ToAmino()
                }
            };
        }

        public MsgUndelegateDataArgs ToData()
        {
            return new MsgUndelegateDataArgs()
            {
                Delegator_Address = this.delegator_address,
                Validator_Address = this.validator_address,
                Amount = this.amount.ToData()
            };
        }

        public PROTO.MsgUndelegate ToProtoWithType()
        {
            return new PROTO.MsgUndelegate()
            {
                Amount = this.amount.ToProtoWithType(),
                DelegatorAddress = this.delegator_address,
                ValidatorAddress = this.validator_address
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
                TypeUrl = CosmosConstants.COSMOS_STAKING_MSG_UNDELEGATE,
                Value = this.ToProto()
            };
        }

        public static MsgUndelegate UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgUndelegate>(msgAny.Value));
        }
    }

    public class MsgUndelegateAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgUndelegateValueAminoArgs Value { get; set; }
        public MsgUndelegateAminoArgs()
        {
            this.Type = StakingConstants.STAKING_MSG_UNDELEGATE;
        }
    }

    public class MsgUndelegateValueAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public CoinAminoArgs Amount { get; set; }
    }

    public class MsgUndelegateDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public CoinDataArgs Amount { get; set; }

        public MsgUndelegateDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_STAKING_MSG_UNDELEGATE;
        }
    }
}
