namespace Terra.Microsoft.Rest.Staking
{
    public class StakingDelegationResponse
    {
        public DelegationValueDataJSON delegation { get; set; }
        public CoinJSON balance { get; set; }
    }
}
