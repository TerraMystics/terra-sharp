using TerraSharp.Rest.Tx.Transaction;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Rest.Util;
using System.Threading.Tasks;
using System.Linq;
using System;
using TerraNetExtensions.ChainExtensions;

namespace TerraSharp.Client.Lcd.Api
{
    public class TXAPI : BaseAPI
    {
        public TXAPI(
            TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<TxResponse> GetTxInfo(string txHash)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TX_TXS,
                $"/{txHash}");

            var response = await this.apiRequester.GetAsync<TxContainerJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.tx_response;
            }

            throw new ArgumentNullException($"");
        }

        public async Task<string[]> GetTxHashesByBlockHeight(double? height)
        {
            var blockInfo = await TerraStartup.GetLCDClient().tendermint.GetBlockInfo(height);
            var txs = blockInfo.block.data;
            if (txs == null)
            {
                return null;
            }
            else
            {
                return txs.txs.ToList().ConvertAll(w => HashExtensionsLegacy.HashToHex(w)).ToArray();
            }
        }
    }
}
