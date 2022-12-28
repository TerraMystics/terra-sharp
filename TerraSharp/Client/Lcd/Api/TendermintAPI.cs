using Terra.Microsoft.Rest.Tendermint.Blocks;
using Terra.Microsoft.Rest.Tendermint.Core;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using System.Threading.Tasks;
using System;
using Terra.Microsoft.Client.Client.Lcd.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class TendermintAPI : BaseAPI
    {
        public TendermintAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<NodeInfoCommonJSON> GetNodeInfo()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TENDERMINT_NODE_INFO);

            var response = await this.apiRequester.GetAsync<NodeInfoCommonJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<bool> GetSyncing()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TENDERMINT_SYNCING);

            var response = await this.apiRequester.GetAsync<SyncingJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.syncing;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<TendermintValidators[]> GetValidatorSet(double? height = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                height != null ?
                string.Concat(CosmosBaseConstants.COSMOS_TENDERMINT_VALIDATOR_SETS_BASE, $"/{height}") :
                CosmosBaseConstants.COSMOS_TENDERMINT_VALIDATOR_SETS_LATEST);

            var response = await this.apiRequester.GetAsync<TendermintAPICommonJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.validators;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<BlockContainer> GetBlockInfo(double? height)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                height != null ?
                string.Concat(CosmosBaseConstants.COSMOS_TENDERMINT_BLOCKS, $"/{height}") :
                CosmosBaseConstants.COSMOS_TENDERMINT_BLOCKS_LATEST);

            var response = await this.apiRequester.GetAsync<BlockContainer>(rootPath);
            if (response.Successful)
            {
                return response.Result;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }
}
