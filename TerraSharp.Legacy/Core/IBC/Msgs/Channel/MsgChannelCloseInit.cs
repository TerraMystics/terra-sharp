using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraSharp.Rest.Tx.Block;
using TerraSharp.Core.Constants;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.channel.v1;

namespace TerraSharp.Core.IBC.Msgs.Channel
{
    public class MsgChannelCloseInit : SignerData
    {
        public readonly string port_id;
        public readonly string channel_id;
        public readonly string signer;

        public MsgChannelCloseInit(
            string port_id,
            string channel_id,
            string signer)
        {
            this.port_id = port_id;
            this.channel_id = channel_id;
            this.signer = signer;
        }

        public static MsgChannelCloseInit FromData(MsgChannelCloseInitDataArgs data)
        {
            return new MsgChannelCloseInit(
                data.Port_id,
            data.Channel_id,
                data.Signer);
        }

        public static MsgChannelCloseInit FromProto(PROTO.MsgChannelCloseInit data)
        {
            return new MsgChannelCloseInit(
                 data.PortId,
                 data.ChannelId,
                 data.Signer);
        }

        public MsgChannelCloseInitDataArgs ToData()
        {
            return new MsgChannelCloseInitDataArgs()
            {
                Port_id = this.port_id,
                Channel_id = this.channel_id,
                Signer = this.signer,
            };
        }

        public PROTO.MsgChannelCloseInit ToProtoWithType()
        {
            return new PROTO.MsgChannelCloseInit()
            {
                ChannelId = this.channel_id,
                PortId = this.port_id,
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgChannelCloseInit UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgChannelCloseInit>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_CLOSE_OPEN_ACK,
                Value = this.ToProto()
            };
        }
    }

    public class MsgChannelCloseInitDataArgs : MsgChannelCloseInitCommonArgs
    {
        public MsgChannelCloseInitDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_CLOSE_OPEN_ACK;
        }
    }

    public class MsgChannelCloseInitCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Port_id { get; set; }
        public string Channel_id { get; set; }
        public string Proof_init { get; set; }
        public string Signer { get; set; }
    }
}
