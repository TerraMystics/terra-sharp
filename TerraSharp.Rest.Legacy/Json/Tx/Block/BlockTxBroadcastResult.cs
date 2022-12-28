using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;

namespace Terra.Microsoft.Rest.Tx.Block
{
    public class BlockTxBroadcastResult
    {
        public string tx_bytes { get; set; }
        public BroadcastMode mode { get; set; }
    }
}
