using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel
{
    public class MsgRecvPacket : SignerData
    {
        public readonly Packet packet;
        public readonly string proof_commitment;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgRecvPacket(
            Packet packet,
            string proof_commitment,
            Height proof_height,
            string signer)
        {
            this.packet = packet;
            this.proof_commitment = proof_commitment;
            this.signer = signer;
            this.proof_height = proof_height;
        }

        public static MsgRecvPacket FromData(MsgRecvPacketDataArgs data)
        {
            return new MsgRecvPacket(
                Packet.FromData(data.Packet),
                data.Proof_Commitment,
                Height.FromData(data.Proof_Height),
                data.Signer);
        }

        public static MsgRecvPacket FromProto(PROTO.MsgRecvPacket data)
        {
            return new MsgRecvPacket(
                Packet.FromProto(data.Packet),
                TerraStringExtensions.GetStringFromBytes(data.ProofCommitment),
                Height.FromProto(data.ProofHeight),
                data.Signer);
        }

        public MsgRecvPacketDataArgs ToData()
        {
            return new MsgRecvPacketDataArgs()
            {
                Packet = this.packet.ToData(),
                Proof_Commitment = this.proof_commitment,
                Proof_Height = this.proof_height.ToData(),
                Signer = this.signer
            };
        }

        public PROTO.MsgRecvPacket ToProtoWithType()
        {
            return new PROTO.MsgRecvPacket()
            {
                Signer = this.signer,
                Packet = this.packet.ToProtoWithType(),
                ProofCommitment = TerraStringExtensions.GetBase64BytesFromString(this.proof_commitment),
                ProofHeight = this.proof_height.ToProtoWithType(),
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgRecvPacket UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgRecvPacket>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_RECVPACKET,
                Value = this.ToProto()
            };
        }
    }

    public class MsgRecvPacketDataArgs : MsgRecvPacketCommonArgs
    {
        public PacketDataArgs Packet { get; set; }
        public HeightDataArgs Proof_Height { get; set; }
        public MsgRecvPacketDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_RECVPACKET;
        }
    }

    public class MsgRecvPacketCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Proof_Commitment { get; set; }
        public string Signer { get; set; }
    }
}
