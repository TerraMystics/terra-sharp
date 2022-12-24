using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Converters;
using TerraSharp.Rest.Gov.Proposals;
using TerraSharp.Rest.Tx.Transaction;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

namespace TerraSharp.Core.Gov
{
    public class WeightedVoteOption
    {
        public readonly decimal weight;
        public readonly PROTO.VoteOption option;
        public WeightedVoteOption(
            PROTO.VoteOption option, decimal weight)
        {
            this.option = option;
            this.weight = weight;
        }

        public static WeightedVoteOption FromAmino(WeightedVoteAminoArgs data)
        {
            return new WeightedVoteOption(data.Option, decimal.Parse(data.Weight));
        }
        public static WeightedVoteOption FromJSON(WeightedOptionsJSON data)
        {
            return new WeightedVoteOption(VoteOptionConverters.GetFromString(data.option), decimal.Parse(data.weight));
        }

        public static WeightedVoteOption FromData(WeightedVoteDataArgs data)
        {
            return new WeightedVoteOption(data.Option, decimal.Parse(data.Weight));
        }
        public static WeightedVoteOption FromJSON(VoteOptionJSON data)
        {
            return new WeightedVoteOption(data.option, decimal.Parse(data.weight));
        }

        public static WeightedVoteOption FromProto(PROTO.WeightedVoteOption data)
        {
            return new WeightedVoteOption(data.Option, decimal.Parse(data.Weight));
        }

        public WeightedVoteAminoArgs ToAmino()
        {
            return new WeightedVoteAminoArgs()
            {
                Weight = this.weight.ToString(),
                Option = this.option,
            };
        }

        public WeightedVoteDataArgs ToData()
        {
            return new WeightedVoteDataArgs()
            {
                Weight = this.weight.ToString(),
                Option = this.option,
            };
        }

        public PROTO.WeightedVoteOption ToProtoWithType()
        {
            return new PROTO.WeightedVoteOption()
            {
                Option = this.option,
                Weight = this.weight.ToString()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class WeightedVoteAminoArgs : WeightedCommonVoteArgs
    {
    }

    public class WeightedVoteDataArgs : WeightedCommonVoteArgs
    {

    }

    public class WeightedCommonVoteArgs
    {
        public PROTO.VoteOption Option { get; set; }
        public string Weight { get; set; }
    }
}
