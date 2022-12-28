using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using Terra.Microsoft.Rest.Tx.Block;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel
{
    public class MsgAcknowledgement : SignerData
    {
        public readonly string acknowledgment;
        public readonly Packet packet;
        public readonly string proof_acked;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgAcknowledgement(
            string acknowledgment,
            Packet packet,
            string proof_acked,
            Height proof_height,
            string signer)
        {
            this.acknowledgment = acknowledgment;
            this.packet = packet;
            this.proof_acked = proof_acked;
            this.proof_height = proof_height;
            this.signer = signer;
        }

        public static MsgAcknowledgement FromData(MsgAcknowledgementDataArgs data)
        {
            return new MsgAcknowledgement(
                data.Acknowledgment,
                Packet.FromData(data.Packet),
                data.Proof_Acked,
                Height.FromData(data.Proof_Height),
                data.Signer);
        }

        public static MsgAcknowledgement FromProto(PROTO.MsgAcknowledgement data)
        {
            return new MsgAcknowledgement(
                TerraStringExtensions.GetStringFromBytes(data.Acknowledgement),
                Packet.FromProto(data.Packet),
                TerraStringExtensions.GetStringFromBytes(data.ProofAcked),
                Height.FromProto(data.ProofHeight),
                data.Signer);
        }

        public MsgAcknowledgementDataArgs ToData()
        {
            return new MsgAcknowledgementDataArgs()
            {
                Signer = this.signer,
                Acknowledgment = this.acknowledgment,
                Packet = this.packet.ToData(),
                Proof_Acked = this.proof_acked,
                Proof_Height = this.proof_height.ToData(),
            };
        }

        public PROTO.MsgAcknowledgement ToProtoWithType()
        {
            return new PROTO.MsgAcknowledgement()
            {
                Acknowledgement = TerraStringExtensions.GetBase64BytesFromString(this.acknowledgment),
                Packet = this.packet.ToProtoWithType(),
                ProofAcked = TerraStringExtensions.GetBase64BytesFromString(this.proof_acked),
                ProofHeight = this.proof_height.ToProtoWithType(),
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgAcknowledgement UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgAcknowledgement>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_ACKNOWLEDGMENT,
                Value = this.ToProto()
            };
        }
    }

    public class MsgAcknowledgementDataArgs : MsgAcknowledgementCommonArgs
    {
        public HeightDataArgs Proof_Height { get; set; }
        public MsgAcknowledgementDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_ACKNOWLEDGMENT;
        }
    }

    public class MsgAcknowledgementCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Acknowledgment { get; set; }
        public PacketDataArgs Packet { get; set; }
        public string Proof_Acked { get; set; }
        public string Signer { get; set; }
    }
}
