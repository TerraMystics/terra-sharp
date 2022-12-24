using Newtonsoft.Json;
using TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxBodyJSON
    {
        public string memo { get; set; }
        public string timeout_height { get; set; }
        public TxBodyJSONMessages[] messages { get; set; }
    }

    public class TxBodyJSONMessages
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public int proposal_id { get; set; }
        public string depositor { get; set; }
        public string voter { get; set; }
        public string option { get; set; }
        public string salt { get; set; }
        public string exchange_rates { get; set; }
        public string feeder { get; set; }
        public string validator { get; set; }
        public string validator_address { get; set; }
        
        public string proposer { get; set; }
        public string delegator_address { get; set; }
        public string withdraw_address { get; set; }

        public string admin { get; set; }
        public string new_admin { get; set; }
        public string contract { get; set; }

        public WeightedOptionsJSON[] options { get; set; }

        public CoinJSON[] amount { get; set; }
        public CoinJSON[] initial_deposit { get; set; }
    }

    public class WeightedOptionsJSON
    {
        public string weight { get; set; }
        public string option { get; set; }
    }
}
