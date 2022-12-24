﻿using Newtonsoft.Json;

namespace TerraSharp.Rest.Tx.Block
{
    public class TxLogDataEventArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public KeyValuePair<string, string>[] Attributes { get; set; }
    }
}
