namespace Terra.Microsoft.Rest.Tendermint.Blocks
{
    public class DuplicateVoteEvidence
    {
        public DuplicateVoteEvidenceVote vote_a { get; set; }
        public DuplicateVoteEvidenceVote vote_b { get; set; }

        public string total_voting_power { get; set; }
        public string validator_power { get; set; }
        public string timestamp { get; set; }
    }
}
