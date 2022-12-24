namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxInfoLogsJSON
    {
        public int msg_index { get; set; }
        public string log { get; set; }
        public TxInfoEvent[] events { get; set; }
    }
}
