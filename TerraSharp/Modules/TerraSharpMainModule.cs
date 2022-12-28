using Ninject.Modules;
using Terra.Microsoft.Rest.Configuration;
using Terra.Microsoft.Rest.Util;

namespace Terra.Microsoft.Client.Modules
{
    public class TerraSharpMainModule : NinjectModule
    {
        public override void Load()
        {
            this.InitializeHttpServices();
            this.CommonServices();
        }

        private void InitializeHttpServices()
        {
            // Http Services
            this.Bind<TerraHttpClientService>().To<TerraHttpClientService>().InSingletonScope();
            this.Bind<TerraRestfulService>().To<TerraRestfulService>().InSingletonScope();

            TerraHttpClientFactory.InitializeClientFactory(); // HttpClientFactory
            TerraStartup.GetHttpHandler().PrepareHttpClientFromConsumer(TerraHttpClientFactory.GetHttpClientFromFactory()); // Prepare a Singleton of the HttpClient
        }

        private void CommonServices()
        {
            //   this.Bind<WebSocketClientService>().To<WebSocketClientService>().InSingletonScope();
        }
    }
}