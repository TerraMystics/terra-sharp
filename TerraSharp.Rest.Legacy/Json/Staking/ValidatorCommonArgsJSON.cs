using System;
using TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;

namespace TerraSharp.Rest.Staking
{
    public class ValidatorCommonArgsJSON
    {
        public string operator_Address { get; set; }
        public bool jailed { get; set; }
        public string status { get; set; }
        public string tokens { get; set; }
        public string delegator_shares { get; set; }
        public string unbonding_Height { get; set; }
        public DateTime unbonding_Time { get; set; }
        public string min_Self_Delegation { get; set; }
    }
}
