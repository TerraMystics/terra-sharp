using TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

namespace TerraSharp.Rest.Gov.Proposals
{
    public class VoteOptionJSON
    {
        public VoteOption option { get; set; }
        public string weight { get; set; }
    }
}
