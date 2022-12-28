namespace Terra.Microsoft.Rest.Staking
{
    public class UnbondingDelegationJSON
    {
        public UnbondingDelegationDataJSON unbond { get; set; }
        public UnbondingDelegationDataJSON[] unbonding_responses { get; set; }
    }
}
