using Google.Protobuf.WellKnownTypes;
using TerraProto.CSharp.proto.keys;

namespace TerraSharp.Rest.Tx.Block
{
    public class SignerOptions
    {
        public string Address { get; set; }
        public double? SequenceNumber { get; set; }
    }
}
