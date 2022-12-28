namespace Terra.Microsoft.Rest.Configuration.Environment
{
    public static class TerraClientConfiguration
    {
        public static bool IsClassicChain { get; set; }
        public static string BlockchainResourcePath { get; set; }
        public static TerraEnvironment Terra { get; set; }
        public static LCDClientConfig LCDConfig { get; set; }
    }
}
