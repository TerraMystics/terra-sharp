using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.proto.oracle.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Oracle.Msgs
{
    public class MsgAggregateExchangeRateVote : SignerData
    {
        public readonly string salt;
        public readonly string feeder;
        public readonly string validator;
        public readonly string exchange_rates;

        public MsgAggregateExchangeRateVote(
            string salt,
            string feeder,
            string validator,
            string exchange_rates)
        {
            this.exchange_rates = exchange_rates;
            this.salt = salt;
            this.feeder = feeder;
            this.validator = validator;
        }

        public static MsgAggregateExchangeRateVote FromAmino(MsgAggregateExchangeRateVoteAminoArgs data)
        {
            return new MsgAggregateExchangeRateVote(data.Value.Salt, data.Value.Feeder, data.Value.Validator, data.Value.Exchange_Rates);
        }

        public static MsgAggregateExchangeRateVote FromData(MsgAggregateExchangeRateVoteDataArgs data)
        {
            return new MsgAggregateExchangeRateVote(data.Salt, data.Feeder, data.Validator, data.Exchange_Rates);
        }

        public static MsgAggregateExchangeRateVote FromProto(PROTO.MsgAggregateExchangeRateVote data)
        {
            return new MsgAggregateExchangeRateVote(data.Salt, data.Feeder, data.Validator, data.ExchangeRates);
        }

        public MsgAggregateExchangeRateVoteAminoArgs ToAmino()
        {
            return new MsgAggregateExchangeRateVoteAminoArgs()
            {
                Value = new MsgAggregateExchangeRateVoteValueAminoArgs()
                {
                    Salt = this.salt,
                    Feeder = this.feeder,
                    Validator = this.validator,
                    Exchange_Rates = this.exchange_rates
                }
            };
        }

        public MsgAggregateExchangeRateVoteDataArgs ToData()
        {
            return new MsgAggregateExchangeRateVoteDataArgs()
            {
                Salt = this.salt,
                Feeder = this.feeder,
                Validator = this.validator,
                Exchange_Rates = this.exchange_rates
            };
        }

        public PROTO.MsgAggregateExchangeRateVote ToProtoWithType()
        {
            return new PROTO.MsgAggregateExchangeRateVote()
            {
                ExchangeRates = this.exchange_rates,
                Feeder = this.feeder,
                Salt = this.salt,
                Validator = this.validator
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
                TypeUrl = TerraConstants.TERRA_ORACLE_EXCHANGE_RATE_VOTE,
                Value = this.ToProto()
            };
        }

        public static MsgAggregateExchangeRateVote UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgAggregateExchangeRateVote>(msgAny.Value));
        }
    }

    public class MsgAggregateExchangeRateVoteAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgAggregateExchangeRateVoteValueAminoArgs Value { get; set; }
        public MsgAggregateExchangeRateVoteAminoArgs()
        {
            this.Type = OracleConstants.ORACLE_MSG_AGGREGATE_EXCHANGE_RATE_VOTE;
        }
    }

    public class MsgAggregateExchangeRateVoteValueAminoArgs
    {
        public string Salt { get; set; }
        public string Feeder { get; set; }
        public string Validator { get; set; }
        public string Exchange_Rates { get; set; }
    }

    public class MsgAggregateExchangeRateVoteDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Salt { get; set; }
        public string Feeder { get; set; }
        public string Validator { get; set; }

        public string Exchange_Rates { get; set; }

        public MsgAggregateExchangeRateVoteDataArgs()
        {
            this.Type = TerraConstants.TERRA_ORACLE_EXCHANGE_RATE_VOTE;
        }
    }
}
