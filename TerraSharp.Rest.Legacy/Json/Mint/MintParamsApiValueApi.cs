namespace Terra.Microsoft.Rest.Mint
{
    public class MintParamsApiValueApi
    {
        public string mint_denom { get; set; }
        public string inflation_rate_change { get; set; }
        public string inflation_max { get; set; }
        public string inflation_min { get; set; }
        public string goal_bonded { get; set; }
        public string blocks_per_year { get; set; }
    }
}
