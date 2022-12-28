using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Transaction;
using System;

namespace Terra.Microsoft.Client.Core.SignatureV2n
{
    public class ModeInfo
    {
        public SignatureV2Single Single { get; set; }
        public SignatureV2Multi Multi { get; set; }

        public ModeInfo(object data)
        {
            if (data is SignatureV2Single)
            {
                this.Single = data as SignatureV2Single;
            }
            if (data is SignatureV2Multi)
            {
                this.Multi = data as SignatureV2Multi;
            }
        }

        public static ModeInfo FromJSON(Terra.Microsoft.Rest.Tx.Transaction.TxSignerModeInfo data)
        {
            if (data.single != null)
            {
                return new ModeInfo(data.single);
            }

            if (data.multi != null)
            {
                return new ModeInfo(data.multi);
            }

            throw new Exception("Must Single or Multi");
        }

        public static ModeInfo FromData(ModeInfoDataArgs data)
        {
            if (data.Single != null)
            {
                return new ModeInfo(data.Single);
            }

            if (data.Multi != null)
            {
                return new ModeInfo(data.Multi);
            }

            throw new Exception("Must Single or Multi");
        }

        //public static ModeInfo FromProto(PROTO.ModeInfo data)
        //{
        //    if (data.single != null)
        //    {
        //        return new ModeInfo(SignatureV2Single.FromProto(data.single));
        //    }

        //    if (data.multi != null)
        //    {
        //        return new ModeInfo(SignatureV2Multi.FromProto(data.multi));
        //    }

        //    throw new Exception("Must Single or Multi");
        //}

        public ModeInfoDataArgs ToData()
        {
            return new ModeInfoDataArgs()
            {
                Single = this.Single,
                Multi = this.Multi
            };
        }

        public TxSignerModeInfo ToJSON()
        {
            if (this.Single != null)
            {
                return new TxSignerModeInfo()
                {
                    single = this.Single.ToJSON(),
                };
            }
            else
            {
                return new TxSignerModeInfo()
                {
                    multi = this.Multi.ToJSON()
                };
            }
        }

        public PROTO.ModeInfo ToProtoWithType()
        {
            if (this.Multi != null)
            {
                return new PROTO.ModeInfo()
                {
                    multi = this.Multi.ToProtoWithType()
                };
            }
            else
            {
                return new PROTO.ModeInfo()
                {
                    single = this.Single.ToProtoWithType()
                };
            }
        }

        //public byte[] ToProto()
        //{
        //    return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        //}
    }

    public class ModeInfoDataArgs
    {
        public SignatureV2Single Single { get; set; }
        public SignatureV2Multi Multi { get; set; }
    }
}
