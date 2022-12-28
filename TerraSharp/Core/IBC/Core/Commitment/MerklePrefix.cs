using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.commitment.v1;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.IBC.Core.Commitment
{
    public class MerklePrefix
    {
        public readonly string key_prefix;
        public MerklePrefix(string key_prefix)
        {
            this.key_prefix = key_prefix;
        }

        public static MerklePrefix FromAmino(MerklePrefixAminoArgs data)
        {
            return new MerklePrefix(data.Key_Prefix);
        }

        public static MerklePrefix FromData(MerklePrefixDataArgs data)
        {
            return new MerklePrefix(data.Key_Prefix);
        }

        public static MerklePrefix FromProto(PROTO.MerklePrefix data)
        {
            return new MerklePrefix(TerraStringExtensions.GetBase64FromBytes(data.KeyPrefix));
        }

        public MerklePrefixAminoArgs ToAmino()
        {
            return new MerklePrefixAminoArgs()
            {
                Key_Prefix = this.key_prefix,
            };
        }

        public MerklePrefixDataArgs ToData()
        {
            return new MerklePrefixDataArgs()
            {
                Key_Prefix = this.key_prefix,
            };
        }

        public PROTO.MerklePrefix ToProtoWithType()
        {
            return new PROTO.MerklePrefix()
            {
                KeyPrefix = TerraStringExtensions.GetBase64BytesFromString(this.key_prefix)
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MerklePrefixAminoArgs
    {
        public string Key_Prefix { get; set; }
    }

    public class MerklePrefixDataArgs
    {
        public string Key_Prefix { get; set; }
    }
}
