﻿
using Newtonsoft.Json;
using Terra.Microsoft.Client;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Client.Core.Bank.Msgs;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Key;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Block;

namespace TerraSharp.Maui.Example
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            TerraStartup.InitializeKernel(Terra.Microsoft.Rest.Configuration.Environment.TerraEnvironment.ClassicTestNet);
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
                    "roof addict wrist behave treat actual wasp year salad speed social layer crew genius", true);

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

                System.Diagnostics.Debug.WriteLine($"PRIVATE KEY: {TerraStringExtensions.GetBase64FromBytes(mnemonic.privateKeyExposed)}");
                System.Diagnostics.Debug.WriteLine($"PUBLIC KEY: {TerraStringExtensions.GetBase64FromBytes(mnemonic.publicKey.key)}");
                System.Diagnostics.Debug.WriteLine($"TX PISCO: {txAfterGas.Signatures[0]}");
                System.Diagnostics.Debug.WriteLine($"KEY FOR PISCO: wFHapTwCZ2z9nTGpRQ8QHdoUPju+4q9ejObAtqlkD9IwS8gF/GM8QgmrFdgoCenbT0X92HEGheYeNDqnUyTFvw==");

                var broadcast = await wallet.broadcastTx.Broadcast(txAfterGas);

                System.Diagnostics.Debug.WriteLine($"JSON: \n {JsonConvert.SerializeObject(txAfterGas)}");
                System.Diagnostics.Debug.WriteLine("Uploaded Tx Hash" + broadcast.Txhash);
            });
        }
    }
}
