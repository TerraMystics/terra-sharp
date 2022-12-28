using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Core.Gov;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.upgrade.v1beta1;

namespace Terra.Microsoft.Client.Core.Upgrade.Proposals
{
    public class SoftwareUpgradeProposal
    {
        public readonly string title;
        public readonly string description;
        public readonly Plan plan;

        public SoftwareUpgradeProposal(string title, string description, Plan plan)
        {
            this.title = title;
            this.description = description;
            this.plan = plan;
        }

        public static SoftwareUpgradeProposal FromAmino(SoftwareUpgradeProposalAminoArgs data)
        {
            return new SoftwareUpgradeProposal(data.Value.Title, data.Value.Description, data.Value.Plan);
        }

        public static SoftwareUpgradeProposal FromData(SoftwareUpgradeProposalDataArgs data)
        {
            return new SoftwareUpgradeProposal(data.Title, data.Description, data.Plan);
        }

        public static SoftwareUpgradeProposal FromProto(PROTO.SoftwareUpgradeProposal data)
        {
            return new SoftwareUpgradeProposal(data.Title, data.Description, Plan.FromProto(data.Plan));
        }

        public SoftwareUpgradeProposalAminoArgs ToAmino()
        {
            return new SoftwareUpgradeProposalAminoArgs()
            {
                Value = new SoftwareUpgradeProposalValueAminoArgs()
                {
                    Description = this.description,
                    Title = this.title,
                    Plan = this.plan,
                }
            };
        }

        public SoftwareUpgradeProposalDataArgs ToData()
        {
            return new SoftwareUpgradeProposalDataArgs()
            {
                Description = this.description,
                Title = this.title,
                Plan = this.plan,
            };
        }

        public PROTO.SoftwareUpgradeProposal ToProtoWithType()
        {
            return new PROTO.SoftwareUpgradeProposal()
            {
                Description = this.description,
                Title = this.title,
                Plan = this.plan.ToProtoWithType()
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
                TypeUrl = CosmosConstants.COSMOS_SOFTWARE_UPGRADE_PROPOSAL,
                Value = this.ToProto()
            };
        }

        public static SoftwareUpgradeProposal UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.SoftwareUpgradeProposal>(msgAny.Value));
        }
    }

    public class SoftwareUpgradeProposalAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public SoftwareUpgradeProposalValueAminoArgs Value { get; set; }
        public SoftwareUpgradeProposalAminoArgs()
        {
            this.Type = ProposalConstants.SOFTWARE_UPGRADE_PROPOSAL;
        }
    }

    public class SoftwareUpgradeProposalValueAminoArgs
    {
        public string Title;
        public string Description;
        public Plan Plan;
    }

    public class SoftwareUpgradeProposalDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Title;
        public string Description;
        public Plan Plan;

        public SoftwareUpgradeProposalDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }
}
