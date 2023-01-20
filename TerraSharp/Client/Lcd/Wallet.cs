using Terra.Microsoft.Rest.Configuration.Environment;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;
using Terra.Microsoft.Rest.Tx.Block;
using System.Threading.Tasks;
using System.Collections.Generic;
using Terra.Microsoft.Client.Client.Lcd.Api;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Keys;
using Terra.Microsoft.Client.Key;
using Terra.Microsoft.Client.Core.Extensions;

namespace Terra.Microsoft.Client.Client.Lcd
{
    /// <summary>
    /// 
    /// </summary>
    public class Wallet
    {
        private readonly LCDClient lcd;
        private readonly TxMnemonic key;

        /// <summary>
        /// Wallet address associated with the user
        /// </summary>
        public string accAddress;

        /// <summary>
        /// Service responsible for broadcasting transactions to the chain, calculating estimated Gas & Fees 
        /// </summary>
        public readonly TxBroadcastApi broadcastTx;

        public Wallet(
            LCDClient lcd,
            TxMnemonic key,
            string accAddress,
            TxBroadcastApi broadcastTx)
        {
            this.lcd = lcd;
            this.key = key;
            this.accAddress = accAddress;
            this.broadcastTx = broadcastTx;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<KeyValuePair<double, double>> GetAccountNumberAndSequence()
        {
            var response = await this.lcd.auth.GetAccountInfoWalletAddress(this.accAddress);
            return new KeyValuePair<double, double>(response.Account_number, response.Sequence);
        }

        private async Task<SignOptions> GetWalletOptions()
        {
            return new SignOptions()
            {
                SignMode = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1.SignMode.SignModeDirect,
                ChainId = TerraClientConfiguration.LCDConfig.ChainID,
                AccountNumber = await this.GetAccountNumber(),
                Sequence = await this.GetSequence()
            };
        }

        private async Task<KeyValuePair<Core.Tx, SignOptions>> CreateTx(
            Fee fee,
            string optionalNote = "")
        {
            var walletOptions = await GetWalletOptions();
            return new KeyValuePair<Tx, SignOptions>(await this.broadcastTx
                .CreateTx(fee, optionalNote), walletOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txAmount"></param>
        /// <param name="messages"></param>
        /// <param name="gasAdjustment"></param>
        /// <param name="coinTypeForGas"></param>
        /// <returns></returns>
        public async Task<double> EstimateGasForTx(
            object[] messages,
            double gasAdjustment = 1.1)
        {
            var walletOptions = await GetWalletOptions();

            var signedTx = await this.key.SignTx(new Tx(
            new TxBody(null, "Running Gas Estimation", 0),
                 new AuthInfo(new List<SignerInfo>() { }, new Fee(0, new List<Coin>() { })),
                 new List<string>()
                 ), walletOptions, messages);

            return await this.broadcastTx.EstimateGas(signedTx, gasAdjustment, messages);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txAmount"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Fee> EstimateFeeForTx(CreateTxOptions options)
        {
            return EnviromentExtensions.IsLuna2() ?
                await this.broadcastTx.EstimatedFeeWithoutBurnTax(options) :
                await this.broadcastTx.EstimatedFeeWithBurnTax(options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<double> GetAccountNumber()
        {
            var response = await this.lcd.auth.GetAccountInfoWalletAddress(this.accAddress);
            return response.Account_number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<double> GetSequence()
        {
            var response = await this.lcd.auth.GetAccountInfoWalletAddress(this.accAddress);
            return response.Sequence;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="messages"></param>
        /// <returns></returns>
        public async Task<PROTO.Tx> CreateTxAndSignTx(
            Fee fee,
            object[] messages,
            string optionalNote = "")
        {
            var tx = await CreateTx(fee, optionalNote);
            return (await this.key.SignTx(tx.Key, tx.Value, messages)).ToProtoWithType(messages);
        }
    }
}
