using TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;
using TerraSharp.Rest.Tx.Transaction.Response;

namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxContainerJSON
    {
        public string mode { get; set; }
        public TxGasInfoResponse gas_info { get; set; }
        public string tx_bytes { get; set; }
        public TxValueJSON tx { get; set; }
        public TxValueJSON[] txs { get; set; }
        public TxResponse tx_response { get; set; }

    }


}
