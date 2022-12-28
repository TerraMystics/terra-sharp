using Newtonsoft.Json;

namespace Terra.Microsoft.Rest.Tx.Transaction
{
    public class TxInfoEvent
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public TxInfoAttributes[] attributes { get; set; }
    }
}
