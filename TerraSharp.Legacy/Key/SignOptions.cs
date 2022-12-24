namespace TerraSharp.Key
{
    public class SignOptions
    {
        public double? AccountNumber { get; set; }
        public double? Sequence { get; set; }
        public TerraProto.CSharp.third_party.proto.cosmos.tx.signing.v1beta1.SignMode SignMode { get; set; }
        public string ChainId { get; set; }
    }
}
