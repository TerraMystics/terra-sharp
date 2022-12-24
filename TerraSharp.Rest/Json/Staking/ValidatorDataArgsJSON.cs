using TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;

namespace TerraSharp.Rest.Staking
{
    public class ValidatorDataArgsJSON : ValidatorCommonArgsJSON
    {
        public ValConsPublicKeyCommonArgsJSON consensus_pubkey { get; set; }
        public ValidatorDescriptionJSON description { get; set; }
        public CommissionCommonArgsJSON commission { get; set; }
    }
}
