using Terra.Microsoft.Rest.FeeGrant;

namespace Terra.Microsoft.Rest.Gov
{
    public class GovAPIAPIJson
    {
        public CoinJSON[] supply { get; set; }
        public FeeGrantAllowancesJson[] allowances { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
