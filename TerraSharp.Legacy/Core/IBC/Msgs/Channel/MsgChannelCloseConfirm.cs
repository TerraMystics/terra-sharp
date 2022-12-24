using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraSharp.Rest.Tx.Block;
using TerraSharp.Core.Constants;
using TerraSharp.Core.IBC.Msgs.Client;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.channel.v1;

namespace TerraSharp.Core.IBC.Msgs.Channel
{
    public class MsgChannelCloseConfirm : SignerData
    {
        public readonly string port_id;
        public readonly string channel_id;
        public readonly string proof_init;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgChannelCloseConfirm(
            string port_id,
            string channel_id,
            string proof_init,
            Height proof_height,
            string signer)
        {
            this.port_id = port_id;
            this.channel_id = channel_id;
            this.proof_init = proof_init;
            this.proof_height = proof_height;
            this.signer = signer;
        }

        public static MsgChannelCloseConfirm FromData(MsgChannelCloseConfirmDataArgs data)
        {
            return new MsgChannelCloseConfirm(
                data.Port_id,
                data.Channel_id,
                data.Proof_init,
                Height.FromData(data.Proof_height),
                data.Signer);
        }

        public static MsgChannelCloseConfirm FromProto(PROTO.MsgChannelCloseConfirm data)
        {
            return new MsgChannelCloseConfirm(
                 data.PortId,
                 data.ChannelId,
                 TerraStringExtensions.GetStringFromBytes(data.ProofInit),
                 Height.FromProto(data.ProofHeight),
                 data.Signer);
        }


        public MsgChannelCloseConfirmDataArgs ToData()
        {
            return new MsgChannelCloseConfirmDataArgs()
            {
                Port_id = this.port_id,
                Channel_id = this.channel_id,
                Proof_init = this.proof_init,
                Proof_height = this.proof_height.ToData(),
                Signer = this.signer,
            };
        }

        public PROTO.MsgChannelCloseConfirm ToProtoWithType()
        {
            return new PROTO.MsgChannelCloseConfirm()
            {
                ChannelId = this.channel_id,
                PortId = this.port_id,
                ProofHeight = this.proof_height.ToProtoWithType(),
                ProofInit = TerraStringExtensions.GetBase64BytesFromString(this.proof_init),
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgChannelCloseConfirm UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgChannelCloseConfirm>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_CLOSE_CONFIRM,
                Value = this.ToProto()
            };
        }
    }

    public class MsgChannelCloseConfirmDataArgs : MsgChannelCloseConfirmCommonArgs
    {
        public HeightDataArgs Proof_height { get; set; }
        public MsgChannelCloseConfirmDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_CLOSE_CONFIRM;
        }
    }

    public class MsgChannelCloseConfirmCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Port_id { get; set; }
        public string Channel_id { get; set; }
        public string Proof_init { get; set; }
        public string Signer { get; set; }
    }
}
