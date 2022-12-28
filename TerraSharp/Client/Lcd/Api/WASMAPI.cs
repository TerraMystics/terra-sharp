using Terra.Microsoft.Rest.Wasm;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using System;
using System.Threading.Tasks;
using Terra.Microsoft.Client.Client.Lcd.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class WasmAPI : BaseAPI
    {
        public WasmAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }
        public async Task<WasmCodeInfo> GetCodeInfo(double codeID)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_WASM_CODES, $"/{codeID}");

            var response = await this.apiRequester.GetAsync<WasmContainer>(rootPath);
            if (response.Successful)
            {
                return response.Result.code_info;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<WasmContractInfo> GetContractInfo(string contractAddress)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_WASM_CONTRACTS,
                $"/{contractAddress}");

            var response = await this.apiRequester.GetAsync<WasmContainer>(rootPath);
            if (response.Successful)
            {
                return response.Result.contract_info;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<string> GetContractQuery(string contractAddress)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_WASM_CONTRACTS,
                $"/{contractAddress}/store");

            var response = await this.apiRequester.GetAsync<WasmContainer>(rootPath);
            if (response.Successful)
            {
                return response.Result.query_result;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<WasmParams> GetParameters()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_WASM_PARAMS);

            var response = await this.apiRequester.GetAsync<WasmContainer>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }
}
