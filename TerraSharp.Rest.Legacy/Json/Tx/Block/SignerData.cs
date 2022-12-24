using Google.Protobuf.WellKnownTypes;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Rest.Tx.Transaction;

namespace TerraSharp.Rest.Tx.Block
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
