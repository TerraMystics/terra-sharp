using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Gov;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.IBC.Proposals
{
    public class ClientUpdateProposal 
    {
        public readonly string title;
        public readonly string description;
        public readonly string subjectClientId;
        public readonly string substituteClientId;

        public ClientUpdateProposal(string title, string description, string subjectClientId, string substituteClientId)
        {
            this.title = title;
            this.description = description;
            this.subjectClientId = subjectClientId;
            this.substituteClientId = substituteClientId;
        }

        public static ClientUpdateProposal FromAmino(ClientUpdateProposalAminoArgs data)
        {
            return new ClientUpdateProposal(data.Value.Title, data.Value.Description, data.Value.SubjectClientId, data.Value.SubstituteClientId);
        }

        public static ClientUpdateProposal FromData(ClientUpdateProposalDataArgs data)
        {
            return new ClientUpdateProposal(data.Title, data.Description, data.SubjectClientId, data.SubstituteClientId);
        }

        public static ClientUpdateProposal FromProto(PROTO.ClientUpdateProposal data)
        {
            return new ClientUpdateProposal(data.Title, data.Description, data.SubjectClientId, data.SubstituteClientId);
        }

        public ClientUpdateProposalAminoArgs ToAmino()
        {
            return new ClientUpdateProposalAminoArgs()
            {
                Value = new ClientUpdateProposalValueAminoArgs()
                {
                    Description = this.description,
                    Title = this.title,
                    SubjectClientId = this.subjectClientId,
                    SubstituteClientId = this.substituteClientId
                }
            };
        }

        public ClientUpdateProposalDataArgs ToData()
        {
            return new ClientUpdateProposalDataArgs()
            {
                Description = this.description,
                Title = this.title,
                SubjectClientId = this.subjectClientId,
                SubstituteClientId = this.substituteClientId
            };
        }

        public PROTO.ClientUpdateProposal ToProtoWithType()
        {
            return new PROTO.ClientUpdateProposal()
            {
                Description = this.description,
                SubjectClientId = this.subjectClientId,
                SubstituteClientId = this.substituteClientId,
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
                TypeUrl = CosmosConstants.COSMOS_ClientUpdate_IBC_SOFTWARE_UPGRADE_PROPOSAL,
                Value = this.ToProto()
            };
        }

        public static ClientUpdateProposal UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.ClientUpdateProposal>(msgAny.Value));
        }
    }

    public class ClientUpdateProposalAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public ClientUpdateProposalValueAminoArgs Value { get; set; }
        public ClientUpdateProposalAminoArgs()
        {
            this.Type = ProposalConstants.IBC_CLIENTUPDATE_PROPOSAL;
        }
    }

    public class ClientUpdateProposalValueAminoArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubjectClientId { get; set; }
        public string SubstituteClientId { get; set; }
    }

    public class ClientUpdateProposalDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string SubjectClientId { get; set; }
        public string SubstituteClientId { get; set; }

        public ClientUpdateProposalDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_ClientUpdate_IBC_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }
}
