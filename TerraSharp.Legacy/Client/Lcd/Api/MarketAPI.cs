﻿using TerraSharp.Rest.Marketing;
using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Core;
using TerraSharp.Rest.Util;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Client.Lcd.Api
{
    public class MarketAPI : BaseAPI
    {
        public MarketAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        public async Task<Coin> GetSwapRate(Coin offerCoin, string askDenom)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_MARKET_SWAP, $"?offer_coin={offerCoin.amount}{offerCoin.denom}&ask_denom={askDenom}");

            var response = await this.apiRequester.GetAsync<MarketingSwaps>(rootPath);
            if (response.Successful)
            {
                return Coin.FromJSON(response.Result.return_coin);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }

        public async Task<decimal> GetPoolDelta()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_MARKET_TERRA_POOL_DELTA);

            var response = await this.apiRequester.GetAsync<MarketingApiPoolDelta>(rootPath);
            if (response.Successful)
            {
                return decimal.Parse(response.Result.terra_pool_delta);
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
        public async Task<MarketingParamsValueApi> GetMarketingParameters()
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_MARKET_PARAMS);

            var response = await this.apiRequester.GetAsync<MarketingParamsApi>(rootPath);
            if (response.Successful)
            {
                return response.Result.@params;
            }

            throw new ArgumentNullException($"Could not successfully fetch the");
        }
    }
}
