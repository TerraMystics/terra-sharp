namespace Terra.Microsoft.Rest.Gov.Proposals
{
    public class ProposalsDepositParamsJSON
    {
        public string max_deposit_period { get; set; }
        public CoinJSON[] min_deposit { get; set; }
    }
}
