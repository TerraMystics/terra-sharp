
using Newtonsoft.Json;
using Terra.Microsoft.Client;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Client.Core.Bank.Msgs;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Key;
using Terra.Microsoft.Rest.Tx.Block;

namespace TerraSharp.Maui.Example
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            TerraStartup.InitializeKernel(Terra.Microsoft.Rest.Configuration.Environment.TerraEnvironment.LUNA2TestNet);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {

                //Name = "test2",
                //Address = "terra17lmam6zguazs5q5u6z5mmx76uj63gldnse2pdp",
                //Pubkey = "terrapub1addwnpepqdw9s9agjmw4fgntfuytd2x7qha94zlvv0edntkt7g3amz4wg75ewy9755w",
                //Mnemonic = "quality vacuum heart guard buzz spike sight swarm shove special gym robust assume sudden deposit grid alcohol choice devote leader tilt noodle tide penalty"

                // Create a key out of a mnemonic
                var mnemonic = new TxMnemonic("notice oak worry limit wrap speak medal online prefer cluster " +
                    "roof addict wrist behave treat actual wasp year salad speed social layer crew genius");

                // Define the recipient address
                var rAddr = "terra17lmam6zguazs5q5u6z5mmx76uj63gldnse2pdp";

                //// Define your wallet -- The account that will handle the transactions
                ///
                string test = mnemonic.AccAddress;
                var wallet = TerraStartup.GetLCDClient().CreateWallet(mnemonic);

                var send = new MsgSend(
                  wallet.accAddress,
                  rAddr,
                   new List<Coin>() { new Coin(CoinDenoms.ULUNA, 100) });

                var msgs = new object[] { send };

                var gas = await wallet.EstimateGasForTx(msgs);
                var feeEstimate = await wallet.EstimateFeeForTx(new CreateTxOptions()
                {
                    gas = gas,
                    feeDenom = CoinDenoms.ULUNA,
                });

                var txAfterGas = await wallet.CreateTxAndSignTx(
                        feeEstimate,
                        msgs);

                var broadcast = await wallet.broadcastTx.Broadcast(txAfterGas);

                System.Diagnostics.Debug.WriteLine($"JSON: \n {JsonConvert.SerializeObject(txAfterGas)}");
                System.Diagnostics.Debug.WriteLine("Uploaded Tx Hash" + broadcast.Txhash);
            });
        }
    }
}
