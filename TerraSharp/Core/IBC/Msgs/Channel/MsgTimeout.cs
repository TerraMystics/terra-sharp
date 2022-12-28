using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using Newtonsoft.Json;
using Terra.Microsoft.Rest.Tx.Block;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel
{
    public class MsgTimeout : SignerData
    {
        public readonly Packet packet;
        public readonly string proof_unreceived;
        public readonly Height proof_height;
        public readonly double next_sequence_recv;
        public readonly string signer;

        public MsgTimeout(
            Packet packet,
            string proof_unreceived,
            Height proof_height,
            double next_sequence_recv,
            string signer)
        {
            this.packet = packet;
            this.proof_unreceived = proof_unreceived;
            this.signer = signer;
            this.next_sequence_recv = next_sequence_recv;
            this.proof_height = proof_height;
        }

        public static MsgTimeout FromData(MsgTimeoutDataArgs data)
        {
            return new MsgTimeout(
                Packet.FromData(data.Packet),
                data.Proof_UnReceived,
                Height.FromData(data.Proof_Height),
                data.Next_Sequence_Recv,
                data.Signer);
        }

        public static MsgTimeout FromProto(PROTO.MsgTimeout data)
        {
            return new MsgTimeout(
                Packet.FromProto(data.Packet),
                TerraStringExtensions.GetBase64FromBytes(data.ProofUnreceived),
                Height.FromProto(data.ProofHeight),
                data.NextSequenceRecv,
                data.Signer);
        }

        public MsgTimeoutDataArgs ToData()
        {
            return new MsgTimeoutDataArgs()
            {
                Packet = this.packet.ToData(),
                Proof_UnReceived = this.proof_unreceived,
                Proof_Height = this.proof_height.ToData(),
                Signer = this.signer,
                Next_Sequence_Recv = this.next_sequence_recv,
            };
        }

        public PROTO.MsgTimeout ToProtoWithType()
        {
            return new PROTO.MsgTimeout()
            {
                Signer = this.signer,
                Packet = this.packet.ToProtoWithType(),
                NextSequenceRecv = (ulong)this.next_sequence_recv,
                ProofUnreceived = TerraStringExtensions.GetBase64BytesFromString(this.proof_unreceived),
                ProofHeight = this.proof_height.ToProtoWithType(),
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgTimeout UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgTimeout>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_TIMEOUT,
                Value = this.ToProto()
            };
        }
    }

    public class MsgTimeoutDataArgs : MsgTimeoutCommonArgs
    {
        public PacketDataArgs Packet { get; set; }
        public HeightDataArgs Proof_Height { get; set; }
        public MsgTimeoutDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_TIMEOUT;
        }
    }

    public class MsgTimeoutCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Proof_UnReceived { get; set; }
        public double Next_Sequence_Recv { get; set; }
        public string Signer { get; set; }
    }
}
