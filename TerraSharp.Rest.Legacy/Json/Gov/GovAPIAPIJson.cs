using TerraSharp.Rest.FeeGrant;

namespace TerraSharp.Rest.Gov
{
    public class GovAPIAPIJson
    {
        public CoinJSON[] supply { get; set; }
        public FeeGrantAllowancesJson[] allowances { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
