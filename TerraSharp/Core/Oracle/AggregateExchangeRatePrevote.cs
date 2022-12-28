using Terra.Microsoft.Extensions.ProtoBufs;
using PROTO = Terra.Microsoft.ProtoBufs.proto.oracle.v1beta1;

namespace Terra.Microsoft.Client.Core.Oracle
{
    public class AggregateExchangeRatePrevote
    {
        public readonly string hash;
        public readonly string voter;
        public readonly double submit_block;

        public AggregateExchangeRatePrevote(
            string hash,
            string voter,
            double submit_block)
        {
            this.hash = hash;
            this.voter = voter;
            this.submit_block = submit_block;
        }

        public static AggregateExchangeRatePrevote FromAmino(AggregateExchangeRatePrevoteAminoArgs data)
        {
            return new AggregateExchangeRatePrevote(data.Hash, data.Voter, double.Parse(data.Submit_block));
        }

        public static AggregateExchangeRatePrevote FromData(AggregateExchangeRatePrevoteDataArgs data)
        {
            return new AggregateExchangeRatePrevote(data.Hash, data.Voter, double.Parse(data.Submit_block));
        }

        public static AggregateExchangeRatePrevote FromProto(PROTO.AggregateExchangeRatePrevote data)
        {
            return new AggregateExchangeRatePrevote(data.Hash, data.Voter, data.SubmitBlock);
        }

        public AggregateExchangeRatePrevoteAminoArgs ToAmino()
        {
            return new AggregateExchangeRatePrevoteAminoArgs()
            {
                Submit_block = this.submit_block.ToString(),
                Hash = this.hash,
                Voter = this.voter
            };
        }

        public AggregateExchangeRatePrevoteDataArgs ToData()
        {
            return new AggregateExchangeRatePrevoteDataArgs()
            {
                Submit_block = this.submit_block.ToString(),
                Hash = this.hash,
                Voter = this.voter
            };
        }

        public PROTO.AggregateExchangeRatePrevote ToProtoWithType()
        {
            return new PROTO.AggregateExchangeRatePrevote()
            {
                Hash = this.hash,
                SubmitBlock = (ulong)this.submit_block,
                Voter = this.voter
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class AggregateExchangeRatePrevoteAminoArgs : AggregateExchangeRatePrevoteCommonArgs
    {
    }

    public class AggregateExchangeRatePrevoteDataArgs : AggregateExchangeRatePrevoteCommonArgs
    {
    }

    public class AggregateExchangeRatePrevoteCommonArgs
    {
        public string Hash { get; set; }
        public string Voter { get; set; }
        public string Submit_block { get; set; }
    }
}
