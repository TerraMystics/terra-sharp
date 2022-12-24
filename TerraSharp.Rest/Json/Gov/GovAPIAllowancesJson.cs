namespace TerraSharp.Rest.Gov
{
    public class GovAPIAllowancesJson
    {
        public string granter { get; set; }
        public string grantee { get; set; }
        public CommonTypeValueArgs allowance { get; set; }
    }
}
