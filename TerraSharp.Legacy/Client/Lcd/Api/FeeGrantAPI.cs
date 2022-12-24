using TerraSharp.Rest.FeeGrant;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Rest.Util;
using TerraSharp.Core.Feegrant.Allowances;
using TerraSharp.Core;
using TerraSharp.Core.Constants;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api
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

