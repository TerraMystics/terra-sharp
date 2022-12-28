namespace Terra.Microsoft.Client.Key
{
    public class SignOptions
    {
        public double? AccountNumber { get; set; }
        public double? Sequence { get; set; }
        public Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1.SignMode SignMode { get; set; }
        public string ChainId { get; set; }
    }
}
