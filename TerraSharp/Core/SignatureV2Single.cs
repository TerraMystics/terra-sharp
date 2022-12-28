using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1;
using Terra.Microsoft.Rest.Converters;
using Terra.Microsoft.Rest.Tx.Transaction;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1.ModeInfo;

namespace Terra.Microsoft.Client.Core
{
    public class SignatureV2Single
    {
        public readonly SignMode mode;
        public readonly string signature;

        public SignatureV2Single(SignMode mode, string signature = "")
        {
            this.mode = mode;
            this.signature = signature;
        }
        public static SignatureV2Single FromData(SingleDataArgs data)
        {
            return new SignatureV2Single(data.Mode, data.Signature);

        }

        public SingleDataArgs ToData()
        {
            return new SingleDataArgs()
            {
                Mode = this.mode,
                Signature = this.signature
            };
        }
        public TxSignerModeInfoSingle ToJSON()
        {
            return new TxSignerModeInfoSingle()
            {
                mode = SignModeConverters.GetFromEnum(this.mode)
            };
        }
        public PROTO.Single ToProtoWithType()
        {
            return new PROTO.Single()
            {
                Mode = this.mode
            };
        }
    }

    public class SingleDataArgs
    {
        public SignMode Mode { get; set; }
        public string Signature { get; set; }
    }
}
