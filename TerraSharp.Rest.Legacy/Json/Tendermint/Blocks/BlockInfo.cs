namespace TerraSharp.Rest.Tendermint.Blocks
{
    public class BlockInfo
    {
        public string hash { get; set; }
        public BlockPartHeader part_set_header { get; set; }
    }
}
