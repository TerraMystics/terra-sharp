using Google.Protobuf.WellKnownTypes;
using TerraSharp.Core.Keys;
using TerraSharp.Core.Keys.Constants;

namespace TerraSharp.Core
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
