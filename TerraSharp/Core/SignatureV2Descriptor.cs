using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crypto.multisig.v1beta1;

using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
namespace Terra.Microsoft.Client.Core.SignatureV2n
{
    public class SignatureV2Descriptor
    {
        public SignatureV2Single Single { get; set; }
        public SignatureV2Multi Multi { get; set; }

        public SignatureV2Descriptor(object data)
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

        public KeyValuePair<ModeInfo, string> ToModeInfoAndSignature()
        {
            if (this.Single != null)
            {
                var sigData = this.Single;
                return new KeyValuePair<ModeInfo,string>(
                    new ModeInfo(new SignatureV2Single(sigData.mode, sigData.signature)),
                   sigData.signature);
            }

            //if (this.Multi != null)
            //{
            //    var sigData = this.Multi;
            //    List<ModeInfo> modeInfos = new List<ModeInfo>();
            //    List<byte[]> signatures = new List<byte[]>();
            //    foreach (var signature in sigData.signatures)
            //    {
            //        var sig = signature.ToModeInfoAndSignature();
            //        modeInfos.Add(sig.Key);
            //        signatures.Add(sig.Value);
            //    }

            //    var multisigBytes = ProtoExtensions.SerialiseFromData(new PROTO.MultiSignature()
            //    {
            //        Signatures = signatures
            //    });

            //    return new KeyValuePair<ModeInfo, byte[]>(
            //        new ModeInfo(new SignatureV2Multi(sigData.bitArray, sigData.signatures)),
            //        multisigBytes);
            //}

            throw new ArgumentNullException("invalid signature descriptor");
        }

        public static SignatureV2Descriptor FromData(SignatureV2DescriptorDataArgs data)
        {
            if (data.Single != null)
            {
                return new SignatureV2Descriptor(SignatureV2Single.FromData(data.Single));
            }

            if (data.Multi != null)
            {
                return new SignatureV2Descriptor(SignatureV2Multi.FromData(data.Multi));
            }

            throw new Exception("must be one of single or multi");
        }

        public SignatureV2DescriptorDataArgs ToData()
        {
            if (this.Single != null)
            {
                return new SignatureV2DescriptorDataArgs()
                {
                    Single = this.Single.ToData()
                };
            }

            if (this.Multi != null)
            {
                return new SignatureV2DescriptorDataArgs()
                {
                    Multi = this.Multi.ToData()
                };
            }

            throw new Exception("must be one of single or multi");
        }
    }

    public class SignatureV2DescriptorDataArgs
    {
        public SingleDataArgs Single { get; set; }
        public MultiDataArgs Multi { get; set; }
    }
}
