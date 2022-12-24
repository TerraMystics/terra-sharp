using Newtonsoft.Json;
using TerraProto.CSharp.proto.keys;

namespace TerraSharp.Rest.Auth
{
    public class AccountDto
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Address { get; set; }
        public KeysDto Pub_key { get; set; }
        public int Account_number { get; set; }
        public int Sequence { get; set; }
    }
}
