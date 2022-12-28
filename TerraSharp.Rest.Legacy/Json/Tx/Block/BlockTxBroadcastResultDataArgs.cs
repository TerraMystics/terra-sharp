using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Transaction;

namespace Terra.Microsoft.Rest.Tx.Block
{
    public class BlockTxBroadcastResultDataArgs : Block
    {
        public string Codespace { get; set; }
        public double Code { get; set; }

        public static BlockTxBroadcastResultDataArgs FromJSON(TxResponse json)
        {
            return new BlockTxBroadcastResultDataArgs()
            {
                Code = json.code,
                Codespace = json.codespace,
                Data = json.data,
                Gas_used = json.gas_used,
                Gas_wanted = json.gas_wanted,
                Height = json.height,
                Info = json.info,
                Raw_log = json.raw_log,
                Timestamp = TerraStringExtensions.GetISOStringFromDate(json.timestamp),
                Txhash = json.txhash
            };
        }
    }
}
