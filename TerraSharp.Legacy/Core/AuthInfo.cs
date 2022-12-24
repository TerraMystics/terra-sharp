using System.Collections.Generic;
using System.Linq;
using TerraNetExtensions.ProtoBufs;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Core.SignatureV2n;
using TerraSharp.Rest.Tx.Transaction;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;

namespace TerraSharp.Core
{
    public class AuthInfo
    {
        public List<SignerInfo> signer_infos;
        public readonly Fee fee;

        public AuthInfo(
            List<SignerInfo> signer_infos,
            Fee fee)
        {
            this.signer_infos = signer_infos;
            this.fee = fee;
        }
        public static AuthInfo FromJSON(TerraSharp.Rest.Tx.Transaction.TxAuthInfo data)
        {
            return new AuthInfo(
                data.signer_infos.ToList().ConvertAll(w =>
                new SignerInfo(
                    w.public_key,
                    w.sequence,
                    ModeInfo.FromJSON(w.mode_info))),
                    Fee.FromJSON(data.fee));
        }
        public static AuthInfo FromData(AuthInfoDataArgs data)
        {
            if (data.Signer_Infos != null)
            {
                return new AuthInfo(data.Signer_Infos.ToList().ConvertAll(w => SignerInfo.FromData(w)).ToList(), Fee.FromData(data.Fee));
            }

            return new AuthInfo(null, Fee.FromData(data.Fee));
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public PROTO.AuthInfo ToProtoWithType()
        {
            return new PROTO.AuthInfo()
            {
                Fee = this.fee.ToProtoWithType(),
                SignerInfos = this.signer_infos.ConvertAll(w => w.ToProtoWithType()),
            };
        }

        public AuthInfoDataArgs ToData()
        {
            return new AuthInfoDataArgs()
            {
                Signer_Infos = this.signer_infos.ToList().ConvertAll(w => w.ToData()).ToArray(),
                Fee = this.fee.ToData()
            };
        }

        public TxAuthInfo ToJson()
        {
            return new TxAuthInfo()
            {
                fee = this.fee.ToJson(),
                signer_infos = this.signer_infos.ConvertAll(w => w.ToJson()).ToArray()
            };
        }

        public static AuthInfo FromBytes(byte[] data)
        {
            return ProtoExtensions.DeserialiseFromBytes<AuthInfo>(data);
        }
    }

    public class AuthInfoDataArgs
    {
        public SignerInfoDataArgs[] Signer_Infos { get; set; }
        public FeeDataArgs Fee { get; set; }
    }
}
