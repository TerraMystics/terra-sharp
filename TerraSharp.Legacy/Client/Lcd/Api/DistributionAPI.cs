using TerraSharp.Rest.Distribution;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core;
using TerraSharp.Core.Extensions;
using TerraSharp.Rest.Util;
using TerraSharp.Client.Lcd.Api.Args.Distribution;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    public class DistributionAPI : BaseAPI
    {
        public DistributionAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        /// <summary>
        /// Gets the total rewards accrued by a each validator.
        /// </summary>
        /// <param name="delegator"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Rewards[]> GetRewards(string delegator)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_DISTRIBUTION_DELEGATORS, $"/{delegator}/{CosmosDistributionResources.REWARDS}");

            var response = await this.apiRequester.GetAsync<DistributionRewardsInfoJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.rewards.ToList().ConvertAll(w => new Rewards()
                {
                    RewardsItems = CoinsExtensions.FromJSON(w.reward).ToArray(),
                    Validator_address = w.validator_address
                }).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the banking information for delegator {delegator}");
        }

        /// <summary>
        /// Gets the accumulated commission for a validator
        /// </summary>
        /// <param name="validator">Validator address in Bech32 form</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Coin[]> GetValidatorCommission(string validator)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_DISTRIBUTION_VALIDATORS, $"/{validator}/{CosmosDistributionResources.COMMISSION}");

            var response = await this.apiRequester.GetAsync<CommissionInfoApiJson>(rootPath);
            if (response.Successful)
            {
                return CoinsExtensions.FromJSON(response.Result.commission.commission).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the banking information for validator {validator}");
        }

        /// <summary>
        /// Gets the withdraw address of a delegator
        /// </summary>
        /// <param name="delegator">Delegator address to query with address for</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<string> GetWithdrawAddress(string delegator)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_DISTRIBUTION_DELEGATORS, $"/{delegator}/{CosmosDistributionResources.WITHDRAW_ADDRESS}");

            var response = await this.apiRequester.GetAsync<DistributionWithDrawInfoJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.withdraw_address;
            }

            throw new ArgumentNullException($"Could not successfully fetch the withdraw address for delegator {delegator}");
        }

        /// <summary>
        /// Gets the total supply of coins in the community pool
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Coin[]> GetCommunityPool()
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath, CosmosBaseConstants.COSMOS_DISTRIBUTION_COMMUNITY_POOL);

            var response = await this.apiRequester.GetAsync<DistributionInfoApiJson>(rootPath);
            if (response.Successful)
            {
                return CoinsExtensions.FromJSON(response.Result.pool).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the coins in the community pool");
        }

        /// <summary>
        /// Queries the params of the distribution module
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<DistributionParamsInfoJson> GetParams()
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath, CosmosBaseConstants.COSMOS_DISTRIBUTION_PARAMS);

            var response = await this.apiRequester.GetAsync<DistributionInfoApiJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch parameter information");
        }
    }
}
