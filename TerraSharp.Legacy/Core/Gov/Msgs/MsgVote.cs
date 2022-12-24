using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Extensions;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using TerraSharp.Rest.Tx.Transaction;

namespace TerraSharp.Core.Gov.Msgs
{
    public class MsgVote : SignerData
    {
        public readonly double proposal_id;
        public readonly string voter;
        public readonly PROTO.VoteOption option;

        public MsgVote(double proposal_id, string voter, PROTO.VoteOption option)
        {
            this.proposal_id = proposal_id;
            this.voter = voter;
            this.option = option;
        }

        public static MsgVote FromAmino(MsgVoteAminoArgs data)
        {
            return new MsgVote(double.Parse(data.Value.ProposalId), data.Value.Voter, data.Value.Option);
        }

        public static MsgVote FromData(MsgVoteDataArgs data)
        {
            return new MsgVote(double.Parse(data.ProposalId), data.Voter, data.Option);
        }

        public static MsgVote FromProto(PROTO.MsgVote data)
        {
            return new MsgVote(data.ProposalId, data.Voter, data.Option);
        }

        public MsgVoteAminoArgs ToAmino()
        {
            return new MsgVoteAminoArgs()
            {
                Value = new MsgVoteValueAminoArgs()
                {
                    ProposalId = this.proposal_id.ToString(),
                    Voter = this.voter,
                    Option = this.option,
                }
            };
        }

        public MsgVoteDataArgs ToData()
        {
            return new MsgVoteDataArgs()
            {
                ProposalId = this.proposal_id.ToString(),
                Voter = this.voter,
                Option = this.option,
            };
        }

        public PROTO.MsgVote ToProtoWithType()
        {
            return new PROTO.MsgVote()
            {
                Option = this.option,
                ProposalId = (ulong)this.proposal_id,
                Voter = this.voter
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

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_GOV_MSG_VOTE,
                Value = this.ToProto()
            };
        }

        public static MsgVote UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgVote>(msgAny.Value));
        }
    }

    public class MsgVoteAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgVoteValueAminoArgs Value { get; set; }
        public MsgVoteAminoArgs()
        {
            this.Type = GovConstants.MSG_VOTE;
        }
    }

    public class MsgVoteValueAminoArgs : MsgVoteCommonOptionArgs
    {
    }

    public class MsgVoteDataArgs : MsgVoteCommonOptionArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public MsgVoteDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_GOV_MSG_VOTE;
        }
    }

    public class MsgVoteCommonOptionArgs
    {
        public string ProposalId { get; set; }
        public string Voter { get; set; }
        public PROTO.VoteOption Option { get; set; }
    }
}
