using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.commitment.v1;

namespace Terra.Microsoft.Client.Core.IBC.Core.Commitment
{
    public class MerkleRoot
    {
        public readonly string hash;
        public MerkleRoot(string hash)
        {
            this.hash = hash;
        }

        public static MerkleRoot FromAmino(MerkleRootAminoArgs data)
        {
            return new MerkleRoot(data.Hash);
        }

        public static MerkleRoot FromData(MerkleRootDataArgs data)
        {
            return new MerkleRoot(data.Hash);
        }

        public static MerkleRoot FromProto(PROTO.MerkleRoot data)
        {
            return new MerkleRoot(TerraStringExtensions.GetStringFromBytes(data.Hash));
        }

        public MerkleRootAminoArgs ToAmino()
        {
            return new MerkleRootAminoArgs()
            {
                Hash = this.hash,
            };
        }

        public MerkleRootDataArgs ToData()
        {
            return new MerkleRootDataArgs()
            {
                Hash = this.hash,
            };
        }

        public PROTO.MerkleRoot ToProtoWithType()
        {
            return new PROTO.MerkleRoot()
            {
                Hash = TerraStringExtensions.GetBase64BytesFromString(this.hash)
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MerkleRootAminoArgs
    {
        public string Hash { get; set; }
    }

    public class MerkleRootDataArgs
    {
        public string Hash { get; set; }
    }
}
