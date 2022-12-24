namespace TerraSharp.Rest.Tx.Block
{
    public class TxLogDataArgs
    {
        public double MsgIndex { get; set; }
        public string Log { get; set; }
        public TxLogDataEventArgs[] Events { get; set; }
    }
}
