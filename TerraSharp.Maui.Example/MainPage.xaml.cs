using TerraSharp.Core.Bank.Msgs;
using TerraSharp.Core.Constants;
using TerraSharp.Key;
using Terra.Microsoft.Rest.Tx.Block;

namespace TerraSharp.Maui.Example
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
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
                var mnemonic = new MnemonicKey("notice oak worry limit wrap speak medal online prefer cluster " +
                    "roof addict wrist behave treat actual wasp year salad speed social layer crew genius", true);

                // Define the recipient address
                var rAddr = "terra17lmam6zguazs5q5u6z5mmx76uj63gldnse2pdp";

                //// Define your wallet -- The account that will handle the transactions
                var wallet = TerraStartup.GetLCDClient().CreateWallet("terra1x46rqay4d3cssq8gxxvqz8xt6nwlz4td20k38v", mnemonic);

                var send = new MsgSend(
                  wallet.accAddress,
                  rAddr,
                   new List<Core.Coin>() { new Core.Coin(CoinDenoms.ULUNA, 20) });

                var msgs = new object[] { send };

                var gas = await wallet.EstimateGasForTx(10000000, msgs);
                var feeEstimate = await wallet.EstimateFeeForTx(10000000, new CreateTxOptions()
                {
                    gas = gas,
                    feeDenom = CoinDenoms.ULUNA,
                    gasAdjustment = 3,
                });

                var txAfterGas = await wallet.CreateTxAndSignTx(
                        feeEstimate,
                        msgs);

                var broadcast = await wallet.broadcastTx.Broadcast(txAfterGas);

                System.Diagnostics.Debug.WriteLine("Uploaded Tx Hash" + broadcast.Txhash);
            });
        }
    }
}
