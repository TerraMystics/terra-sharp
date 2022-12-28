namespace Terra.Microsoft.Rest.Staking
{
    public class StakingCommonJson
    {
        public StakingApiParams @params { get; set; }
        public StakingPoolJSON pool { get; set; }
        public ValidatorDataArgsJSON[] validators { get; set; }
        public RedelegationResponseJSON[] redelegation_responses { get; set; }
        public StakingDelegationResponse[] delegation_responses { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
