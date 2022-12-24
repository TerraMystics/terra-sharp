namespace TerraSharp.Rest.Tendermint.Blocks
{
    public class LightClientValidator
    {
        public LightClientValidatorValue[] validators { get; set; }
        public LightClientProposor proposer { get; set; }
        public string total_voting_power { get; set; }
    }
}
