using PROTO = TerraProto.CSharp.third_party.proto.cosmos.distribution.v1beta1;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Extensions;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Core.Distrobution.Msgs
{
    public class MsgFundCommunityPool : SignerData
    {
        public List<Coin> amount;
        public readonly string depositor;

        public MsgFundCommunityPool(string depositor, List<Coin> amount)
        {
            this.depositor = depositor;
            this.amount = amount;
        }

        public static MsgFundCommunityPool FromAmino(MsgFundCommunityPoolAminoArgs data)
        {
            return new MsgFundCommunityPool(data.Value.Depositor, CoinsExtensions.FromAmino(data.Value.Amount).ToList());
        }

        public static MsgFundCommunityPool FromData(MsgFundCommunityPoolDataArgs data)
        {
            return new MsgFundCommunityPool(data.Depositor, CoinsExtensions.FromData(data.Amount).ToList());
        }

        public static MsgFundCommunityPool FromProto(PROTO.MsgFundCommunityPool data)
        {
            return new MsgFundCommunityPool(data.Depositor, CoinsExtensions.FromProto(data.Amounts).ToList());
        }

        public MsgFundCommunityPoolAminoArgs ToAmino()
        {
            return new MsgFundCommunityPoolAminoArgs()
            {
                Value = new MsgFundCommunityPoolValueAminoArgs()
                {
                    Amount = CoinsExtensions.ToAmino(this.amount).ToArray(),
                    Depositor = this.depositor,
                }
            };
        }

        public MsgFundCommunityPoolDataArgs ToData()
        {
            return new MsgFundCommunityPoolDataArgs()
            {
                Amount = CoinsExtensions.ToData(this.amount).ToArray(),
                Depositor = this.depositor,
            };
        }

        public PROTO.MsgFundCommunityPool ToProtoWithType()
        {
            return new PROTO.MsgFundCommunityPool()
            {
                Amounts = this.amount.ConvertAll(w => w.ToProtoWithType()),
                Depositor = this.depositor
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MsgFundCommunityPoolAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgFundCommunityPoolValueAminoArgs Value { get; set; }
        public MsgFundCommunityPoolAminoArgs()
        {
            this.Type = DistributionConstants.DISTRIBUTION_MSG_FUND_COMMUNITYPOOL;
        }
    }

    public class MsgFundCommunityPoolValueAminoArgs
    {
        public string Depositor { get; set; }
        public CoinAminoArgs[] Amount { get; set; }
    }

    public class MsgFundCommunityPoolDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Depositor { get; set; }
        public CoinDataArgs[] Amount { get; set; }

        public MsgFundCommunityPoolDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_DISTRIBUTION_MSG_FUNDCOMMUNITYPOOL;
        }
    }
}
