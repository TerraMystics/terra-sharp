
using TerraNetExtensions.StringExt;
using TerraProto.CSharp.third_party.proto.cosmos.tx.signing.v1beta1;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Core;
using TerraSharp.Core.SignatureV2n;
using TerraSharp.Converters;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TerraSharp.Key
{
    public abstract class Key
    {
        public KeysDto publicKey;

        public Key() { }
        public Key(KeysDto publicKey)
        {
            this.publicKey = publicKey;
        }

        public abstract Task<byte[]> Sign(byte[] payload);

        //public string AccAddress
        //{
        //    get
        //    {
        //        if (this.publicKey == null)
        //        {
        //            throw new Exception("Could not compute accAddress: missing rawAddress");
        //        }

        //        using (SHA256 sHA = SHA256.Create())
        //        {
        //            return Bech32NanoExtensions.GetBech32EncodeFromData(TerraPubKeys.TERRA_PUBLIC_KEYNAME,
        //                  HashExtensions.Ripemd160(TerraStringExtensions.GetStringFromBytes(
        //                      sHA.ComputeHash(Encoding.ASCII.GetBytes(this.publicKey.Key)))));
        //        }
        //    }
        //}

        //public string ValAddress
        //{
        //    get
        //    {
        //        if (this.publicKey == null)
        //        {
        //            throw new Exception("Could not compute accAddress: missing rawAddress");
        //        }

        //        return Bech32NanoExtensions.GetBech32EncodeFromData(TerraPubKeys.TERRA_DEV_KEYNAME,
        //              HashExtensions.Ripemd160(HashExtensions.HashToHex(TerraStringExtensions.GetBase64FromString(this.publicKey.Key))));
        //    }
        //}

        public async Task<SignatureV2> CreateSignatureAmino(SignDoc tx)
        {
            if (this.publicKey == null)
            {
                throw new Exception("Signature could not be created: Key instance missing publicKey");
            }

            var sigBytes = TerraStringExtensions.GetBase64FromBytes(await this.Sign(tx.ToProto()));

            return new SignatureV2(this.publicKey,
                new SignatureV2Descriptor(
                new SignatureV2Single(SignMode.SignModeLegacyAminoJson, sigBytes)),
                tx.sequence);
        }

        public async Task<SignatureV2> CreateSignature(SignDoc tx, object[] messages)
        {
            if (this.publicKey == null)
            {
                throw new Exception("Signature could not be created: Key instance missing publicKey");
            }

            var copyTx = tx;
            copyTx.auth_info.signer_infos = new List<SignerInfo>() {
                new SignerInfo(this.publicKey, copyTx.sequence,
                new ModeInfo(
                new SignatureV2Single(SignMode.SignModeDirect)))
            };

            var dataToEncode = copyTx.ToProto(messages.ToList().ConvertAll(w => JSONMessageBodyConverter.GetJsonFromBody(w)).ToArray());
            var sigBytes = TerraStringExtensions.GetBase64FromBytes(await this.Sign(dataToEncode));

            return new SignatureV2(this.publicKey,
                new SignatureV2Descriptor(
                new SignatureV2Single(SignMode.SignModeDirect, sigBytes)),
                tx.sequence);
        }

        public async Task<Tx> SignTx(Tx tx, SignOptions options, object[] messages)
        {
            if (this.publicKey == null)
            {
                throw new Exception("Signature could not be created: Key instance missing publicKey");
            }

            var sign_doc = new SignDoc(options.ChainId, options.AccountNumber.Value, options.Sequence.Value, tx.auth_info, tx.body);
            SignatureV2 signature;
            if (options.SignMode == SignMode.SignModeLegacyAminoJson)
            {
                signature = await this.CreateSignatureAmino(sign_doc);
            }
            else
            {
                signature = await this.CreateSignature(sign_doc, messages);
            }

            tx.AppendSignatures(new SignatureV2[] { signature });

            return tx;
        }
    }
}
