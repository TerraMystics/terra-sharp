using Newtonsoft.Json;
using System.Collections.Generic;

namespace Terra.Microsoft.Rest.Tx.Block
{
    public class TxLogDataEventArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public KeyValuePair<string, string>[] Attributes { get; set; }
    }
}
