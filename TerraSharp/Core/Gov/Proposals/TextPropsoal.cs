using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Gov.Proposals;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Gov.Proposals
{
    public class TextProposal 
    {
        public readonly string title;
        public readonly string description;

        public TextProposal(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public static TextProposal FromAmino(TextProposalAminoArgs data)
        {
            return new TextProposal(data.Value.Title, data.Value.Description);
        }

        public static TextProposal FromData(TextProposalDataArgs data)
        {
            return new TextProposal(data.Title, data.Description);
        }

        public static TextProposal FromProto(PROTO.TextProposal data)
        {
            return new TextProposal(data.Title, data.Description);
        }

        public TextProposalAminoArgs ToAmino()
        {
            return new TextProposalAminoArgs()
            {
                Value = new TextProposalValueAminoArgs()
                {
                    Description = this.description,
                    Title = this.title,
                }
            };
        }

        public TextProposalDataArgs ToData()
        {
            return new TextProposalDataArgs()
            {
                Description = this.description,
                Title = this.title,
            };
        }

        public PROTO.TextProposal ToProtoWithType()
        {
            return new PROTO.TextProposal()
            {
                Description = this.description,
                Title = this.title
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
                TypeUrl = CosmosConstants.COSMOS_TEXT_PROPOSAL_SOFTWARE_UPGRADE_PROPOSAL,
                Value = this.ToProto()
            };
        }

        public static TextProposal UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.TextProposal>(msgAny.Value));
        }
    }

    public class TextProposalAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public TextProposalValueAminoArgs Value { get; set; }
        public TextProposalAminoArgs()
        {
            this.Type = ProposalConstants.TEXT_SOFTWARE;
        }
    }

    public class TextProposalValueAminoArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class TextProposalDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public TextProposalDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_TEXT_PROPOSAL_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }
}
