using Terra.Microsoft.Client.Client.Lcd.Api;

namespace Terra.Microsoft.Client.Client.Lcd
{
    /// <summary>
    /// 
    /// </summary>
    public class LCDClient
    {
        private readonly TxBroadcastApi tx_broadcast;
        public readonly TXAPI tx;
        public readonly AuthAPI auth;
        public readonly BankAPI bank;
        public readonly DistributionAPI distribution;
        public readonly FeeGrantAPI feeGrant;
        public readonly GovAPI gov;
        public readonly MarketAPI market;
        public readonly MintAPI mint;
        public readonly AuthzAPI authz;
        public readonly OracleAPI oracle;
        public readonly SlashingAPI slashing;
        public readonly StakingAPI staking;
        public readonly TendermintAPI tendermint;
        public readonly TreasuryAPI treasury;
        public readonly WasmAPI wasm;
        public readonly IBCTransferAPI ibcTransfer;
        public readonly IBCAPI ibc;

        public LCDClient(
            AuthAPI auth,
            BankAPI bank,
            DistributionAPI distribution,
            FeeGrantAPI feeGrant,
            GovAPI gov,
            MarketAPI market,
            MintAPI mint,
            AuthzAPI authz,
            OracleAPI oracle,
            SlashingAPI slashing,
            StakingAPI staking,
            TendermintAPI tendermint,
            TreasuryAPI treasury,
            WasmAPI wasm,
            TXAPI tx,
            TxBroadcastApi tx_broadcast,
            IBCTransferAPI ibcTransfer,
            IBCAPI ibc)
        {
            this.auth = auth;
            this.bank = bank;
            this.distribution = distribution;
            this.feeGrant = feeGrant;
            this.gov = gov;
            this.market = market;
            this.mint = mint;
            this.authz = authz;
            this.oracle = oracle;
            this.slashing = slashing;
            this.staking = staking;
            this.tendermint = tendermint;
            this.treasury = treasury;
            this.wasm = wasm;
            this.tx = tx;
            this.ibcTransfer = ibcTransfer;
            this.ibc = ibc;
            this.tx_broadcast = tx_broadcast;
        }

        /// <summary>
        /// Generates a new Wallet associated with a key
        /// </summary>
        /// <param name="walletAddress"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Wallet CreateWallet(string walletAddress, Key.Key key)
        {
            return new Wallet(this, key, walletAddress, this.tx_broadcast);
        }
    }
}
