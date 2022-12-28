using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1;

namespace Terra.Microsoft.Rest.Gov.Proposals
{
    public class VoteOptionJSON
    {
        public VoteOption option { get; set; }
        public string weight { get; set; }
    }
}
