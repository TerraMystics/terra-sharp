using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using System.Linq;
using TerraNetExtensions.ProtoBufs;
using TerraProto.CSharp.third_party.proto.cosmos.crypto.multisig;
using TerraSharp.Core.Extensions;
using TerraSharp.Core.Keys.Constants;

namespace TerraSharp.Core.Keys
{
    public class LegacyAminoMultisigPublicKey
    {
        public readonly double threshold;
        public readonly SimplePublicKey[] pubKeys;
        public LegacyAminoMultisigPublicKey(double threshold, SimplePublicKey[] pubKeys)
        {
            this.threshold = threshold;
            this.pubKeys = pubKeys;
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosKeys.MULTISIG_LEGACYAMINO_PUBKEY,
                Value = this.ToProto()
            };
        }

        public LegacyAminoMultisigPublicKeyDataArgs ToData()
        {
            return new LegacyAminoMultisigPublicKeyDataArgs()
            {
                Type = CosmosKeys.MULTISIG_LEGACYAMINO_PUBKEY,
                Threshold = this.threshold,
                PubKeys = this.pubKeys.ToList().ConvertAll(w => w.ToData()).ToArray(),
            };
        }

        public LegacyAminoPubKey ToProtoWithType()
        {
            return new LegacyAminoPubKey()
            {
                PublicKeys = this.pubKeys.ToList().ConvertAll(w => w.PackAny()).ToList(),
                Threshold = (uint)this.threshold
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public LegacyAminoMultisigPublicKeyAminoArgs ToAmino()
        {
            return new LegacyAminoMultisigPublicKeyAminoArgs()
            {
                Type = TendermintKeys.TENDERMINT_LEGACY_MULTISIG_AMINO_PUBKEY,
                Threshold = this.threshold,
                PubKeys = this.pubKeys.ToList().ConvertAll(w => w.ToAmino()).ToArray(),
            };
        }

        public static LegacyAminoMultisigPublicKey FromAmino(LegacyAminoMultisigPublicKeyAminoArgs data)
        {
            return new LegacyAminoMultisigPublicKey(data.Threshold, data.PubKeys.ToList().ConvertAll(w => SimplePublicKey.FromAmino(w)).ToArray());
        }

        public static LegacyAminoMultisigPublicKey FromData(LegacyAminoMultisigPublicKeyDataArgs data)
        {
            return new LegacyAminoMultisigPublicKey(data.Threshold, data.PubKeys.ToList().ConvertAll(w => SimplePublicKey.FromData(w)).ToArray());
        }

        public byte[] EncodeAminoPubkey()
        {
            var aminoData = PublicKeyExtensions.pubkeyAminoPrefixMultisigThreshold.ToList();
            aminoData.Add(0x08);
            //   aminoData.AddRange(this.EncodeUVariantFromBytes((int)this.threshold));

            return aminoData.ToArray();
        }

        //public byte[] RawAddress()
        //{
        //    return HashExtensions.sha256(TerraStringExtensions.GetStringFromBytes(this.EncodeAminoPubkey())).Take(20).ToArray();
        //}

        //public string Address()
        //{
        //    return Nano.Bech32.Bech32Encoder.Encode(TerraPubKeys.TERRA_PUBLIC_KEYNAME, this.RawAddress())!;
        //}

        //public string PubKeyAddress()
        //{
        //    return Nano.Bech32.Bech32Encoder.Encode(TerraPubKeys.TERRA_PUB, this.EncodeAminoPubkey())!;
        //}
    }

    public class LegacyAminoMultisigPublicKeyAminoArgs : LegacyAminoMultisigPublicKeyCommonArgs
    {
        public SimplePublicKeyAminoArgs[] PubKeys { get; set; }
        public LegacyAminoMultisigPublicKeyAminoArgs()
        {
            Type = TendermintKeys.TENDERMINT_LEGACY_MULTISIG_AMINO_PUBKEY;
        }
    }

    public class LegacyAminoMultisigPublicKeyDataArgs : LegacyAminoMultisigPublicKeyCommonArgs
    {
        public SimplePublicKeyDataArgs[] PubKeys { get; set; }
        public LegacyAminoMultisigPublicKeyDataArgs()
        {
            Type = CosmosKeys.MULTISIG_LEGACYAMINO_PUBKEY;
        }
    }

    public class LegacyAminoMultisigPublicKeyCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public double Threshold { get; set; }
    }
}
