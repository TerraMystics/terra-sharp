using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crypto.secp256k1;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Client.Core.Keys.Constants;

namespace Terra.Microsoft.Client.Core.Keys
{
    public class SimplePublicKey
    {
        public readonly string key;
        public SimplePublicKey(string key)
        {
            this.key = key;
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosKeys.SECP256K1_SIMP_PUBKEY,
                Value = this.ToProto()
            };
        }

        public static SimplePublicKey UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PubKey>(msgAny.Value));
        }

        public SimplePublicKeyDataArgs ToData()
        {
            return new SimplePublicKeyDataArgs()
            {
                Type = CosmosKeys.SECP256K1_SIMP_PUBKEY,
                Key = this.key
            };
        }

        public PubKey ToProtoWithType()
        {
            return new PubKey()
            {
                Key = TerraStringExtensions.GetBase64BytesFromString(this.key)
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public SimplePublicKeyAminoArgs ToAmino()
        {
            return new SimplePublicKeyAminoArgs()
            {
                Key = this.key
            };
        }

        public static SimplePublicKey FromAmino(SimplePublicKeyAminoArgs data)
        {
            return new SimplePublicKey(data.Key);
        }

        public static SimplePublicKey FromData(SimplePublicKeyDataArgs data)
        {
            return new SimplePublicKey(data.Key);
        }

        public static SimplePublicKey FromProto(PubKey data)
        {
            return new SimplePublicKey(TerraStringExtensions.GetBase64FromBytes(data.Key));
        }

        public byte[] EncodeAminoPubkey()
        {
            var base64Data = PublicKeyExtensions.GetBase64DataFromKey(this.key);
            return PublicKeyExtensions.pubkeyAminoPrefixSecp256k1.MergeDataArrays(base64Data);
        }

        //public byte[] RawAddress()
        //{
        //    return HashExtensions.Ripemd160(HashExtensions.HashToHex(TerraStringExtensions.GetBase64FromString(this.key)));
        //}

        //public string Address()
        //{
        //    return Nano.Bech32.Bech32Encoder.Encode(TerraPubKeys.TERRA_PUBLIC_KEYNAME, this.RawAddress())!;
        //}

        //public string PubKeyAddress()
        //{
        //    return Nano.Bech32.Bech32Encoder.Encode(TerraPubKeys.TERRA_PUB, this.RawAddress())!;
        //}
    }
    public class SimplePublicKeyAminoArgs : SimplePublicKeyCommonArgs
    {
        public SimplePublicKeyAminoArgs()
        {
            Type = TendermintKeys.TENDERMINT_SIMPLE_PUBKEY;
        }
    }

    public class SimplePublicKeyDataArgs : SimplePublicKeyCommonArgs
    {
        public SimplePublicKeyDataArgs()
        {
            Type = CosmosKeys.SECP256K1_SIMP_PUBKEY;
        }
    }

    public class SimplePublicKeyCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Key { get; set; }
    }
}
