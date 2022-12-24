using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Staking.TerraSharp.Core.Staking.Validators.Description;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Staking.Msgs
{
    public class MsgEditValidator : SignerData
    {
        public readonly ValidatorDescription description;
        public readonly decimal? commission_rate;
        public readonly int min_self_delegation;
        public readonly string validator_address;

        public MsgEditValidator(
            ValidatorDescription description,
            decimal? commission_rate,
            int min_self_delegation,
            string validator_address)
        {
            this.description = description;
            this.commission_rate = commission_rate;
            this.min_self_delegation = min_self_delegation;
            this.validator_address = validator_address;
        }

        public static MsgEditValidator FromAmino(MsgEditValidatorAminoArgs data)
        {
            return new MsgEditValidator(
                ValidatorDescription.FromAmino(data.Value.Description),
                decimal.Parse(data.Value.Commission_Rate),
                int.Parse(data.Value.Min_Self_Delegation),
                data.Value.Validator_Address);
        }

        public static MsgEditValidator FromData(MsgEditValidatorDataArgs data)
        {
            return new MsgEditValidator(
                ValidatorDescription.FromData(data.Description),
                decimal.Parse(data.Commission_Rate),
                int.Parse(data.Min_Self_Delegation),
                data.Validator_Address);
        }

        public static MsgEditValidator FromProto(PROTO.MsgEditValidator data)
        {
            return new MsgEditValidator(
               ValidatorDescription.FromProto(data.Description),
               decimal.Parse(data.CommissionRate),
               int.Parse(data.MinSelfDelegation),
               data.ValidatorAddress);
        }

        public MsgEditValidatorAminoArgs ToAmino()
        {
            return new MsgEditValidatorAminoArgs()
            {
                Value = new MsgEditValidatorValueAminoArgs()
                {
                    Commission_Rate = this.commission_rate.ToString(),
                    Description = this.description.ToAmino(),
                    Min_Self_Delegation = this.min_self_delegation.ToString(),
                    Validator_Address = this.validator_address,
                }
            };
        }

        public MsgEditValidatorDataArgs ToData()
        {
            return new MsgEditValidatorDataArgs()
            {
                Commission_Rate = this.commission_rate.ToString(),
                Description = this.description.ToData(),
                Min_Self_Delegation = this.min_self_delegation.ToString(),
                Validator_Address = this.validator_address,
            };
        }

        public PROTO.MsgEditValidator ToProtoWithType()
        {
            return new PROTO.MsgEditValidator()
            {
                CommissionRate = this.commission_rate.ToString(),
                Description = this.description.ToProtoWithType(),
                MinSelfDelegation = this.min_self_delegation.ToString(),
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
                TypeUrl = CosmosConstants.COSMOS_STAKING_MSG_EDIT_VALIDATOR,
                Value = this.ToProto()
            };
        }

        public static MsgEditValidator UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgEditValidator>(msgAny.Value));
        }
    }

    public class MsgEditValidatorAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgEditValidatorValueAminoArgs Value { get; set; }
        public MsgEditValidatorAminoArgs()
        {
            this.Type = StakingConstants.STAKING_MSG_EDIT_VALIDATOR;
        }
    }

    public class MsgEditValidatorValueAminoArgs
    {
        public ValidatorDescriptionAminoArgs Description { get; set; }
        public string Min_Self_Delegation { get; set; }
        public string Commission_Rate { get; set; }
        public string Validator_Address { get; set; }
    }

    public class MsgEditValidatorDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public ValidatorDescriptionDataArgs Description { get; set; }
        public string Min_Self_Delegation { get; set; }
        public string Commission_Rate { get; set; }
        public string Validator_Address { get; set; }

        public MsgEditValidatorDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_STAKING_MSG_EDIT_VALIDATOR;
        }
    }
}
