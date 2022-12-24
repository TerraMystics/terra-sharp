using Newtonsoft.Json;

namespace TerraSharp.Rest.IBC
{
    public class IBCApiConsensusState
    {
        public HeightJSON height { get; set; }
        public ConsensusStateJSON consensus_state { get; set; }
    }

    public class ConsensusStateJSON
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public DateTime timestamp { get; set; }
        public ConsensusRoot root { get; set; }
        public string next_validators_hash { get; set; }
    }
    public class ConsensusRoot
    {
        public string hash { get; set; }
    }
}
