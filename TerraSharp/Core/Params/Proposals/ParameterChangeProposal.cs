using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.iparams.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Key.Data.SimplePublicKey;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Gov;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Params.Proposals
{
    public class ParameterChangeProposal 
    {
        public readonly string title;
        public readonly string description;
        public readonly List<ParamChange> changes;

        public ParameterChangeProposal(string title, string description, List<ParamChange> changes)
        {
            this.title = title;
            this.description = description;
            this.changes = changes;
        }

        public static ParameterChangeProposal FromAmino(ParameterChangeProposalAminoArgs data)
        {
            return new ParameterChangeProposal(data.Value.Title, data.Value.Description, ParamChangesExtensions.FromAmino(data.Value.Changes).ToList());
        }

        public static ParameterChangeProposal FromData(ParameterChangeProposalDataArgs data)
        {
            return new ParameterChangeProposal(data.Title, data.Description, ParamChangesExtensions.FromData(data.Changes).ToList());
        }

        public static ParameterChangeProposal FromProto(PROTO.ParameterChangeProposal data)
        {
            return new ParameterChangeProposal(data.Title, data.Description, ParamChangesExtensions.FromProto(data.Changes).ToList());
        }

        public ParameterChangeProposalAminoArgs ToAmino()
        {
            return new ParameterChangeProposalAminoArgs()
            {
                Value = new ParameterChangeProposalValueAminoArgs()
                {
                    Description = this.description,
                    Title = this.title,
                    Changes = ParamChangesExtensions.ToAmino(this.changes).ToArray()
                }
            };
        }

        public ParameterChangeProposalDataArgs ToData()
        {
            return new ParameterChangeProposalDataArgs()
            {
                Description = this.description,
                Title = this.title,
                Changes = ParamChangesExtensions.ToData(this.changes).ToArray()
            };
        }

        public PROTO.ParameterChangeProposal ToProtoWithType()
        {
            return new PROTO.ParameterChangeProposal()
            {
                Changes = this.changes.ConvertAll(w => w.ToProtoWithType()),
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
                TypeUrl = CosmosConstants.COSMOS_PARAMETER_CHANGE_PROPOSAL_SOFTWARE_UPGRADE_PROPOSAL,
                Value = this.ToProto()
            };
        }

        public static ParameterChangeProposal UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.ParameterChangeProposal>(msgAny.Value));
        }
    }

    public class ParameterChangeProposalAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public ParameterChangeProposalValueAminoArgs Value { get; set; }
        public ParameterChangeProposalAminoArgs()
        {
            this.Type = ProposalConstants.PARAMETER_CHANGE_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }

    public class ParameterChangeProposalValueAminoArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ParamChangeAminoArgs[] Changes { get; set; }
    }

    public class ParameterChangeProposalDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public ParamChangeDataArgs[] Changes { get; set; }

        public ParameterChangeProposalDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_PARAMETER_CHANGE_PROPOSAL_SOFTWARE_UPGRADE_PROPOSAL;
        }
    }
}
