using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Rest.Util;
using TerraSharp.Rest.Auth;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    /// <summary>
    /// Terra's Auth module extends the functionality from Cosmos SDK's auth module with a modified ante handler, which applies basic transaction validity checks, such as signatures, nonces, and auxiliary fields. This module also defines a special vesting account type that handles the logic for token vesting from the Luna presale.
    /// </summary>
    public class AuthAPI : BaseAPI
    {
        public AuthAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        /// <summary>
        /// Gets Account Information associated with the wallet address
        /// </summary>
        /// <param name="walletAddress">Wallet address in Bech32 format</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<AccountDto> GetAccountInfoWalletAddress(string walletAddress)
        {
            string root = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_AUTH_ACCOUNTS, $"/{walletAddress}");
            var response = await this.apiRequester.GetAsync<AccountDtoContainer>(root);
            if (response.Successful)
            {
                return response.Result.Account;
            }

            throw new ArgumentNullException($"Could not successfully fetch the account information for wallet address: {walletAddress}");
        }
    }
}
