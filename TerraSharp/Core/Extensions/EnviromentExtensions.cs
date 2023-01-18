using Terra.Microsoft.Rest.Configuration.Environment;

namespace Terra.Microsoft.Client.Core.Extensions
{
    public static class EnviromentExtensions
    {
        public static bool IsLuna2() => (TerraClientConfiguration.Terra == TerraEnvironment.LUNA2 ||
                TerraClientConfiguration.Terra == TerraEnvironment.LUNA2TestNet);
    }
}
