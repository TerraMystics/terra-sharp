using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Staking.Msgs
{
    public class MsgDelegate : SignerData
    {
        public readonly string delegator_address;
        public readonly string validator_address;
        public readonly Coin amount;

        public MsgDelegate(
            string delegator_address,
            string validator_address,
            Coin amount)
        {
            this.delegator_address = delegator_address;
            this.validator_address = validator_address;
            this.amount = amount;
        }

        public static MsgDelegate FromAmino(MsgDelegateAminoArgs data)
        {
            return new MsgDelegate(
                data.Value.Delegator_Address,
                data.Value.Validator_Address,
                Coin.FromAmino(data.Value.Amount));
        }

        public static MsgDelegate FromData(MsgDelegateDataArgs data)
        {
            return new MsgDelegate(
                  data.Delegator_Address,
                  data.Validator_Address,
                  Coin.FromData(data.Amount));
        }

        public static MsgDelegate FromProto(PROTO.MsgDelegate data)
        {
            return new MsgDelegate(
                   data.DelegatorAddress,
                   data.ValidatorAddress,
                   Coin.FromProto(data.Amount));
        }

        public MsgDelegateAminoArgs ToAmino()
        {
            return new MsgDelegateAminoArgs()
            {
                Value = new MsgDelegateValueAminoArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Address = this.validator_address,
                    Amount = this.amount.ToAmino()
                }
            };
        }

        public MsgDelegateDataArgs ToData()
        {
            return new MsgDelegateDataArgs()
            {
                Delegator_Address = this.delegator_address,
                Validator_Address = this.validator_address,
                Amount = this.amount.ToData()
            };
        }

        public PROTO.MsgDelegate ToProtoWithType()
        {
            return new PROTO.MsgDelegate()
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
                TypeUrl = CosmosConstants.COSMOS_STAKING_MSG_DELEGATE,
                Value = this.ToProto()
            };
        }

        public static MsgDelegate UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgDelegate>(msgAny.Value));
        }
    }

    public class MsgDelegateAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgDelegateValueAminoArgs Value { get; set; }
        public MsgDelegateAminoArgs()
        {
            this.Type = StakingConstants.STAKING_MSG_DELEGATE;
        }
    }

    public class MsgDelegateValueAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public CoinAminoArgs Amount { get; set; }
    }

    public class MsgDelegateDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public CoinDataArgs Amount { get; set; }

        public MsgDelegateDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_STAKING_MSG_DELEGATE;
        }
    }
}
