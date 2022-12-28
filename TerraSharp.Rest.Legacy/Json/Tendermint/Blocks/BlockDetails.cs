namespace Terra.Microsoft.Rest.Tendermint.Blocks
{
    public class BlockDetails
    {
        public BlockHeader header { get; set; }
        public BlockTxs data { get; set; }
        public BlockHeaderCommit last_commit { get; set; }
        public BlockEvidence evidence { get; set; }
    }
}
