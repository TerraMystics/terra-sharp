namespace Terra.Microsoft.Rest.Treasury
{
    public class TreasuryTaxCap
    {
        public CoinJSON[] tax_proceeds { get; set; }
        public string reward_weight { get; set; }
        public string tax_rate { get; set; }
        public string tax_cap { get; set; }
        public TreasuryTaxCapValue[] tax_caps { get; set; }
    }
    public class TreasuryTaxCapValue
    {
        public string denom { get; set; }
        public string tax_cap { get; set; }
    }

    public class TreasuryRewardWeight
    {
        public string reward_weight { get; set; }
    }
}
