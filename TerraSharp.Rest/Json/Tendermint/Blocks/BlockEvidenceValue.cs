namespace TerraSharp.Rest.Tendermint.Blocks
{
    public class BlockEvidenceValue
    {
        public DuplicateVoteEvidence duplicate_vote_evidence { get; set; }
        public LightClientAttackEvidence light_client_attack_evidence { get; set; }
    }
}
