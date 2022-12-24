using TerraSharp.Rest.Staking;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Api.Helpers.Staking;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core.Staking;
using TerraSharp.Rest.Util;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    public class StakingAPI : BaseAPI
    {
        public StakingAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<Delegation[]> GetDelegations(string delegator = "", string validator = "", PaginationOptions options = null)
        {
            if (!string.IsNullOrWhiteSpace(delegator) && !string.IsNullOrWhiteSpace(validator))
            {
                return (await this.apiRequester.GetDelegationsForAllValuesReady(delegator, validator, options)).ToList().ConvertAll(w => Delegation.FromJSON(w)).ToArray();
            }
            else if (!string.IsNullOrWhiteSpace(delegator) && string.IsNullOrWhiteSpace(validator))
            {
                return (await this.apiRequester.GetDelegationsForDelegatorsOnly(delegator, options)).ToList().ConvertAll(w => Delegation.FromJSON(w)).ToArray();
            }
            else if (string.IsNullOrWhiteSpace(delegator) && !string.IsNullOrWhiteSpace(validator))
            {
                return (await this.apiRequester.GetDelegationsForValidatorsOnly(validator, options)).ToList().ConvertAll(w => Delegation.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"arguments delegator and validator cannot both be empty");
        }

        public async Task<UnbondingDelegation[]> GetUnbondingDelegation(
            string delegator,
            string validator)
        {
            if (!string.IsNullOrWhiteSpace(delegator) && !string.IsNullOrWhiteSpace(validator))
            {
                var response = await this.apiRequester.GetUnbondingDelegationsForAllValuesReady(delegator, validator);
                return new UnbondingDelegation[] { response };
            }
            else if (!string.IsNullOrWhiteSpace(delegator) && string.IsNullOrWhiteSpace(validator))
            {
                return await this.apiRequester.GetUnbondingDelegationsForDelegatorsOnly(delegator);
            }
            else if (string.IsNullOrWhiteSpace(delegator) && !string.IsNullOrWhiteSpace(validator))
            {
                return await this.apiRequester.GetUnbondingDelegationsForValidatorsOnly(delegator);
            }

            throw new ArgumentNullException($"arguments delegator and validator cannot both be empty");
        }

        public async Task<UnbondingDelegation> GetUnbondingDelegations(
            string delegator,
            string validator,
            PaginationOptions options = null)
        {
            return await this.apiRequester.GetUnbondingDelegationsForAllValuesReady(delegator, validator, options);
        }

        public async Task<RedelegationResponseJSON[]> GetRedelegations(
            string delegator,
            string validatorSrc,
            string validatorDst,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                   TerraClientConfiguration.BlockchainResourcePath,
                   CosmosBaseConstants.COSMOS_STAKING_DELEGATORS_BASE,
                   $"/{delegator}/{CosmosStakingConstants.REDELEGATIONS}?src_validator_addr={validatorSrc}&dst_validator_addr={validatorDst}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.redelegation_responses;
            }

            throw new ArgumentNullException($"");
        }

        public async Task<Validator[]> GetBondedValidators(string delegator, PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                   TerraClientConfiguration.BlockchainResourcePath,
                   CosmosBaseConstants.COSMOS_STAKING_DELEGATORS_BASE,
                   $"/{delegator}/{CosmosStakingConstants.VALIDATORS}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.validators.ToList().ConvertAll(w => Validator.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"");
        }

        public async Task<Validator[]> GetValidators(PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                     TerraClientConfiguration.BlockchainResourcePath,
                     CosmosBaseConstants.COSMOS_STAKING_VALIDATORS_BASE);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.validators.ToList().ConvertAll(w => Validator.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"");
        }

        public async Task<Validator> GetValidator(string validator)
        {
            string rootPath = string.Concat(
                     TerraClientConfiguration.BlockchainResourcePath,
                     CosmosBaseConstants.COSMOS_STAKING_VALIDATORS_BASE, $"/{validator}");

            var response = await apiRequester.GetAsync<ValidatorDataArgsJSONContainer>(rootPath);
            if (response.Successful)
            {
                return Validator.FromJSON(response.Result.validator);
            }

            throw new ArgumentNullException($"");
        }

        public async Task<StakingPoolJSON> GetStakingPool()
        {
            string rootPath = string.Concat(
                     TerraClientConfiguration.BlockchainResourcePath,
                     CosmosBaseConstants.COSMOS_STAKING_POOL);

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.pool;
            }

            throw new ArgumentNullException($"");
        }

        public async Task<StakingApiParams> GetStakingParameters()
        {
            string rootPath = string.Concat(
                     TerraClientConfiguration.BlockchainResourcePath,
                     CosmosBaseConstants.COSMOS_STAKING_PARAMS);

            var response = await apiRequester.GetAsync<StakingCommonJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"");
        }
    }
}
