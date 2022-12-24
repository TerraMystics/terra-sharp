namespace TerraSharp.Rest.Tendermint.Blocks
{
    public class BlockHeaderCommit
    {
        public string height { get; set; }
        public int round { get; set; }
        public BlockInfo block_id { get; set; }
        public BlockSignatures[] signatures { get; set; }
    }
}
