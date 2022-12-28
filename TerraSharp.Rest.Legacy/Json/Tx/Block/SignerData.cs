using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.ProtoBufs.proto.keys;
using Terra.Microsoft.Rest.Tx.Transaction;

namespace Terra.Microsoft.Rest.Tx.Block
{
    public class SignerData
    {
        public double SequenceNumber { get; set; }
        public KeysDto PublicKey { get; set; }

        public SignerData[] ToArray()
        {
            return new SignerData[] { this };
        }

        public static SignerData FromKey(double sequenceNumber, KeysDto key)
        {
            return new SignerData()
            {
                PublicKey = key,
                SequenceNumber = sequenceNumber
            };
        }
    }
}
