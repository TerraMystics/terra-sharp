using Terra.Microsoft.Rest.IBCTransfer;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using Terra.Microsoft.Rest;
using Terra.Microsoft.Rest.Extensions;
using System.Linq;
using System.Threading.Tasks;
using System;
using Terra.Microsoft.Client.Core.IBCTransfer;
using Terra.Microsoft.Client.Client.Lcd.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class IBCTransferAPI : BaseAPI
    {
        public IBCTransferAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<DenomTrace> GetDenomTrace(string hash)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_APPS_TRANSFER_DENOM_TRACES, $"/{hash}");

            var response = await this.apiRequester.GetAsync<IBCTransferCommonJson>(rootPath);
            if (response.Successful)
            {
                return DenomTrace.FromJSON(response.Result.denom_trace);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<DenomTrace[]> GetDenomTraces(PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_APPS_TRANSFER_DENOM_TRACES);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<IBCTransferCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.denom_traces.ToList().ConvertAll(w => DenomTrace.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<IBCTransferParams> GetParameters()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_APPS_TRANSFER_PARAMS);

            var response = await this.apiRequester.GetAsync<IBCTransferCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }

}
