using Newtonsoft.Json;

namespace Terra.Microsoft.Rest.Tx.Transaction
{
    public class TxValueJSON
    {
        [JsonProperty("@type")]
        public string type { get; set; }

        public TxBodyJSON body { get; set; }
        public TxAuthInfo auth_info { get; set; }
        public string[] signatures { get; set; }
    }
}
