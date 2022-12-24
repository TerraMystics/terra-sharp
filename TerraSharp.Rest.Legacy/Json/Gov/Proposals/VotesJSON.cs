using TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

namespace TerraSharp.Rest.Gov.Proposals
{
    public class VotesJSON
    {
        public int proposal_id { get; set; }
        public string voter { get; set; }
        public VoteOption option { get; set; }
        public VoteOptionJSON[] options { get; set; }
    }
}
