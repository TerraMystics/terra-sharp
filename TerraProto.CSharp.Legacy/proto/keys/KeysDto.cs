using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraProto.CSharp.third_party.proto.cosmos.crypto.secp256k1;

namespace TerraProto.CSharp.proto.keys
{
    [ProtoBuf.ProtoContract()]
    public class KeysDto
    {
        [JsonProperty("@type")]
        [ProtoBuf.ProtoMember(1, Name = "@type")]
        public string TypeUrl { get; set; }
        [ProtoBuf.ProtoMember(2, Name = "Threshold")]
        public int Threshold { get; set; }

        [ProtoBuf.ProtoMember(3, Name = "Key")]
        public string Key { get; set; }
        public byte[] RawPublicKey { get; set; }


        [ProtoBuf.ProtoMember(4, Name = "Public_keys")]
        public PublicKeys[] Public_keys { get; set; }

        public bool IsMultiSig()
        {
            return Public_keys != null;
        }

        public Any PackAny(string key)
        {
            return new Any()
            {
                TypeUrl = this.TypeUrl,
                Value = ProtoExtensions.SerialiseFromData(new PubKey()
                {
                    Key = TerraStringExtensions.GetBytesFromBase64(key)
                })
            };
        }
    }

    [ProtoBuf.ProtoContract()]
    public class KeysDecode
    {
        [ProtoBuf.ProtoMember(1, Name = "key")]
        public byte[] Key { get; set; }
    }
}
