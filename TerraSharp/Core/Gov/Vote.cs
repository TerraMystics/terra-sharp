using Google.Protobuf.WellKnownTypes;
using System;
using System.Linq;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Authz.Msgs;
using Terra.Microsoft.Client.Core.Feegrant.Allowances;
using Terra.Microsoft.Rest.Gov.Proposals;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1;

namespace Terra.Microsoft.Client.Core.Gov
{
    public class Vote
    {
        public readonly double proposal_id;
        public readonly string voter;
        public readonly WeightedVoteOption[] options;

        public Vote(
            double proposal_id,
            string voter,
            WeightedVoteOption[] options)
        {
            this.proposal_id = proposal_id;
            this.voter = voter;
            this.options = options;
        }

        public static Vote FromAmino(VoteAminoArgs data)
        {
            return new Vote(double.Parse(data.Proposal_id), data.Voter, data.Options);
        }

        public static Vote FromData(VoteDataArgs data)
        {
            return new Vote(double.Parse(data.Proposal_id), data.Voter, data.Options);
        }
        public static Vote FromJSON(VotesJSON data)
        {
            return new Vote(data.proposal_id, data.voter,
                data.options.ToList().ConvertAll(w => WeightedVoteOption.FromJSON(w)).ToArray());
        }

        public static Vote FromProto(PROTO.Vote data)
        {
            return new Vote((double)data.ProposalId, data.Voter, data.Options.ConvertAll(w => WeightedVoteOption.FromProto(w)).ToArray());
        }

        public static Vote UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.Vote>(msgAny.Value));
        }

        public VoteAminoArgs ToAmino()
        {
            return new VoteAminoArgs()
            {
                Proposal_id = this.proposal_id.ToString(),
                Voter = this.voter,
                Options = this.options,
            };
        }

        public VoteDataArgs ToData()
        {
            return new VoteDataArgs()
            {
                Proposal_id = this.proposal_id.ToString(),
                Voter = this.voter,
                Options = this.options,
            };
        }

        public PROTO.Vote ToProtoWithType()
        {
            //return new PROTO.Vote()
            //{
            //    Option = this.option,
            //    Options = this.options,
            //    ProposalId = this.proposal_id,
            //    Voter = this.voter
            //};

            throw new NotImplementedException("");
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class VoteAminoArgs : CommonVoteArgs
    {
    }

    public class VoteDataArgs : CommonVoteArgs
    {

    }

    public class CommonVoteArgs
    {
        public string Proposal_id { get; set; }
        public string Voter { get; set; }
        public WeightedVoteOption[] Options { get; set; }
    }
}
