namespace Terra.Microsoft.Rest.Distribution
{
    public class DistributionInfoApiJson
    {
        public DistributionParamsInfoJson @params { get; set; }
        public CoinJSON[] pool { get; set; }
        public CoinJSON[] supply { get; set; }

        public PaginationJson pagination { get; set; }
    }
}
