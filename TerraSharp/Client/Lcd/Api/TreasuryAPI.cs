using Terra.Microsoft.Rest.Treasury;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using System.Threading.Tasks;
using System.Linq;
using System;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Client.Client.Lcd.Constants;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class TreasuryAPI : BaseAPI
    {
        public TreasuryAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }
        public async Task<Coin[]> GetTaxCaps()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_TAX_CAPS);

            var response = await this.apiRequester.GetAsync<TreasuryTaxCap>(rootPath);
            if (response.Successful)
            {
                return response.Result.tax_caps.ToList().ConvertAll(w => new Coin(w.denom, double.Parse(w.tax_cap))).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<double> GetTaxCap(string denom)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_TAX_CAPS, $"/{denom}");

            var response = await this.apiRequester.GetAsync<TreasuryTaxCap>(rootPath);
            if (response.Successful)
            {
                return double.Parse(response.Result.tax_cap);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<double> GetTaxRate()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_TAX_RATE);

            var response = await this.apiRequester.GetAsync<TreasuryTaxCap>(rootPath);
            if (response.Successful)
            {
                return double.Parse(response.Result.tax_rate);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<double> GetRewardWeight()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_REWARD_WEIGHT);

            var response = await this.apiRequester.GetAsync<TreasuryTaxCap>(rootPath);
            if (response.Successful)
            {
                return double.Parse(response.Result.reward_weight);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<double> GetTaxProceeds()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_REWARD_WEIGHT);

            var response = await this.apiRequester.GetAsync<TreasuryRewardWeight>(rootPath);
            if (response.Successful)
            {
                return double.Parse(response.Result.reward_weight);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<Coin> SeigniorageProceeds()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_Seigniorage_Proceeds);

            var response = await this.apiRequester.GetAsync<TreasuryTaxSeignorage>(rootPath);
            if (response.Successful)
            {
                return new Coin(CoinDenoms.ULUNA, double.Parse(response.Result.seigniorage_proceeds));
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<TreasuryTaxPolicy> GetParameters()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_TREASURY_Params);

            var response = await this.apiRequester.GetAsync<TreasuryParamsJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<DenomGasPrices> GetGasPrices()
        {
            var response = await this.apiRequester.GetAsync<DenomGasPrices>(CosmosBaseConstants.GAS_PRICES);
            if (response.Successful)
            {
                return response.Result;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<double> GetGasPriceForDenom(string feeDenom)
        {
            return CoinGasPrices.GetGasPriceForDenom(feeDenom, await GetGasPrices());
        }

    }
}
