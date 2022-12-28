using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.oracle.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Oracle.Msgs
{
    public class MsgAggregateExchangeRatePrevote : SignerData
    {
        public readonly string hash;
        public readonly string feeder;
        public readonly string validator;

        public MsgAggregateExchangeRatePrevote(
            string hash,
            string feeder,
            string validator)
        {
            this.hash = hash;
            this.feeder = feeder;
            this.validator = validator;
        }

        public static MsgAggregateExchangeRatePrevote FromAmino(MsgAggregateExchangeRatePrevoteAminoArgs data)
        {
            return new MsgAggregateExchangeRatePrevote(data.Value.Hash, data.Value.Feeder, data.Value.Validator);
        }

        public static MsgAggregateExchangeRatePrevote FromData(MsgAggregateExchangeRatePrevoteDataArgs data)
        {
            return new MsgAggregateExchangeRatePrevote(data.Hash, data.Feeder, data.Validator);
        }

        public static MsgAggregateExchangeRatePrevote FromProto(PROTO.MsgAggregateExchangeRatePrevote data)
        {
            return new MsgAggregateExchangeRatePrevote(data.Hash, data.Feeder, data.Validator);
        }

        public MsgAggregateExchangeRatePrevoteAminoArgs ToAmino()
        {
            return new MsgAggregateExchangeRatePrevoteAminoArgs()
            {
                Value = new MsgAggregateExchangeRatePrevoteValueAminoArgs()
                {
                    Hash = this.hash,
                    Feeder = this.feeder,
                    Validator = this.validator
                }
            };
        }

        public MsgAggregateExchangeRatePrevoteDataArgs ToData()
        {
            return new MsgAggregateExchangeRatePrevoteDataArgs()
            {
                Hash = this.hash,
                Feeder = this.feeder,
                Validator = this.validator
            };
        }

        public PROTO.MsgAggregateExchangeRatePrevote ToProtoWithType()
        {
            return new PROTO.MsgAggregateExchangeRatePrevote()
            {
                Feeder = this.feeder,
                Validator = this.validator,
                Hash = this.hash
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
                TypeUrl = TerraConstants.TERRA_ORACLE_EXCHANGE_RATE_PREVOTE,
                Value = this.ToProto()
            };
        }

        public static MsgAggregateExchangeRatePrevote UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgAggregateExchangeRatePrevote>(msgAny.Value));

        }
    }

    public class MsgAggregateExchangeRatePrevoteAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgAggregateExchangeRatePrevoteValueAminoArgs Value { get; set; }
        public MsgAggregateExchangeRatePrevoteAminoArgs()
        {
            this.Type = OracleConstants.ORACLE_MSG_AGGREGATE_EXCHANGE_RATE_PREVOTE;
        }
    }

    public class MsgAggregateExchangeRatePrevoteValueAminoArgs
    {
        public string Hash { get; set; }
        public string Feeder { get; set; }
        public string Validator { get; set; }
    }

    public class MsgAggregateExchangeRatePrevoteDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Hash { get; set; }
        public string Feeder { get; set; }
        public string Validator { get; set; }

        public MsgAggregateExchangeRatePrevoteDataArgs()
        {
            this.Type = TerraConstants.TERRA_ORACLE_EXCHANGE_RATE_PREVOTE;
        }
    }
}
