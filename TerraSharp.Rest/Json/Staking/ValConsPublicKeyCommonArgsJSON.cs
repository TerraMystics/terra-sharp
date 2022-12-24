using Newtonsoft.Json;

namespace TerraSharp.Rest.Staking
{
    public class ValConsPublicKeyCommonArgsJSON
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public string key { get; set; }
    }
}
