
namespace Terra.Microsoft.Rest
{
    public class UnbondingDelegationDataJSON
    {
        public UnbondingDelegationEntryValueCommonArgsJSON[] Entries { get; set; }
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
    }
}
