using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.upgrade.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Gov;
using Newtonsoft.Json;

namespace TerraSharp.Core.Upgrade.Proposals
{
    public class CancelSoftwareUpgradeProposal 
    {
        public readonly string title;
        public readonly string description;

        public CancelSoftwareUpgradeProposal(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public static CancelSoftwareUpgradeProposal FromAmino(CancelSoftwareUpgradeProposalAminoArgs data)
        {
            return new CancelSoftwareUpgradeProposal(data.Value.Title, data.Value.Description);
        }

        public static CancelSoftwareUpgradeProposal FromData(CancelSoftwareUpgradeProposalDataArgs data)
        {
            return new CancelSoftwareUpgradeProposal(data.Title, data.Description);
        }

        public static CancelSoftwareUpgradeProposal FromProto(PROTO.CancelSoftwareUpgradeProposal data)
        {
            return new CancelSoftwareUpgradeProposal(data.Title, data.Description);
        }

        public CancelSoftwareUpgradeProposalAminoArgs ToAmino()
        {
            return new CancelSoftwareUpgradeProposalAminoArgs()
            {
                Value = new CancelSoftwareUpgradeProposalValueAminoArgs()
                {
                    Description = this.description,
                    Title = this.title,
                }
            };
        }

        public CancelSoftwareUpgradeProposalDataArgs ToData()
        {
            return new CancelSoftwareUpgradeProposalDataArgs()
            {
                Description = this.description,
                Title = this.title,
            };
        }

        public PROTO.CancelSoftwareUpgradeProposal ToProtoWithType()
        {
            return new PROTO.CancelSoftwareUpgradeProposal()
            {
                Description = this.description,
                Title = this.title,
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
                TypeUrl = CosmosConstants.COSMOS_CANCEL_SOFTWARE_UPGRADE_PROPOSAL,
                Value = this.ToProto()
            };
        }

        public static CancelSoftwareUpgradeProposal UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.CancelSoftwareUpgradeProposal>(msgAny.Value));
        }
    }

    public class CancelSoftwareUpgradeProposalAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public CancelSoftwareUpgradeProposalValueAminoArgs Value { get; set; }
        public CancelSoftwareUpgradeProposalAminoArgs()
        {
            this.Type = ProposalConstants.CANCEL_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }

    public class CancelSoftwareUpgradeProposalValueAminoArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class CancelSoftwareUpgradeProposalDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public CancelSoftwareUpgradeProposalDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_CANCEL_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }
}
