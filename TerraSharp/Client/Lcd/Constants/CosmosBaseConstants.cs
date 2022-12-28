namespace Terra.Microsoft.Client.Client.Lcd.Constants
{
    internal class CosmosBaseConstants
    {
        //AUTH
        public const string COSMOS_AUTH_ACCOUNTS = "/cosmos/auth/v1beta1/accounts";
        public const string COSMOS_AUTHZ_GRANTS = "/cosmos/authz/v1beta1/grants";

        //BANK
        public const string COSMOS_BANK_BALANCES = "/cosmos/bank/v1beta1/balances";
        public const string COSMOS_BANK_SUPPLY = "/cosmos/bank/v1beta1/supply";

        // DISTRIBUTION
        public const string COSMOS_DISTRIBUTION_DELEGATORS = "/cosmos/distribution/v1beta1/delegators";
        public const string COSMOS_DISTRIBUTION_VALIDATORS = "/cosmos/distribution/v1beta1/validators";
        public const string COSMOS_DISTRIBUTION_COMMUNITY_POOL = "/cosmos/distribution/v1beta1/community_pool";
        public const string COSMOS_DISTRIBUTION_PARAMS = "/cosmos/distribution/v1beta1/params";

        public const string COSMOS_FEEGRANT_ALLOWANCES = "/cosmos/feegrant/v1beta1/allowances";
        public const string COSMOS_FEEGRANT_ALLOWANCE = "/cosmos/feegrant/v1beta1/allowance";

        // GOV
        public const string COSMOS_GOV_PROPOSALS = "/cosmos/gov/v1beta1/proposals";
        public const string COSMOS_GOV_PARAMS_DEPOSIT = "/cosmos/gov/v1beta1/params/deposit";
        public const string COSMOS_GOV_PARAMS_VOTING = "/cosmos/gov/v1beta1/params/voting";
        public const string COSMOS_GOV_PARAMS_TALLYING = "/cosmos/gov/v1beta1/params/tallying";

        //TX
        public const string COSMOS_TX_TXS = "/cosmos/tx/v1beta1/txs";
        public const string COSMOS_TX_ESTIMATE_GAS_USAGE = "/cosmos/tx/v1beta1/simulate";
        public const string COSMOS_TX_ESTIMATE_GAS_FEE = "/terra/tx/v1beta1/compute_tax";


        //IBC
        public const string COSMOS_IBC_CLIENT_PARAMS = "/ibc/client/v1/params";
        public const string COSMOS_IBC_CORE_CLIENT_CLIENTSTATES = "/ibc/core/client/v1/client_states";
        public const string COSMOS_IBC_CORE_CLIENT_CLIENTSTATUS = "/ibc/core/client/v1/client_status";

        public const string COSMOS_IBC_CORE_CLIENT_CONSENSUS_STATES = "/ibc/core/client/v1/consensus_states";
        public const string COSMOS_IBC_APPS_TRANSFER_DENOM_TRACES = "/ibc/apps/transfer/v1/denom_traces";
        public const string COSMOS_IBC_APPS_TRANSFER_PARAMS = "/ibc/apps/transfer/v1/params";

        //Market
        public const string COSMOS_MARKET_SWAP = "/terra/market/v1beta1/swap";
        public const string COSMOS_MARKET_TERRA_POOL_DELTA = "/terra/market/v1beta1/terra_pool_delta";
        public const string COSMOS_MARKET_PARAMS = "/terra/market/v1beta1/params";

        // Minting
        public const string COSMOS_MINT_INFLATION = "/cosmos/mint/v1beta1/inflation";
        public const string COSMOS_MINT_ANNUAL_PROVISIONS = "/cosmos/mint/v1beta1/annual_provisions";
        public const string COSMOS_MINT_PARAMS = "/cosmos/mint/v1beta1/params";

        //Oracle
        public const string COSMOS_ORACLE_DENOMS_EXCHANGE_RATES = "/terra/oracle/v1beta1/denoms/exchange_rates";
        public const string COSMOS_ORACLE_DENOMS = "/terra/oracle/v1beta1/denoms";
        public const string COSMOS_ORACLE_DENOMS_ACTIVES = "/terra/oracle/v1beta1/denoms/actives";
        public const string COSMOS_ORACLE_VALIDATORS = "/terra/oracle/v1beta1/validators";
        public const string COSMOS_ORACLE_PARAMS = "/terra/oracle/v1beta1/params";

        //Slashing
        public const string COSMOS_SLASHING_SIGNING_INFO = "/cosmos/slashing/v1beta1/signing_infos";
        public const string COSMOS_SLASHING_PARAMS = "/cosmos/slashing/v1beta1/params";

        //Staking
        public const string COSMOS_STAKING_VALIDATORS_BASE = "/cosmos/staking/v1beta1/validators";
        public const string COSMOS_STAKING_DELEGATIONS_BASE = "/cosmos/staking/v1beta1/delegations";
        public const string COSMOS_STAKING_DELEGATORS_BASE = "/cosmos/staking/v1beta1/delegators";

        public const string COSMOS_STAKING_POOL = "/cosmos/staking/v1beta1/pool";
        public const string COSMOS_STAKING_PARAMS = "/cosmos/staking/v1beta1/params";

        // Tendermint
        public const string COSMOS_TENDERMINT_NODE_INFO = "/cosmos/base/tendermint/v1beta1/node_info";
        public const string COSMOS_TENDERMINT_SYNCING = "/cosmos/base/tendermint/v1beta1/syncing";
        public const string COSMOS_TENDERMINT_VALIDATOR_SETS_BASE = "/cosmos/base/tendermint/v1beta1/validatorsets";
        public const string COSMOS_TENDERMINT_VALIDATOR_SETS_LATEST = "/cosmos/base/tendermint/v1beta1/validatorsets/latest";
        public const string COSMOS_TENDERMINT_BLOCKS = "/cosmos/base/tendermint/v1beta1/blocks";
        public const string COSMOS_TENDERMINT_BLOCKS_LATEST = "/cosmos/base/tendermint/v1beta1/blocks/latest";

        // Treasury
        public const string COSMOS_TREASURY_TAX_CAPS = "/terra/treasury/v1beta1/tax_caps";
        public const string COSMOS_TREASURY_TAX_RATE = "/terra/treasury/v1beta1/tax_rate";
        public const string COSMOS_TREASURY_REWARD_WEIGHT = "/terra/treasury/v1beta1/reward_weight";
        public const string COSMOS_TREASURY_TAX_PROCEEDS = "/terra/treasury/v1beta1/tax_proceeds";
        public const string COSMOS_TREASURY_Seigniorage_Proceeds = "/terra/treasury/v1beta1/seigniorage_proceeds";
        public const string COSMOS_TREASURY_Params = "/terra/treasury/v1beta1/params";

        // Wasm
        public const string COSMOS_WASM_CODES = "/terra/wasm/v1beta1/codes";
        public const string COSMOS_WASM_CONTRACTS = "/terra/wasm/v1beta1/contracts";
        public const string COSMOS_WASM_PARAMS = "/terra/wasm/v1beta1/params";

        // Gas Prices
        public const string GAS_PRICES = "https://fcd.terra.dev/v1/txs/gas_prices";
    }
}
