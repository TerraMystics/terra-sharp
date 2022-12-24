using Ninject.Modules;
using TerraSharp.Rest.Configuration;
using TerraSharp.Rest.Util;

namespace TerraSharp.Modules
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