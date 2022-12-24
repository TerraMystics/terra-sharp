using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.distribution.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using TerraSharp.Rest.Tx.Transaction;

namespace TerraSharp.Core.Distrobution.Msgs
{
    public class MsgWithdrawValidatorCommission : SignerData
    {
        public readonly string validator_address;

        public MsgWithdrawValidatorCommission(string validator_address)
        {
            this.validator_address = validator_address;
        }

        public static MsgWithdrawValidatorCommission FromAmino(MsgWithdrawValidatorCommissionAminoArgs data)
        {
            return new MsgWithdrawValidatorCommission(data.Value.Validator_Address);
        }

        public static MsgWithdrawValidatorCommission FromData(MsgWithdrawValidatorCommissionDataArgs data)
        {
            return new MsgWithdrawValidatorCommission(data.Validator_Address);
        }

        public static MsgWithdrawValidatorCommission FromProto(PROTO.MsgWithdrawValidatorCommission data)
        {
            return new MsgWithdrawValidatorCommission(data.ValidatorAddress);
        }

        public MsgWithdrawValidatorCommissionAminoArgs ToAmino()
        {
            return new MsgWithdrawValidatorCommissionAminoArgs()
            {
                Value = new MsgWithdrawValidatorCommissionValueAminoArgs()
                {
                    Validator_Address = this.validator_address,
                }
            };
        }

        public MsgWithdrawValidatorCommissionDataArgs ToData()
        {
            return new MsgWithdrawValidatorCommissionDataArgs()
            {
                Validator_Address = this.validator_address,
            };
        }

        public PROTO.MsgWithdrawValidatorCommission ToProtoWithType()
        {
            return new PROTO.MsgWithdrawValidatorCommission()
            {
                ValidatorAddress = this.validator_address,
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
                TypeUrl = CosmosConstants.COSMOS_DISTRIBUTION_MSG_WITHDRAW_VALIDATOR_COMMISSION,
                Value = this.ToProto()
            };
        }

        public static MsgWithdrawValidatorCommission UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgWithdrawValidatorCommission>(msgAny.Value));
        }
    }

    public class MsgWithdrawValidatorCommissionAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgWithdrawValidatorCommissionValueAminoArgs Value { get; set; }
        public MsgWithdrawValidatorCommissionAminoArgs()
        {
            this.Type = DistributionConstants.DISTRIBUTION_MSG_WITHDRAW_VALIDATOR_COMMISSION;
        }
    }

    public class MsgWithdrawValidatorCommissionValueAminoArgs
    {
        public string Validator_Address { get; set; }
    }

    public class MsgWithdrawValidatorCommissionDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Validator_Address { get; set; }

        public MsgWithdrawValidatorCommissionDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_DISTRIBUTION_MSG_WITHDRAW_VALIDATOR_COMMISSION;
        }
    }
}
