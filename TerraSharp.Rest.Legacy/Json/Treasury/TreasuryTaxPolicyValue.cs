namespace Terra.Microsoft.Rest.Treasury
{
    public class TreasuryTaxPolicyValue
    {
        public string rate_min { get; set; }
        public string rate_max { get; set; }
        public string change_rate_max { get; set; }
        public CoinJSON cap { get; set; }
    }
}
