using System.Collections.Generic;
using Terra.Microsoft.Client.Client.Lcd.Api;
using Terra.Microsoft.Client.Client.Lcd;
using Terra.Microsoft.Client.Key;

namespace Terra.Microsoft.Client.Client.LocalTerra
{
    /// <summary>
    /// Local Terra Client: Can be used for testing locally or against the Testnet (LUNA2, LUNC, or USTC)
    /// </summary>
    public class LocalTerra : LCDClient
    {
        /// <summary>
        /// Test wallets that can be used for testing
        /// </summary>
        public List<Wallet> Wallets { get; set; }

        public LocalTerra(
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
            IBCAPI ibc) : base(auth, bank, distribution, feeGrant, gov, market,
                mint, authz, oracle, slashing, staking, tendermint, treasury, wasm, tx, tx_broadcast, ibcTransfer, ibc)
        {
            //Wallets = new List<Wallet>() {
            //    CreateWallet(LocalTerraMnemonics.Validator.Address,new MnemonicKey(LocalTerraMnemonics.Validator.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test1.Address,new MnemonicKey(LocalTerraMnemonics.Test1.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test2.Address,new MnemonicKey(LocalTerraMnemonics.Test2.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test3.Address,new MnemonicKey(LocalTerraMnemonics.Test3.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test4.Address,new MnemonicKey(LocalTerraMnemonics.Test4.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test5.Address,new MnemonicKey(LocalTerraMnemonics.Test5.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test6.Address,new MnemonicKey(LocalTerraMnemonics.Test6.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test7.Address,new MnemonicKey(LocalTerraMnemonics.Test7.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test8.Address,new MnemonicKey(LocalTerraMnemonics.Test8.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test9.Address,new MnemonicKey(LocalTerraMnemonics.Test9.Mnemonic)),
            //    CreateWallet(LocalTerraMnemonics.Test10.Address,new MnemonicKey(LocalTerraMnemonics.Test10.Mnemonic)),
            //};
        }
    }
}
