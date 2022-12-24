using Google.Protobuf.WellKnownTypes;
using TerraProto.CSharp.third_party.proto.cosmos.tx.signing.v1beta1;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Core.SignatureV2n;

namespace TerraSharp.Core
{
    public class SignatureV2
    {
        private const double AMINO_SIGNATURE_SEQUENCE = 0;
        public readonly KeysDto public_key;
        public readonly double sequence;
        public readonly SignatureV2Descriptor data;

        public SignatureV2(KeysDto public_key, SignatureV2Descriptor data, double sequence)
        {
            this.public_key = public_key;
            this.sequence = sequence;
            this.data = data;
        }

        public static SignatureV2 FromData(SignatureV2DataArgs data)
        {
            return new SignatureV2(data.Public_Key, SignatureV2Descriptor.FromData(data.Data), double.Parse(data.Sequence));
        }

        public SignatureV2DataArgs ToData()
        {
            return new SignatureV2DataArgs()
            {
                Public_Key = this.public_key,
                Sequence = this.sequence.ToString(),
                Data = this.data.ToData()
            };
        }
    }

    public class SignatureV2AminoArgs
    {
        public string Signature { get; set; }
        public KeysDto Pub_Key { get; set; }

    }
    public class SignatureV2DataArgs
    {
        public KeysDto Public_Key { get; set; }
        public SignatureV2DescriptorDataArgs Data { get; set; }
        public string Sequence { get; set; }
    }
}
