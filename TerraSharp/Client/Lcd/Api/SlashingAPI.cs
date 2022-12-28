using Terra.Microsoft.Rest.Slashing;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using System.Threading.Tasks;
using System;
using Terra.Microsoft.Client.Client.Lcd.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class SlashingAPI : BaseAPI
    {
        public SlashingAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<SlashingApiSigningInfo> GetSigningInfo(string valConsAddress)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_SLASHING_SIGNING_INFO,
                $"/{valConsAddress}");

            var response = await this.apiRequester.GetAsync<SlashingApiCommonApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.val_signing_info;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<SlashingApiSigningInfo[]> GetSigningInfos()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_SLASHING_SIGNING_INFO);

            var response = await this.apiRequester.GetAsync<SlashingApiCommonApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.info;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<SlashingApiSigningInfoParams> GetSigningParameters()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_SLASHING_PARAMS);

            var response = await this.apiRequester.GetAsync<SlashingApiCommonApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }
}
