namespace Terra.Microsoft.Rest.Tendermint.Blocks
{
    public class LightClientAttackEvidenceConflictingBlock
    {
        public BlockHeader signed_header { get; set; }
        public LightClientValidator validator_set { get; set; }
    }
}
