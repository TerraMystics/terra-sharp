namespace Terra.Microsoft.Rest.Gov.Proposals
{
    public class ProposalsParams
    {

        public ProposalsVotingParamsJSON voting_params { get; set; }
        public ProposalsDepositParamsJSON deposit_params { get; set; }
        public ProposalsTallyParamsJSON tally_params { get; set; }
    }
}
