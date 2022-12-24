using TerraSharp.Key.Extensions;
using NBitcoin;
using TerraNetExtensions.StringExt;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Core.Keys.Constants;
using Cryptography.ECDSA;
using TerraSharp.Core.Constants;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using TerraNetExtensions.ChainExtensions;

namespace TerraSharp.Key
{
    public class MnemonicKey : Key
    {
        private byte[] privateKey;
        public byte[] privateKeyExposed;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnemonicKey"></param>
        public MnemonicKey(string mnemonicKey = "", bool exposePrivateKey = false)
        {
            PrepareMnemonic(mnemonicKey, exposePrivateKey);
        }

        private async void PrepareMnemonic(string mnemonicKey, bool exposePrivateKey)
        {
            if (!string.IsNullOrWhiteSpace(mnemonicKey))
            {
                Mnemonic mnemo = new Mnemonic(mnemonicKey);
                ExtKey hdroot = mnemo.DeriveExtKey();
                var firstprivkey = hdroot.Derive(new KeyPath(DerivationPaths.DEFAULT_LUNA_PATH));

                this.privateKey = firstprivkey.PrivateKey.ToBytes();
                this.publicKey = GetSimpleKey();
            }
            else
            {
                var mns = await MnemonicExtension.GenerateRandomMnemonic();

                Mnemonic mnemo = new Mnemonic(mns.Value);
                ExtKey hdroot = mnemo.DeriveExtKey();
                var firstprivkey = hdroot.Derive(new KeyPath(DerivationPaths.DEFAULT_LUNA_PATH));

                this.privateKey = firstprivkey.PrivateKey.ToBytes();
                this.publicKey = GetSimpleKey();
            }
            
            if (exposePrivateKey)
            {
                this.privateKeyExposed = this.privateKey;
            }
        }

        public KeysDto GetSimpleKey()
        {
            // PUBLICKEY:  "A1xYF6iW3VSia08ItqjeBfpai+xj8tmuy/Ij3YquR6mX"
            // Private Key: 33, 1, 230, 161, 76, 99, 248, 11, 121, 38, 237, 169, 96, 93, 111, 186, 88, 162, 68, 9, 227, 252, 195, 203, 223, 154, 208, 65, 83, 132, 142, 232
            //var dataTest = new byte[32] { 33, 1, 230, 161, 76, 99, 248, 11, 121, 38, 237, 169, 96, 93, 111, 186, 88, 162, 68, 9, 227, 252, 195, 203, 223, 154, 208, 65, 83, 132, 142, 232 };
            //bool ist = dataTest == this.privateKey;
            //string key = TerraStringExtensions.GetBase64FromBytes(Secp256K1Manager.GetPublicKey(this.privateKey, true));

            var pubKey = Secp256K1Manager.GetPublicKey(this.privateKey, true);
            return new KeysDto()
            {
                RawPublicKey = pubKey,
                Key = TerraStringExtensions.GetBase64FromBytes(pubKey),
                TypeUrl = CosmosKeys.SECP256K1_SIMP_PUBKEY,
            };
        }

        public byte[] EcdsaSign(byte[] payload)
        {
            var data = TerraStringExtensions.GetBytesFromString(HashExtensionsLegacy.HashToHex(TerraStringExtensions.GetBase64FromBytes(payload)));
            return Secp256K1Manager.SignCompressedCompact(data, this.privateKey);
        }

        public override async Task<byte[]> Sign(byte[] payload)
        {
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(payload);

            return this.EcdsaSign(payload);
        }
    }
}
