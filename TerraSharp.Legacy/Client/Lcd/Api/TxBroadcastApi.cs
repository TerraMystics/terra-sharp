using TerraNetExtensions.StringExt;
using TerraSharp.Rest.Tx.Transaction;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core;
using TerraSharp.Rest.Util;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;
using TerraSharp.Rest.Converters;
using TerraSharp.Core.Constants;
using TerraSharp.Rest.Tx.Transaction.Upload;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace TerraSharp.Client.Lcd.Api
{
    public class TxBroadcastApi : BaseAPI
    {
        private readonly TreasuryAPI treasury;
        public TxBroadcastApi(
          TerraRestfulService apiRequester,
          TreasuryAPI treasury) : base(apiRequester)
        {
            this.treasury = treasury;
        }

        private string Encode(PROTO.Tx tx)
        {
            return TerraStringExtensions.GetBase64FromBytes(ProtoExtensions.SerialiseFromData(tx));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signers"></param>
        /// <param name="options"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        public async Task<Fee> EstimatedFeeWithBurnTax(
            double txAmount,
            CreateTxOptions options)
        {
            var feeDenom = options.feeDenom ?? CoinDenoms.UUSD;

            var gasAdjs = options.gasAdjustment ?? TerraClientConfiguration.LCDConfig.GasAdjustment.Value;
            var burnTax = await this.treasury.GetTaxRate();
            var taxCap = await this.treasury.GetTaxCap(feeDenom);

            var gasLimit = await this.treasury.GetGasPriceForDenom(feeDenom);
            var gas = options.gas;

            var estimatedGas = (gas * gasAdjs);
            var totalGas = estimatedGas * gasLimit;
            var taxTotal = Math.Min((txAmount * burnTax), taxCap);

            var totalFeeWithBurnTax = (long)Math.Ceiling((decimal)(taxTotal + totalGas));

            return new Fee(gas.Value, new List<Coin>() { new Coin(feeDenom, totalFeeWithBurnTax) });
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="tx"></param>
        ///// <param name="options"></param>
        ///// <returns></returns>
        ///// <exception cref="InvalidOperationException"></exception>
        public async Task<double> EstimateGas(Core.Tx simTx, double? gasAdjustment, object[] messages)
        {
            var gasAdjs = gasAdjustment ?? TerraClientConfiguration.LCDConfig.GasAdjustment.Value;

            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath, CosmosBaseConstants.COSMOS_TX_ESTIMATE_GAS_USAGE);

            var dataEncoded = simTx.ToProtoWithType(messages);
            string data = this.Encode(dataEncoded);
            var response = await this.apiRequester.PostAsync(rootPath,
                new TxUploadContainerJSON()
                {
                    tx_bytes = data
                });
            if (response.Successful)
            {
                return gasAdjs * double.Parse(response.Result.gas_info.gas_used);
            }

            throw new InvalidOperationException("cannot append signature");
        }

        public async Task<Core.Tx> CreateTx(
            Fee fee,
            string memo = "")
        {
            return new Tx(
                 new TxBody(null, memo, 0),
                 new AuthInfo(new List<SignerInfo>() { }, fee),
                 new List<string>() { }
                 );
        }

        private async Task<TxResponse> BroadcastShared(PROTO.Tx tx, PROTO.BroadcastMode mode)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TX_TXS);

            var data = this.Encode(tx);
            var response = await this.apiRequester.PostAsync(rootPath, new TxContainerJSON()
            {
                mode = BroadcastModeConverter.GetFromEnum(mode),
                tx_bytes = data
            });

            if (response.Successful)
            {
                return response.Result.tx_response;
            }

            throw new ArgumentNullException($"");
        }

        public async Task<BlockTxBroadcastResultDataArgs> Broadcast(PROTO.Tx tx)
        {
            return BlockTxBroadcastResultDataArgs.FromJSON(await this.BroadcastShared(tx, PROTO.BroadcastMode.BroadcastModeBlock));
        }
        public async Task<BlockTxBroadcastResultDataArgs> BroadcastSync(PROTO.Tx tx)
        {
            return BlockTxBroadcastResultDataArgs.FromJSON(await this.BroadcastShared(tx, PROTO.BroadcastMode.BroadcastModeSync));
        }
        public async Task<BlockTxBroadcastResultDataArgs> BroadcastAsync(PROTO.Tx tx)
        {
            return BlockTxBroadcastResultDataArgs.FromJSON(await this.BroadcastShared(tx, PROTO.BroadcastMode.BroadcastModeAsync));
        }
    }
}
