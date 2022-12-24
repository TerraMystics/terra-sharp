using TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;

namespace TerraSharp.Rest.Tx.Block
{
    public class BlockTxBroadcastResult
    {
        public string tx_bytes { get; set; }
        public BroadcastMode mode { get; set; }
    }
}
