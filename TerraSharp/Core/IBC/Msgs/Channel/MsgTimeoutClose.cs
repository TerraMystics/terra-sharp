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
    public class MsgTimeoutOnClose : SignerData
    {
        public readonly Packet packet;
        public readonly string proof_unreceived;
        public readonly string proof_close;
        public readonly Height proof_height;
        public readonly double next_sequence_recv;
        public readonly string signer;

        public MsgTimeoutOnClose(
            Packet packet,
            string proof_unreceived,
            string proof_close,
            Height proof_height,
            double next_sequence_recv,
            string signer)
        {
            this.proof_close = proof_close;
            this.packet = packet;
            this.proof_unreceived = proof_unreceived;
            this.signer = signer;
            this.next_sequence_recv = next_sequence_recv;
            this.proof_height = proof_height;
        }

        public static MsgTimeoutOnClose FromData(MsgTimeoutOnCloseDataArgs data)
        {
            return new MsgTimeoutOnClose(
                Packet.FromData(data.Packet),
                data.Proof_UnReceived,
                data.Proof_Close,
                Height.FromData(data.Proof_Height),
                data.Next_Sequence_Recv,
                data.Signer);
        }

        public static MsgTimeoutOnClose FromProto(PROTO.MsgTimeoutOnClose data)
        {
            return new MsgTimeoutOnClose(
                Packet.FromProto(data.Packet),
                TerraStringExtensions.GetBase64FromBytes(data.ProofUnreceived),
                TerraStringExtensions.GetBase64FromBytes(data.ProofClose),
                Height.FromProto(data.ProofHeight),
                data.NextSequenceRecv,
                data.Signer);
        }

        public MsgTimeoutOnCloseDataArgs ToData()
        {
            return new MsgTimeoutOnCloseDataArgs()
            {
                Packet = this.packet.ToData(),
                Proof_UnReceived = this.proof_unreceived,
                Proof_Height = this.proof_height.ToData(),
                Signer = this.signer,
                Next_Sequence_Recv = this.next_sequence_recv,
                Proof_Close = this.proof_close,
            };
        }

        public PROTO.MsgTimeoutOnClose ToProtoWithType()
        {
            return new PROTO.MsgTimeoutOnClose()
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

        public static MsgTimeoutOnClose UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgTimeoutOnClose>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_TIMEOUT_ON_CLOSE,
                Value = this.ToProto()
            };
        }
    }

    public class MsgTimeoutOnCloseDataArgs : MsgTimeoutOnCloseCommonArgs
    {
        public PacketDataArgs Packet { get; set; }
        public HeightDataArgs Proof_Height { get; set; }
        public MsgTimeoutOnCloseDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_TIMEOUT_ON_CLOSE;
        }
    }

    public class MsgTimeoutOnCloseCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Proof_UnReceived { get; set; }
        public double Next_Sequence_Recv { get; set; }
        public string Proof_Close { get; set; }
        public string Signer { get; set; }
    }
}
