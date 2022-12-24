using TerraSharp.Rest.Authz;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Rest.Util;
using TerraSharp.Core.Authz.Authorizations;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    /// <summary>
    /// The authz (message authorization) module allows users to authorize another account to send messages on their behalf. Certain authorizations, such as the spending of another account's tokens, can be parameterized to constrain the permissions of the grantee, such as setting a spending limit.
    /// </summary>
    public class AuthzAPI : BaseAPI
    {
        public AuthzAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        /// <summary>
        /// Gets the grants that are provided authorization to the grantee on the granter's account during the provided time period
        /// </summary>
        /// <param name="walletGranter">Wallet address of the Granter</param>
        /// <param name="walletGrantee">Wallet address of the Grantee</param>
        /// <param name="msgTypeUrl">MsgType associated with the authorization </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<AuthorizationGrant[]> GetAuthorizationGrants(
            string walletGranter,
            string walletGrantee,
            string msgTypeUrl = "")
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath, CosmosBaseConstants.COSMOS_AUTHZ_GRANTS);

            string getPath = string.Concat(rootPath, $"?granter={walletGranter}&grantee={walletGrantee}");
            if (!string.IsNullOrWhiteSpace(msgTypeUrl))
            {
                getPath += $"&msg_type_url={msgTypeUrl}";
            }

            var response = await this.apiRequester.GetAsync<AuthorizationGrantsJSON>(getPath);
            if (response.Successful)
            {
                return response.Result.grants.ToList().ConvertAll(grant =>
                new AuthorizationGrant(grant.authorization, grant.expiration)).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the authorization information for wallet granter: {walletGranter}");
        }
    }
}
