using Terra.Microsoft.Rest.Mint;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using System.Threading.Tasks;
using System;
using Terra.Microsoft.Client.Client.Lcd.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class MintAPI : BaseAPI
    {
        public MintAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<decimal> GetInflation()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_MINT_INFLATION);

            var response = await this.apiRequester.GetAsync<MintApiInflationArgs>(rootPath);
            if (response.Successful)
            {
                return decimal.Parse(response.Result.inflation);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<decimal> GetAnnualProvisions()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_MINT_ANNUAL_PROVISIONS);

            var response = await this.apiRequester.GetAsync<MintApiAnnualProvisionsArgs>(rootPath);
            if (response.Successful)
            {
                return decimal.Parse(response.Result.annual_provisions);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<MintParamsApiValueApi> GetMintParameters()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_MINT_PARAMS);

            var response = await this.apiRequester.GetAsync<MintParamsApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }
}
