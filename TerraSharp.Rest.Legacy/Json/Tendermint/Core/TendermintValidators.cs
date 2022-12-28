namespace Terra.Microsoft.Rest.Tendermint.Core
{
    public class TendermintValidators
    {
        public string address { get; set; }
        public CommonTypeValueArgs pub_key { get; set; }
        public string voting_power { get; set; }
        public string proposer_priority { get; set; }
    }
}
