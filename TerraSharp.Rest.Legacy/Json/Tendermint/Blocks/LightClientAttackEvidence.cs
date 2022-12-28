using System;

namespace Terra.Microsoft.Rest.Tendermint.Blocks
{
    public class LightClientAttackEvidence
    {
        public LightClientAttackEvidenceConflictingBlock conflicting_block { get; set; }
        public string total_voting_power { get; set; }
        public string common_height { get; set; }
        public DateTime timestamp { get; set; }
        public LightClientValidator[] byzantine_validators { get; set; }
    }
}
