﻿using System.Collections.Generic;
using Terra.Microsoft.Client.Core.SignatureV2n;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Keys;
using System.Threading.Tasks;
using System.Linq;
using System;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1;
using Terra.Microsoft.Client.Converters;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Key
{
    public class TxMnemonic : MnemonicKey
    {
        public readonly string recoveryWords;
        public TxMnemonic(string recoveryWords, bool exposePrivateKey = false) : base(recoveryWords, exposePrivateKey)
        {
            this.recoveryWords = recoveryWords;
        }

        public async Task<SignatureV2> CreateSignatureAmino(SignDoc tx)
        {
            if (this.publicKey == null)
            {
                throw new Exception("Signature could not be created: Key instance missing publicKey");
            }

            //    var sigBytes = await this.Sign(tx.ToProto());

            return new SignatureV2(this.publicKey.ToProtoDto(),
                new SignatureV2Descriptor(
                new SignatureV2Single(SignMode.SignModeLegacyAminoJson, null)),
                tx.sequence);
        }

        public async Task<KeyValuePair<string, SignatureV2>> CreateSignature(SignDoc tx)
        {
            if (this.publicKey == null)
            {
                throw new Exception("Signature could not be created: Key instance missing publicKey");
            }

            var copyTx = tx;
            copyTx.auth_info.signer_infos = new List<SignerInfo>() {
                new SignerInfo(this.publicKey.ToProtoDto(), copyTx.sequence,
                new ModeInfo(
                new SignatureV2Single(SignMode.SignModeDirect)))
            };

            var dataToEncode = copyTx.ToData();

            return new KeyValuePair<string, SignatureV2>(await Sign(JsonConvert.SerializeObject(dataToEncode)), new SignatureV2(this.publicKey.ToProtoDto(),
                new SignatureV2Descriptor(
                new SignatureV2Single(SignMode.SignModeDirect)),
                tx.sequence));
        }

        public async Task<Tx> SignTx(Tx tx, SignOptions options)
        {
            if (this.publicKey == null)
            {
                throw new Exception("Signature could not be created: Key instance missing publicKey");
            }

            var sign_doc = new SignDoc(options.ChainId, options.AccountNumber.Value, options.Sequence.Value, tx.auth_info, tx.body);
            var csign = await this.CreateSignature(sign_doc);

            SignatureV2 signature = csign.Value;

            tx.AppendSignatures(new SignatureV2[] { signature }, csign.Key, TerraStringExtensions.GetBase64FromBytes(this.publicKey.key));

            return tx;
        }
    }
}
