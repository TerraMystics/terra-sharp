using Terra.Microsoft.Keys;

namespace Terra.Microsoft.Client.Core
{
    public class ValidatorSet
    {
        public DelegateValidator[] Validators { get; set; }
    }

    public class DelegateValidator
    {
        public string Address { get; set; }
        public ValConsPublicKeyDataArgs PubKey { get; set; }
        public string ProposerPriority { get; set; }
        public string VotingPower { get; set; }
    }
}
