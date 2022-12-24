using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core.Staking;
using TerraSharp.Rest.Util;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using TerraSharp.Rest.Staking;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api.Helpers.Staking
{
    internal static class UnbondingDelegationHelper
    {
        public async static Task<UnbondingDelegation> GetUnbondingDelegationsForAllValuesReady(
            this TerraRestfulService apiRequester,
            string delegator,
            string validator,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                  TerraClientConfiguration.BlockchainResourcePath,
                  CosmosBaseConstants.COSMOS_STAKING_VALIDATORS_BASE,
                  $"/{validator}/{CosmosStakingConstants.DELEGATIONS}/{delegator}/{CosmosStakingConstants.UNBONDING_DELEGATION}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<UnbondingDelegationJSON>(rootPath);
            if (response.Successful)
            {
                return UnbondingDelegation.FromJSON(response.Result.unbond);
            }

            throw new ArgumentNullException($"");
        }

        public async static Task<UnbondingDelegation[]> GetUnbondingDelegationsForDelegatorsOnly(
            this TerraRestfulService apiRequester,
            string delegator,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                 TerraClientConfiguration.BlockchainResourcePath,
                 CosmosBaseConstants.COSMOS_STAKING_DELEGATORS_BASE,
                 $"/{delegator}/{CosmosStakingConstants.UNBONDING_DELEGATIONS}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<UnbondingDelegationJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.unbonding_responses.ToList().ConvertAll(w => UnbondingDelegation.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"");
        }

        public async static Task<UnbondingDelegation[]> GetUnbondingDelegationsForValidatorsOnly(
            this TerraRestfulService apiRequester,
            string validator,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
               TerraClientConfiguration.BlockchainResourcePath,
            CosmosBaseConstants.COSMOS_STAKING_VALIDATORS_BASE,
               $"/{validator}/{CosmosStakingConstants.UNBONDING_DELEGATIONS}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<UnbondingDelegationJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.unbonding_responses.ToList().ConvertAll(w => UnbondingDelegation.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"");
        }
    }
}
