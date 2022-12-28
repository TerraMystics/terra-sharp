namespace Terra.Microsoft.Rest.Tendermint.Core
{
    public class TendermintAPICommonJSON
    {
        public string block_height { get; set; }
        public TendermintValidators[] validators { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
