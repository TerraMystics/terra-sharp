using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;
using Terra.Microsoft.Rest.Tx.Transaction.Response;

namespace Terra.Microsoft.Rest.Tx.Transaction
{
    public class TxContainerJSON
    {
        public string mode { get; set; }
        public TxGasInfoResponse gas_info { get; set; }
        public string tx_bytes { get; set; }
        public PROTO.Tx tx { get; set; }
        public TxValueJSON[] txs { get; set; }
        public TxResponse tx_response { get; set; }

    }


}
