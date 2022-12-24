using TerraSharp.Rest.IBCTransfer;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core.IBCTransfer;
using TerraSharp.Rest.Util;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api
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
