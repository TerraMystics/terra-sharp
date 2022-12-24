﻿using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Api;
using TerraSharp.Core;
using TerraSharp.Core.Constants;
using TerraSharp.Key;
using KEY = TerraSharp.Key;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;
using TerraSharp.Rest.Tx.Block;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TerraSharp.Client.Lcd
{
    /// <summary>
    /// 
    /// </summary>
    public class Wallet
    {
        private readonly LCDClient lcd;
        private readonly KEY.Key key;

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
            KEY.Key key,
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
                SignMode = TerraProto.CSharp.third_party.proto.cosmos.tx.signing.v1beta1.SignMode.SignModeDirect,
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

            return new KeyValuePair<Tx, SignOptions>(
                await this.broadcastTx.CreateTx(fee, optionalNote),
                walletOptions);
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
            double txAmount,
            object[] messages,
            double gasAdjustment = 3,
            string coinTypeForGas = CoinDenoms.ULUNA)
        {
            var walletOptions = await GetWalletOptions();
            var gasLimit = await this.lcd.treasury.GetGasPriceForDenom(coinTypeForGas);

            var signedTx = await this.key.SignTx(new Tx(
            new TxBody(null, "Running Gas Estimation", 0),
                 new AuthInfo(new List<SignerInfo>() { }, new Fee(gasLimit, new List<Coin>() { new Coin(coinTypeForGas, txAmount) })),
                 new List<string>() { }
                 ), walletOptions, messages);

            return await this.broadcastTx.EstimateGas(signedTx, gasAdjustment, messages);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txAmount"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Fee> EstimateFeeForTx(
            double txAmount,
            CreateTxOptions options)
        {
            return await this.broadcastTx.EstimatedFeeWithBurnTax(txAmount, options);
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
