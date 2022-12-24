using System.Linq;
using TerraNetExtensions.ProtoBufs;
using PROTO = TerraProto.CSharp.proto.oracle.v1beta1;

namespace TerraSharp.Core.Oracle
{
    public class AggregateExchangeRateVote
    {
        public readonly string voter;
        public readonly ExchangeRateTuple[] exchange_rate_tuples;

        public AggregateExchangeRateVote(
            string voter,
            ExchangeRateTuple[] exchange_rate_tuples)
        {
            this.voter = voter;
            this.exchange_rate_tuples = exchange_rate_tuples;
        }

        public static AggregateExchangeRateVote FromAmino(AggregateExchangeRateVoteAminoArgs data)
        {
            return new AggregateExchangeRateVote(data.Voter, data.Exchange_Rate_Tuples);
        }

        public static AggregateExchangeRateVote FromData(AggregateExchangeRateVoteDataArgs data)
        {
            return new AggregateExchangeRateVote(data.Voter, data.Exchange_Rate_Tuples);
        }

        public static AggregateExchangeRateVote FromProto(PROTO.AggregateExchangeRateVote data)
        {
            return new AggregateExchangeRateVote(data.Voter, data.ExchangeRateTuples.ConvertAll(w => ExchangeRateTuple.FromProto(w)).ToArray());
        }

        public AggregateExchangeRateVoteAminoArgs ToAmino()
        {
            return new AggregateExchangeRateVoteAminoArgs()
            {
                Exchange_Rate_Tuples = this.exchange_rate_tuples,
                Voter = this.voter
            };
        }

        public AggregateExchangeRateVoteDataArgs ToData()
        {
            return new AggregateExchangeRateVoteDataArgs()
            {
                Exchange_Rate_Tuples = this.exchange_rate_tuples,
                Voter = this.voter
            };
        }

        public PROTO.AggregateExchangeRateVote ToProtoWithType()
        {
            return new PROTO.AggregateExchangeRateVote()
            {
                ExchangeRateTuples = this.exchange_rate_tuples.ToList().ConvertAll(w => w.ToProtoWithType()),
                Voter = this.voter
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class AggregateExchangeRateVoteAminoArgs : AggregateExchangeRateVoteCommonArgs
    {
    }

    public class AggregateExchangeRateVoteDataArgs : AggregateExchangeRateVoteCommonArgs
    {
    }

    public class AggregateExchangeRateVoteCommonArgs
    {
        public ExchangeRateTuple[] Exchange_Rate_Tuples { get; set; }
        public string Voter { get; set; }
    }
}
