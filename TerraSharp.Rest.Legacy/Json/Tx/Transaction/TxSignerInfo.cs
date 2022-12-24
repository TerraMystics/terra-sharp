using TerraProto.CSharp.proto.keys;

namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxSignerInfo
    {
        public KeysDto public_key { get; set; }
        public TxSignerModeInfo mode_info { get; set; }
        public double sequence { get; set; }
    }
}
