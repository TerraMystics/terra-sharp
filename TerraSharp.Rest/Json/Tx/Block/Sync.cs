namespace TerraSharp.Rest.Tx.Block
{
    public class Sync
    {
        public double Height { get; set; }
        public string Txhash { get; set; }
        public string Raw_log { get; set; }
    }
}
