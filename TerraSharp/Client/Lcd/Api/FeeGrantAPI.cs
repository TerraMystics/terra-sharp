using Terra.Microsoft.Rest.FeeGrant;
using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using Terra.Microsoft.Rest;
using Terra.Microsoft.Rest.Extensions;
using System.Threading.Tasks;
using System;
using Terra.Microsoft.Client.Core.Feegrant.Allowances;
using Terra.Microsoft.Client.Client.Lcd.Constants;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api
{
    public class FeeGrantAPI : BaseAPI
    {
        public FeeGrantAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="walletGrantee"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<FeeGrantAllowancesJson[]> GetAllowances(string walletGrantee, PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_FEEGRANT_ALLOWANCES,
                $"/{walletGrantee}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<FeeGrantAllowancesContainer>(rootPath);
            if (response.Successful)
            {
                return response.Result.allowances;
            }

            throw new ArgumentNullException($"Could not successfully fetch the allowance information for grantee: {walletGrantee}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="walletGrantee"></param>
        /// <param name="walletGranter"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<PeriodicAllowance> GetPeriodicAllowance(string walletGrantee, string walletGranter)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_FEEGRANT_ALLOWANCE,
                $"/{walletGranter}/{walletGrantee}");

            var response = await this.apiRequester.GetAsync<FeeGrantAllowancesContainer>(rootPath);
            if (response.Successful)
            {
                var result = response.Result.allowance;

                return PeriodicAllowance.FromData(new PeriodicAllowanceDataArgs()
                {
                    Period_can_spend = new CoinDataArgs[] { new CoinDataArgs() { Amount = double.Parse(result.allowance.Value), Denom = CoinDenoms.ULUNA } }
                });
            }

            throw new ArgumentNullException($"Could not successfully fetch the supply information");
        }

        public async Task<BasicAllowance> GetBasicAllowance(string walletGrantee, string walletGranter)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_FEEGRANT_ALLOWANCE,
                $"/{walletGranter}/{walletGrantee}");

            var response = await this.apiRequester.GetAsync<FeeGrantAllowancesContainer>(rootPath);
            if (response.Successful)
            {
                var result = response.Result.allowance;
                return BasicAllowance.FromData(new BasicAllowanceDataArgs()
                {
                    Spend_Limit = new CoinDataArgs[] { new CoinDataArgs() { Amount = double.Parse(result.allowance.Value), Denom = CoinDenoms.ULUNA } }
                });
            }

            throw new ArgumentNullException($"Could not successfully fetch the supply information");
        }
    }
}

