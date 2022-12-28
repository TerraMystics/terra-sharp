using Newtonsoft.Json;

namespace Terra.Microsoft.Rest.IBC
{
    public class IBCApiClientStates
    {
        public string client_id { get; set; }
        public string proof { get; set; }
        public HeightJSON proof_height { get; set; }
        public IBCApiClientStatesValue client_state { get; set; }
    }

    public class IBCApiClientStatesValue
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public string chain_id { get; set; }
        public TrustLevel trust_level { get; set; }
        public string trusting_period { get; set; }
        public string unbonding_period { get; set; }
        public string max_clock_drift { get; set; }

    }

    public class TrustLevel
    {
        public int numerator { get; set; }
        public int denominator { get; set; }

    }
}
