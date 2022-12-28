namespace Terra.Microsoft.Rest.Gov.Proposals
{
    public class ProposalDepositsJSON
    {
        public string proposal_id { get; set; }
        public string depositor { get; set; }
        public CoinJSON[] amount { get; set; }
    }
}
