using TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

namespace TerraSharp.Rest.Converters
{
    public static class ProposalStatusConverters
    {
        public static ProposalStatus GetFromString(string val)
        {
            switch (val)
            {
                case "PROPOSAL_STATUS_UNSPECIFIED":
                    return ProposalStatus.ProposalStatusUnspecified;
                case "PROPOSAL_STATUS_DEPOSIT_PERIOD":
                    return ProposalStatus.ProposalStatusDepositPeriod;
                case "PROPOSAL_STATUS_VOTING_PERIOD":
                    return ProposalStatus.ProposalStatusVotingPeriod;
                case "PROPOSAL_STATUS_PASSED":
                    return ProposalStatus.ProposalStatusPassed;
                case "PROPOSAL_STATUS_REJECTED":
                    return ProposalStatus.ProposalStatusRejected;
                case "PROPOSAL_STATUS_FAILED":
                    return ProposalStatus.ProposalStatusFailed;
            }

            return ProposalStatus.ProposalStatusUnspecified;
        }
        public static string GetFromEnum(ProposalStatus val)
        {
            switch (val)
            {
                case ProposalStatus.ProposalStatusUnspecified:
                    return "PROPOSAL_STATUS_UNSPECIFIED";
                case ProposalStatus.ProposalStatusDepositPeriod:
                    return "PROPOSAL_STATUS_DEPOSIT_PERIOD";
                case ProposalStatus.ProposalStatusVotingPeriod:
                    return "PROPOSAL_STATUS_VOTING_PERIOD";
                case ProposalStatus.ProposalStatusPassed:
                    return "PROPOSAL_STATUS_PASSED";
                case ProposalStatus.ProposalStatusRejected:
                    return "PROPOSAL_STATUS_REJECTED";
                case ProposalStatus.ProposalStatusFailed:
                    return "PROPOSAL_STATUS_FAILED";
            }

            return "PROPOSAL_STATUS_UNSPECIFIED";
        }
    }
}
