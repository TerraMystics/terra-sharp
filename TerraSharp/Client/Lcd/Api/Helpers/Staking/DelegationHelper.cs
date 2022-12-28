using Terra.Microsoft.Rest.Configuration.Environment;
using Terra.Microsoft.Rest.Util;
using Terra.Microsoft.Rest;
using Terra.Microsoft.Rest.Extensions;
using Terra.Microsoft.Rest.Staking;
using System.Threading.Tasks;
using System;
using Terra.Microsoft.Client.Client.Lcd.Constants;

namespace Terra.Microsoft.Client.Client.Lcd.Api.Helpers.Staking
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
