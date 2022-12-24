namespace TerraSharp.Rest.Staking
{
    public class StakingApiParams
    {
        public string unbonding_time { get; set; }
        public int max_validators { get; set; }
        public int max_entries { get; set; }
        public int historical_entries { get; set; }
        public string bond_denom { get; set; }
    }
}
