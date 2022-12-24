using PROTO = TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;
using TerraSharp.Core.SignatureV2n;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Transaction;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Client.Lcd.Api;
using TerraNetExtensions.StringExt;
using Cryptography.ECDSA;

namespace TerraSharp.Core
{
    public class SignerInfo
    {
        public readonly KeysDto public_key;
        public readonly double sequence;
        public readonly ModeInfo mode_info;

        public SignerInfo(
            KeysDto public_key,
            double sequence,
            ModeInfo mode_info)
        {
            this.public_key = public_key;
            this.sequence = sequence;
            this.mode_info = mode_info;
        }

        public static SignerInfo FromData(SignerInfoDataArgs data)
        {
            return new SignerInfo(
                data.Public_Key,
                data.Sequence,
                ModeInfo.FromData(data.Mode_Info));
        }

        public PROTO.SignerInfo ToProtoWithType()
        {
            var msg = new PROTO.SignerInfo()
            {
                ModeInfo = this.mode_info.ToProtoWithType(),
                Sequence = (ulong)this.sequence,
                PublicKey = this.public_key.PackAny(this.public_key.Key)
            };

            return msg;
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public SignerInfoDataArgs ToData()
        {
            return new SignerInfoDataArgs()
            {
                Sequence = this.sequence,
                Mode_Info = this.mode_info.ToData(),
                Public_Key = this.public_key,
            };
        }

        public TxSignerInfo ToJson()
        {
            return new TxSignerInfo()
            {
                mode_info = this.mode_info.ToJSON(),
                public_key = this.public_key,
                sequence = this.sequence
            };
        }
    }

    public class SignerInfoDataArgs
    {
        public KeysDto Public_Key { get; set; }
        public double Sequence { get; set; }
        public ModeInfoDataArgs Mode_Info { get; set; }
    }
}
