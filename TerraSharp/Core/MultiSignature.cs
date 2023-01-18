using System.Collections.Generic;
using System;
using Terra.Microsoft.Client.Core.SignatureV2n;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Keys;

namespace Terra.Microsoft.Client.Core
{
    public class MultiSignature
    {
        public readonly LegacyAminoMultisigPublicKey multisig_pubkey;

        public CompactBitArray BitArray { get; set; }
        public List<SignatureV2Descriptor> Signatures { get; set; }

        public MultiSignature(LegacyAminoMultisigPublicKey multisig_pubkey)
        {
            this.multisig_pubkey = multisig_pubkey;
            this.Signatures = new List<SignatureV2Descriptor>();

            //var n = multisig_pubkey.PubKeyAddress().Length;
            //this.BitArray = CompactBitArray.FromBits((uint)n);
        }

        public void AppendSignature(SignatureV2Descriptor signature_data, int index)
        {
            var newSigIndex = (int)this.BitArray.NumTrueBitsBefore(index);
            if (this.BitArray.GetIndex(index))
            {
                this.Signatures[newSigIndex] = signature_data;
                return;
            }

            this.BitArray.SetIndex(index, true);

            if (newSigIndex == this.Signatures.Count)
            {
                this.Signatures.Add(signature_data);
                return;
            }

            this.Signatures.Insert(newSigIndex, signature_data);
        }

        public void AppendSignatureFromPubKey(SignatureV2Descriptor signature_data, SimplePublicKey public_key)
        {
            //var index = this.multisig_pubkey.pubKeys.ToList().FindIndex(q => q.PubKeyAddress() == public_key.PubKeyAddress());
            //if (index == -1)
            //{
            //    throw new Exception("provided key doesn't exist in public_keys");
            //}

            //     this.AppendSignature(signature_data, index);
        }

        public void AppendSignatureV2s(SignatureV2[] signatures)
        {
            foreach (var signature in signatures)
            {
                if (!(signature.public_key.GetType() == typeof(SimplePublicKey)))
                {
                    throw new Exception("non-SimplePublicKey cannot be used to sign multisig");
                }

                this.AppendSignatureFromPubKey(signature.data, new SimplePublicKey(TerraStringExtensions.GetBase64BytesFromString(signature.public_key.Key)));
            }
        }

        public SignatureV2Descriptor ToSignatureDescriptor()
        {
            return new SignatureV2Descriptor(new SignatureV2Multi(this.BitArray, this.Signatures.ToArray()));
        }
    }
}
