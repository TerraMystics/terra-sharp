namespace Terra.Microsoft.Rest.FeeGrant
{
    public class FeeGrantAPIJson
    {
        public CoinJSON[] supply { get; set; }
        public FeeGrantAllowancesJson[] allowances { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
