using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core.IBC.Msgs.Client;
using TerraSharp.Rest.Util;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using TerraSharp.Rest.IBC;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    public class IBCAPI : BaseAPI
    {
        public IBCAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<string[]> GetParameters()
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath, CosmosBaseConstants.COSMOS_IBC_CLIENT_PARAMS);

            var response = await this.apiRequester.GetAsync<CommonIBCParamsJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params.allowed_clients;
            }

            throw new ArgumentNullException($"Could not successfully fetch the parameter information");
        }
        public async Task<IdentifiedClientState[]> GetClientStates(PaginationOptions options = null)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_CORE_CLIENT_CLIENTSTATES);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<CommonIBCParamsJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.client_states.ToList().ConvertAll(w => new IdentifiedClientState(w.client_id, w.client_state)).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the allowance information for grantee:");
        }
        public async Task<IdentifiedClientState> GetClientStateByID(string clientId)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_CORE_CLIENT_CLIENTSTATES, $"/{clientId}");

            var response = await this.apiRequester.GetAsync<IBCApiClientStates>(rootPath);
            if (response.Successful)
            {
                var w = response.Result;
                return new IdentifiedClientState(clientId, w.client_state);
            }

            throw new ArgumentNullException($"Could not successfully fetch the client state information for client Id: {clientId}");
        }
        public async Task<ClientConsensusStates[]> GetConsensusStateByID(string clientId, PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_CORE_CLIENT_CONSENSUS_STATES,
                $"/{clientId}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<CommonIBCParamsJson>(rootPath);
            if (response.Successful)
            {
                return response.Result.consensus_states.ToList().ConvertAll(
                    w => new ClientConsensusStates(clientId,
                    new ConsensusStateWithHeight[] { ConsensusStateWithHeight.FromJSON(w) })).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the client state information for client Id: {clientId}");
        }
        public async Task<string> GetClientStatusByID(string clientId)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_IBC_CORE_CLIENT_CLIENTSTATUS, $"/{clientId}");

            var response = await this.apiRequester.GetAsync<IBCApiClientStatus>(rootPath);
            if (response.Successful)
            {
                return response.Result.status;
            }

            throw new ArgumentNullException($"Could not successfully fetch the client state information for client Id: {clientId}");

        }
    }
}
