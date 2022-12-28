using Newtonsoft.Json;

namespace Terra.Microsoft.Rest.Staking
{
    public class ValConsPublicKeyCommonArgsJSON
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public string key { get; set; }
    }
}
