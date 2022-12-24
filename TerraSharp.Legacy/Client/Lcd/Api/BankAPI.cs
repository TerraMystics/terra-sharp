﻿using TerraSharp.Rest.Bank;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core;
using TerraSharp.Rest.Util;
using TerraSharp.Core.Extensions;
using TerraSharp.Rest;
using TerraSharp.Rest.Extensions;
using TerraSharp.Rest.Configuration.Environment;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    /// <summary>
    /// The bank module is the base transactional layer of the Terra blockchain. This module allows assets to be sent from one Account to another. The bank module defines the following types of send transactions: MsgSend and MsgMultiSend.
    /// </summary>
    public class BankAPI : BaseAPI
    {
        public BankAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        /// <summary>
        /// Gets the associated balance (total number of coins) available on the wallet address
        /// </summary>
        /// <param name="wallet">Wallet address to query the balance for</param>
        /// <param name="options">Used for filtering the results</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Coin[]> GetBalance(string wallet, PaginationOptions options = null)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_BANK_BALANCES, $"/{wallet}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<BankInfoApiJson>(rootPath);
            if (response.Successful)
            {
                return CoinsExtensions.FromJSON(response.Result.balances).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the banking information for wallet: {wallet}");
        }

        /// <summary>
        /// Gets the total balance of coins currently stored on the blockchain
        /// </summary>
        /// <param name="options">Used for filtering the results</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Coin[]> GetTotalSupply(PaginationOptions options = null)
        {
            string rootPath = string.Concat(TerraClientConfiguration.BlockchainResourcePath, CosmosBaseConstants.COSMOS_BANK_SUPPLY);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<BankInfoApiJson>(rootPath);
            if (response.Successful)
            {
                return CoinsExtensions.FromJSON(response.Result.supply).ToArray();
            }

            throw new ArgumentNullException($"Could not successfully fetch the supply information");
        }
    }
}
