using Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types;

namespace Terra.Microsoft.Rest.Tendermint.Blocks
{
    public class DuplicateVoteEvidenceVote
    {
        public string type { get; set; }
        public string height { get; set; }
        public int round { get; set; }
        public BlockInfo block_id { get; set; }
        public string timestamp { get; set; }
        public string validator_address { get; set; }
        public int validator_index { get; set; }
        public string signature { get; set; }
    }
}
