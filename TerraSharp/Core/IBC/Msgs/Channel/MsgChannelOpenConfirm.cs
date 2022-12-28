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
    public class MsgChannelOpenConfirm : SignerData
    {

        public readonly string port_id;
        public readonly string channel_id;
        public readonly string proof_ack;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgChannelOpenConfirm(
            string port_id,
            string channel_id,
            string proof_ack,
            Height proof_height,
            string signer)
        {
            this.port_id = port_id;
            this.channel_id = channel_id;
            this.proof_ack = proof_ack;
            this.proof_height = proof_height;
            this.signer = signer;
        }

        public static MsgChannelOpenConfirm FromData(MsgChannelOpenConfirmDataArgs data)
        {
            return new MsgChannelOpenConfirm(
            data.Port_id,
            data.Channel_id,
            data.Proof_Ack,
            Height.FromData(data.Proof_Height),
            data.Signer);
        }

        public static MsgChannelOpenConfirm FromProto(PROTO.MsgChannelOpenConfirm data)
        {
            return new MsgChannelOpenConfirm(
            data.PortId,
            data.ChannelId,
            TerraStringExtensions.GetStringFromBytes(data.ProofAck),
            Height.FromProto(data.ProofHeight),
            data.Signer);
        }

        public MsgChannelOpenConfirmDataArgs ToData()
        {
            return new MsgChannelOpenConfirmDataArgs()
            {
                Port_id = this.port_id,
                Channel_id = this.channel_id,
                Signer = this.signer,
                Proof_Ack = this.proof_ack,
                Proof_Height = this.proof_height.ToData(),
            };
        }

        public PROTO.MsgChannelOpenConfirm ToProtoWithType()
        {
            return new PROTO.MsgChannelOpenConfirm()
            {
                Signer = this.signer,
                ProofHeight = this.proof_height.ToProtoWithType(),
                ChannelId = this.channel_id,
                ProofAck = TerraStringExtensions.GetBase64BytesFromString(this.proof_ack),
                PortId = this.port_id,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgChannelOpenConfirm UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgChannelOpenConfirm>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_OPEN_CONFIRM,
                Value = this.ToProto()
            };
        }
    }

    public class MsgChannelOpenConfirmDataArgs : MsgChannelOpenConfirmCommonArgs
    {
        public HeightDataArgs Proof_Height { get; set; }
        public MsgChannelOpenConfirmDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_OPEN_CONFIRM;
        }
    }

    public class MsgChannelOpenConfirmCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Port_id { get; set; }
        public string Channel_id { get; set; }
        public string Signer { get; set; }
        public string Proof_Ack { get; set; }
    }
}
