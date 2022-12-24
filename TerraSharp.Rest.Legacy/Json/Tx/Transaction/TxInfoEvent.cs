using Newtonsoft.Json;

namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxInfoEvent
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public TxInfoAttributes[] attributes { get; set; }
    }
}
