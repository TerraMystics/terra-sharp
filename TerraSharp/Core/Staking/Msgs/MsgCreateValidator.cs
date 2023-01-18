using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Core.Staking.Terra.Microsoft.Client.Core.Staking.Validators.Description;
using Terra.Microsoft.Client.Core.Staking.Terra.Microsoft.Client.Core.Staking.Validators.CommissionsRates;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Keys;

namespace Terra.Microsoft.Client.Core.Staking.Msgs
{
    public class MsgCreateValidator : SignerData
    {
        public readonly ValidatorDescription description;
        public readonly CommissionRates commission;
        public readonly int min_self_delegation;
        public readonly string delegator_address;
        public readonly string validator_address;
        public readonly ValConsPublicKey pubkey;
        public readonly Coin value;

        public MsgCreateValidator(
            ValidatorDescription description,
            CommissionRates commission,
            int min_self_delegation,
            string delegator_address,
            string validator_address,
            ValConsPublicKey pubkey,
            Coin value)
        {
            this.description = description;
            this.commission = commission;
            this.min_self_delegation = min_self_delegation;
            this.delegator_address = delegator_address;
            this.validator_address = validator_address;
            this.pubkey = pubkey;
            this.value = value;
        }

        public static MsgCreateValidator FromAmino(MsgCreateValidatorAminoArgs data)
        {
            return new MsgCreateValidator(
               ValidatorDescription.FromAmino(data.Value.Description),
                CommissionRates.FromAmino(data.Value.Commission),
                int.Parse(data.Value.Min_Self_Delegation),
                data.Value.Delegator_Address,
                data.Value.Validator_Address,
                ValConsPublicKey.FromAmino(data.Value.Pubkey),
                Coin.FromAmino(data.Value.Value));
        }

        public static MsgCreateValidator FromData(MsgCreateValidatorDataArgs data)
        {
            return new MsgCreateValidator(
                 ValidatorDescription.FromData(data.Description),
                  CommissionRates.FromData(data.Commission),
                  int.Parse(data.Min_Self_Delegation),
                  data.Delegator_Address,
                  data.Validator_Address,
                  ValConsPublicKey.FromData(data.Pubkey),
                  Coin.FromData(data.Value));
        }

        public static MsgCreateValidator FromProto(PROTO.MsgCreateValidator data)
        {
            return new MsgCreateValidator(
                  ValidatorDescription.FromProto(data.Description),
                   CommissionRates.FromProto(data.Commission),
                   int.Parse(data.MinSelfDelegation),
                   data.DelegatorAddress,
                   data.ValidatorAddress,
                   ValConsPublicKey.UnPackAny(data.Pubkey),
                   Coin.FromProto(data.Value));
        }

        public MsgCreateValidatorAminoArgs ToAmino()
        {
            return new MsgCreateValidatorAminoArgs()
            {
                Value = new MsgCreateValidatorValueAminoArgs()
                {
                    Commission = this.commission.ToAmino(),
                    Delegator_Address = this.delegator_address,
                    Description = this.description.ToAmino(),
                    Min_Self_Delegation = this.min_self_delegation.ToString(),
                    Pubkey = this.pubkey.ToAmino(),
                    Validator_Address = this.validator_address,
                    Value = this.value.ToAmino()
                }
            };
        }

        public MsgCreateValidatorDataArgs ToData()
        {
            return new MsgCreateValidatorDataArgs()
            {
                Commission = this.commission.ToData(),
                Delegator_Address = this.delegator_address,
                Description = this.description.ToData(),
                Min_Self_Delegation = this.min_self_delegation.ToString(),
                Pubkey = this.pubkey.ToData(),
                Validator_Address = this.validator_address,
                Value = this.value.ToData()
            };
        }

        public PROTO.MsgCreateValidator ToProtoWithType()
        {
            return new PROTO.MsgCreateValidator()
            {
                Commission = this.commission.ToProtoWithType(),
                Description = this.description.ToProtoWithType(),
                MinSelfDelegation = this.min_self_delegation.ToString(),
                Pubkey = this.pubkey.PackAny(),
                Value = this.value.ToProtoWithType(),
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
                TypeUrl = CosmosConstants.COSMOS_STAKING_MSG_CREATE_VALIDATOR,
                Value = this.ToProto()
            };
        }

        public static MsgCreateValidator UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgCreateValidator>(msgAny.Value));
        }
    }

    public class MsgCreateValidatorAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgCreateValidatorValueAminoArgs Value { get; set; }
        public MsgCreateValidatorAminoArgs()
        {
            this.Type = StakingConstants.STAKING_MSG_CREATE_VALIDATOR;
        }
    }

    public class MsgCreateValidatorValueAminoArgs
    {
        public ValidatorDescriptionAminoArgs Description { get; set; }
        public CommissionRatesAminoArgs Commission { get; set; }
        public string Min_Self_Delegation { get; set; }
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public ValConsPublicKeyAminoArgs Pubkey { get; set; }
        public CoinAminoArgs Value { get; set; }
    }

    public class MsgCreateValidatorDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public ValidatorDescriptionDataArgs Description { get; set; }
        public CommissionRatesDataArgs Commission { get; set; }
        public string Min_Self_Delegation { get; set; }
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public ValConsPublicKeyDataArgs Pubkey { get; set; }
        public CoinDataArgs Value { get; set; }

        public MsgCreateValidatorDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_STAKING_MSG_CREATE_VALIDATOR;
        }
    }
}
