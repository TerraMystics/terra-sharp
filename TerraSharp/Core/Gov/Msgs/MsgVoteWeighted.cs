using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Rest.Tx.Transaction;
using System.Linq;

namespace Terra.Microsoft.Client.Core.Gov.Msgs
{

    public class MsgVoteWeighted : SignerData
    {
        public readonly double proposal_id;
        public readonly string voter;
        public readonly WeightedVoteOption[] option;

        public MsgVoteWeighted(double proposal_id, string voter, WeightedVoteOption[] option)
        {
            this.proposal_id = proposal_id;
            this.voter = voter;
            this.option = option;
        }

        public static MsgVoteWeighted FromAmino(MsgVoteWeightedAminoArgs data)
        {
            return new MsgVoteWeighted(double.Parse(data.Value.ProposalId), data.Value.Voter, data.Value.Option);
        }

        public static MsgVoteWeighted FromData(MsgVoteWeightedDataArgs data)
        {
            return new MsgVoteWeighted(double.Parse(data.ProposalId), data.Voter, data.Option);
        }

        public static MsgVoteWeighted FromProto(PROTO.MsgVoteWeighted data)
        {
            return new MsgVoteWeighted(
                data.ProposalId, 
                data.Voter,
                data.Options.ConvertAll(w => WeightedVoteOption.FromProto(w)).ToArray());
        }

        public MsgVoteWeightedAminoArgs ToAmino()
        {
            return new MsgVoteWeightedAminoArgs()
            {
                Value = new MsgVoteWeightedValueAminoArgs()
                {
                    ProposalId = this.proposal_id.ToString(),
                    Voter = this.voter,
                    Option = this.option,
                }
            };
        }

        public MsgVoteWeightedDataArgs ToData()
        {
            return new MsgVoteWeightedDataArgs()
            {
                ProposalId = this.proposal_id.ToString(),
                Voter = this.voter,
                Option = this.option,
            };
        }
        //public override TxBodyJSONMessages ToJson()
        //{
        //    return new TxBodyJSONMessages()
        //    {
        //        validator_address = this.validator_address,
        //        delegator_address = this.delegator_address,
        //        type = this.ToData().Type
        //    };
        //}

        public PROTO.MsgVoteWeighted ToProtoWithType()
        {
            return new PROTO.MsgVoteWeighted()
            {
                Options = this.option.ToList().ConvertAll(w => w.ToProtoWithType()),
                ProposalId = (ulong)this.proposal_id,
                Voter = this.voter
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
                TypeUrl = CosmosConstants.COSMOS_GOV_MSG_VOTE_WEIGHTED,
                Value = this.ToProto()
            };
        }

        public static MsgVoteWeighted UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgVoteWeighted>(msgAny.Value));
        }
    }

    public class MsgVoteWeightedAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgVoteWeightedValueAminoArgs Value { get; set; }
        public MsgVoteWeightedAminoArgs()
        {
            this.Type = GovConstants.MSG_VOTE_WEIGHTED;
        }
    }

    public class MsgVoteWeightedValueAminoArgs : MsgVoteWeightedCommonOptionArgs
    {
    }

    public class MsgVoteWeightedDataArgs : MsgVoteWeightedCommonOptionArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public MsgVoteWeightedDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_GOV_MSG_VOTE_WEIGHTED;
        }
    }

    public class MsgVoteWeightedCommonOptionArgs
    {
        public WeightedVoteOption[] Option { get; set; }
        public string ProposalId { get; set; }
        public string Voter { get; set; }
    }
}
