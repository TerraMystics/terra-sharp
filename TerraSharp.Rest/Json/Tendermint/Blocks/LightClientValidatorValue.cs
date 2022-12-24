namespace TerraSharp.Rest.Tendermint.Blocks
{
    public class LightClientValidatorValue
    {
        public string address { get; set; }
        public PubKeyJSON pub_key { get; set; }
        public string voting_power { get; set; }
        public string proposer_priority { get; set; }
    }
}
