using System;

namespace Terra.Microsoft.Rest.Tx.Transaction
{
    public class TxResponse
    {
        public long height { get; set; }
        public string txhash { get; set; }
        public string codespace { get; set; }
        public int code { get; set; }
        public string data { get; set; }
        public string raw_log { get; set; }
        public TxInfoLogsJSON[] logs { get; set; }
        public string info { get; set; }
        public long gas_wanted { get; set; }
        public long gas_used { get; set; }
        public TxValueJSON tx { get; set; }
        public DateTime timestamp { get; set; }
        public TxInfoEvent[] events { get; set; }

    }
}
