using Terra.Microsoft.Rest.Oracle;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using System.Threading.Tasks;
using System;
using System.Linq;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Client.Client.Lcd.Constants;
using Terra.Microsoft.Client.Core.Extensions;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class OracleAPI : BaseAPI
    {
        public OracleAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<Coin[]> GetExchangeRates()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_ORACLE_DENOMS_EXCHANGE_RATES);

            var response = await this.apiRequester.GetAsync<OracleApiExchangeRatesApi>(rootPath);
            if (response.Successful)
            {
                return CoinsExtensions.FromJSON(response.Result.exchange_rates).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<Coin> GetExchangeRate(string denom)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_ORACLE_DENOMS,
                $"/{denom}/{CosmosOracleConstants.EXCHANGE_RATE}");

            var response = await this.apiRequester.GetAsync<OracleApiExchangeRateApi>(rootPath);
            if (response.Successful)
            {
                return Coin.FromData(new CoinDataArgs()
                {
                    Amount = double.Parse(response.Result.exchange_rate),
                    Denom = denom
                });
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<string[]> GetActiveDenoms()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_ORACLE_DENOMS_ACTIVES);

            var response = await this.apiRequester.GetAsync<OracleApiExchangeRateActivesApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.actives;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<string> GetFeederAddress(string validator)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_ORACLE_VALIDATORS,
                $"/{validator}/{CosmosOracleConstants.FEEDER}");

            var response = await this.apiRequester.GetAsync<OracleApiValidatorApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.feeder_addr;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<string> GetMisses(string validator)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_ORACLE_VALIDATORS,
                $"/{validator}/{CosmosOracleConstants.MISS}");

            var response = await this.apiRequester.GetAsync<OracleApiValidatorApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.miss_counter;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }
}
