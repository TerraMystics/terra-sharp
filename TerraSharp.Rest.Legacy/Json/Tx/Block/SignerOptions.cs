using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.ProtoBufs.proto.keys;

namespace Terra.Microsoft.Rest.Tx.Block
{
    public class SignerOptions
    {
        public string Address { get; set; }
        public double? SequenceNumber { get; set; }
    }
}
