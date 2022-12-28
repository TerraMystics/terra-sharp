namespace Terra.Microsoft.Rest.Tx.Block
{
    public class Block
    {
        public double Height { get; set; }
        public string Txhash { get; set; }
        public string Raw_log { get; set; }
        public double Gas_wanted { get; set; }
        public double Gas_used { get; set; }
        public string Data { get; set; }
        public TxLogDataArgs[] Logs { get; set; }
        public string Timestamp { get; set; }
        public string Info { get; set; }

    }
}
