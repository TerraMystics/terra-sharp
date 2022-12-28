namespace Terra.Microsoft.Rest.Staking
{
    public class RedelegationResponseValueJSON
    {
        public string delegator_address { get; set; }
        public string validator_src_address { get; set; }
        public string validator_dst_address { get; set; }
        public UnbondingDelegationEntryValueCommonArgsJSON[] entries { get; set; }
    }
}
