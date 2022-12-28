using Newtonsoft.Json;

namespace Terra.Microsoft.Rest.Tx.Transaction.Upload
{
    public class TxUploadValueJSON
    {
        [JsonProperty("@type")]
        public string type { get; set; }

        public TxUploadBodyJSON body { get; set; }
        public TxAuthInfo auth_info { get; set; }
        public string[] signatures { get; set; }
    }
}
