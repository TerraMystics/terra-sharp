namespace Terra.Microsoft.Rest.FeeGrant
{
    public class FeeGrantAllowancesJson
    {
        public string granter { get; set; }
        public string grantee { get; set; }
        public CommonTypeValueArgs allowance { get; set; }
    }

    public class FeeGrantAllowancesContainer
    {
        public FeeGrantAllowancesJson[] allowances { get; set; }
        public FeeGrantAllowancesJson allowance { get; set; }
    }
}
