namespace TerraSharp.Rest.Staking
{
    public class StakingDelegationResponse
    {
        public DelegationValueDataJSON delegation { get; set; }
        public CoinJSON balance { get; set; }
    }
}
