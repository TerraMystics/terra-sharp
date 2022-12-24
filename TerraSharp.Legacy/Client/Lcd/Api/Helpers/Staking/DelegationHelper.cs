using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Rest.Util;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using TerraSharp.Rest.Staking;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api.Helpers.Staking
{
    internal static class DelegationHelper
    {
        public async static Task<StakingDelegationResponse[]> GetDelegationsForAllValuesReady(
            this TerraRestfulService apiRequester,
            string delegator,
            string validator,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                  TerraClientConfiguration.BlockchainResourcePath,
                  CosmosBaseConstants.COSMOS_STAKING_VALIDATORS_BASE,
                  $"/{validator}/{CosmosStakingConstants.DELEGATIONS}/{delegator}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.delegation_responses;
            }

            throw new ArgumentNullException($"");
        }

        public async static Task<StakingDelegationResponse[]> GetDelegationsForDelegatorsOnly(
            this TerraRestfulService apiRequester,
            string delegator,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                  TerraClientConfiguration.BlockchainResourcePath,
                  CosmosBaseConstants.COSMOS_STAKING_DELEGATIONS_BASE, $"/{delegator}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.delegation_responses;
            }

            throw new ArgumentNullException($"");
        }
        public async static Task<StakingDelegationResponse[]> GetDelegationsForValidatorsOnly(
            this TerraRestfulService apiRequester,
            string validator,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
               TerraClientConfiguration.BlockchainResourcePath,
               CosmosBaseConstants.COSMOS_STAKING_VALIDATORS_BASE,
               $"/{validator}/{CosmosStakingConstants.DELEGATIONS}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.delegation_responses;
            }

            throw new ArgumentNullException($"");
        }
    }
}
