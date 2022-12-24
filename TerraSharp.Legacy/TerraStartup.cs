using Ninject;
using System.Reflection;
using TerraSharp.Client.Lcd;
using TerraSharp.Client.LocalTerra;
using TerraSharp.Rest;
using TerraSharp.Rest.Classic;
using TerraSharp.Rest.Configuration;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Rest.Constants;
using TerraSharp.Rest.Util;

namespace TerraSharp
{
    /// <summary>
    /// Kernel Initializer 
    /// </summary>
    public static class TerraStartup
    {
        public static StandardKernel Kernel { get; set; }

        /// <summary>
        /// Call this method to configure & Initialise the library. 
        /// </summary>
        /// <param name="environment">Classic, LUNA2, Or Pisco</param>
        /// <param name="httpClientTimeout">Internal Http Client Timeout for Communicating with the blockchain before connection is closed</param>
        public static void InitializeKernel(TerraEnvironment environment, int httpClientTimeoutSeconds = 120)
        {
            Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());

            ConfigureTerraEnvironment(environment);
            HttpBehaviourConstants.DefaultHttpTimeoutSeconds = httpClientTimeoutSeconds;
        }

        public static LCDClient GetLCDClient()
        {
            return Kernel.Get<LCDClient>();
        }

        public static LocalTerra GetLocalTerraClient()
        {
            return Kernel.Get<LocalTerra>();
        }

        public static TerraRestfulService GetHttpHandler()
        {
            return Kernel.Get<TerraRestfulService>();
        }

        private static void ConfigureTerraEnvironment(TerraEnvironment environment)
        {
            TerraClientConfiguration.LCDConfig = new LCDClientConfig()
            {
                GasAdjustment = LCDDefaultConfigs.GAS_ADJUSTMENT,
            };

            switch (TerraClientConfiguration.Terra = environment)
            {
                case TerraEnvironment.LUNA2:
                    TerraClientConfiguration.BlockchainResourcePath = ResourceUrls.LUNA2_PROD_ROUTE;
                    TerraClientConfiguration.LCDConfig.ChainID = ChainKeys.TERRA_MAINNET_CHAINID;
                    break;
                case TerraEnvironment.Classic:
                    TerraClientConfiguration.IsClassicChain = true;
                    TerraClientConfiguration.BlockchainResourcePath = ClassicHttpResources.CLASSIC_COLUMBUS_MAINNET;
                    TerraClientConfiguration.LCDConfig.ChainID = ClassicChainKeys.CLASSIC_MAINNET;
                    break;
                case TerraEnvironment.ClassicTestNet:
                    TerraClientConfiguration.BlockchainResourcePath = ResourceUrls.TERRA_REBELS_TESTNET;
                    TerraClientConfiguration.LCDConfig.ChainID = ClassicChainKeys.TEST_NET;
                    break;
                case TerraEnvironment.LUNA2TestNet:
                    TerraClientConfiguration.BlockchainResourcePath = ResourceUrls.LUNA2_TESTNET;
                    TerraClientConfiguration.LCDConfig.ChainID = ChainKeys.TERRA_PISCO_TESTNET_CHAINID;
                    break;
                case TerraEnvironment.LocalTerra:
                    TerraClientConfiguration.BlockchainResourcePath = ResourceUrls.TERRA_LOCALTERRA_ROUTE;
                    TerraClientConfiguration.LCDConfig.ChainID = ChainKeys.TERRA_LOCAL_CHAINID;
                    break;
            }
        }
    }
}
