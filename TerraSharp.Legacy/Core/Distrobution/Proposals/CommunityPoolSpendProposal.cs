using PROTO = TerraProto.CSharp.third_party.proto.cosmos.distribution.v1beta1;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Extensions;
using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Gov;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Core.Distrobution.Proposals
{
    public class CommunityPoolSpendProposal
    {
        public List<Coin> amount;
        public readonly string title;
        public readonly string description;
        public readonly string recipient;

        public CommunityPoolSpendProposal(string title, string description, string recipient, List<Coin> amount)
        {
            this.title = title;
            this.description = description;
            this.recipient = recipient;
            this.amount = amount;
        }

        public static CommunityPoolSpendProposal FromAmino(CommunityPoolSpendProposalAminoArgs data)
        {
            return new CommunityPoolSpendProposal(data.Value.Title, data.Value.Description, data.Value.Recipient, CoinsExtensions.FromAmino(data.Value.Amount).ToList());
        }
        public static CommunityPoolSpendProposal FromData(CommunityPoolSpendProposalDataArgs data)
        {
            return new CommunityPoolSpendProposal(data.Title, data.Description, data.Recipient, CoinsExtensions.FromData(data.Amount).ToList());
        }
        public static CommunityPoolSpendProposal FromProto(PROTO.CommunityPoolSpendProposal data)
        {
            return new CommunityPoolSpendProposal(data.Title, data.Description, data.Recipient, CoinsExtensions.FromProto(data.Amounts).ToList());
        }

        public CommunityPoolSpendProposalAminoArgs ToAmino()
        {
            return new CommunityPoolSpendProposalAminoArgs()
            {
                Value = new CommunityPoolSpendProposalValueAminoArgs()
                {
                    Amount = CoinsExtensions.ToAmino(this.amount).ToArray(),
                    Description = this.description,
                    Recipient = this.recipient,
                    Title = this.title
                }
            };
        }
        public CommunityPoolSpendProposalDataArgs ToData()
        {
            return new CommunityPoolSpendProposalDataArgs()
            {
                Amount = CoinsExtensions.ToData(this.amount).ToArray(),
                Description = this.description,
                Recipient = this.recipient,
                Title = this.title
            };
        }

        public PROTO.CommunityPoolSpendProposal ToProtoWithType()
        {
            return new PROTO.CommunityPoolSpendProposal()
            {
                Amounts = this.amount.ConvertAll(w => w.ToProtoWithType()),
                Description = this.description,
                Title = this.title,
                Recipient = this.recipient
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
                TypeUrl = CosmosConstants.COSMOS_DISTRIBUTION_MSG_COMMUNITY_POOLSPENDPROPOSAL,
                Value = this.ToProto()
            };
        }

        public static CommunityPoolSpendProposal UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.CommunityPoolSpendProposal>(msgAny.Value));
        }
    }

    public class CommunityPoolSpendProposalAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public CommunityPoolSpendProposalValueAminoArgs Value { get; set; }

        public CommunityPoolSpendProposalAminoArgs()
        {
            this.Type = DistributionConstants.DISTRIBUTION_COMMUNITY_POOL_SPEND_PROPOSAL;
        }
    }

    public class CommunityPoolSpendProposalValueAminoArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Recipient { get; set; }
        public CoinAminoArgs[] Amount { get; set; }
        public CommunityPoolSpendProposalValueAminoArgs()
        {

        }
    }

    public class CommunityPoolSpendProposalDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Recipient { get; set; }
        public CoinDataArgs[] Amount { get; set; }
        public CommunityPoolSpendProposalDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_DISTRIBUTION_MSG_COMMUNITY_POOLSPENDPROPOSAL;
        }
    }
}
