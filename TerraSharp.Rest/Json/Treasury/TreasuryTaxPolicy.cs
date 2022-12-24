namespace TerraSharp.Rest.Treasury
{
    public class TreasuryTaxPolicy
    {
        public TreasuryTaxPolicyValue tax_policy { get; set; }
        public TreasuryTaxPolicyValue reward_policy { get; set; }
        public string seigniorage_burden_target { get; set; }
        public string mining_increment { get; set; }
        public string window_short { get; set; }
        public string window_long { get; set; }
        public string window_probation { get; set; }
    }
}
