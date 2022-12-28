using Ninject.Modules;
using Terra.Microsoft.Client.Client.Lcd;
using Terra.Microsoft.Client.Client.Lcd.Api;
using Terra.Microsoft.Client.Client.LocalTerra;

namespace Terra.Microsoft.Client.Modules
{
    public class TerraSharpCosmosModule : NinjectModule
    {
        public override void Load()
        {
            // Services
            this.InitializeClientLcdApis();
            this.LCDClientInit();
        }

        private void LCDClientInit()
        {
            this.Bind<LCDClient>().To<LCDClient>().InSingletonScope();
            this.Bind<LocalTerra>().To<LocalTerra>().InSingletonScope();
        }

        private void InitializeClientLcdApis()
        {
            // Api Configuration
            this.Bind<AuthAPI>().To<AuthAPI>().InSingletonScope();
            this.Bind<AuthzAPI>().To<AuthzAPI>().InSingletonScope();
            this.Bind<BankAPI>().To<BankAPI>().InSingletonScope();
            this.Bind<BaseAPI>().To<BaseAPI>().InSingletonScope();
            this.Bind<DistributionAPI>().To<DistributionAPI>().InSingletonScope();
            this.Bind<FeeGrantAPI>().To<FeeGrantAPI>().InSingletonScope();
            this.Bind<GovAPI>().To<GovAPI>().InSingletonScope();
            this.Bind<IBCAPI>().To<IBCAPI>().InSingletonScope();
            this.Bind<IBCTransferAPI>().To<IBCTransferAPI>().InSingletonScope();
            this.Bind<MarketAPI>().To<MarketAPI>().InSingletonScope();
            this.Bind<MintAPI>().To<MintAPI>().InSingletonScope();
            this.Bind<OracleAPI>().To<OracleAPI>().InSingletonScope();
            this.Bind<SlashingAPI>().To<SlashingAPI>().InSingletonScope();
            this.Bind<StakingAPI>().To<StakingAPI>().InSingletonScope();
            this.Bind<TendermintAPI>().To<TendermintAPI>().InSingletonScope();
            this.Bind<TreasuryAPI>().To<TreasuryAPI>().InSingletonScope();
            this.Bind<TXAPI>().To<TXAPI>().InSingletonScope();
            this.Bind<TxBroadcastApi>().To<TxBroadcastApi>().InSingletonScope();
            this.Bind<WasmAPI>().To<WasmAPI>().InSingletonScope();
        }
    }
}