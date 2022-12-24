using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.channel.v1;
using TerraSharp.Core.Constants;
using CN = TerraSharp.Core.IBC.Msgs.Channel.Main;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.IBC.Msgs.Channel
{
    public class MsgChannelOpenInit : SignerData
    {
        public readonly string port_id;
        public readonly CN.Channel channel;
        public readonly string signer;

        public MsgChannelOpenInit(
            string port_id,
            CN.Channel channel,
            string signer)
        {
            this.port_id = port_id;
            this.channel = channel;
            this.signer = signer;
        }

        public static MsgChannelOpenInit FromData(MsgChannelOpenInitDataArgs data)
        {
            return new MsgChannelOpenInit(
            data.Port_id,
            CN.Channel.FromData(data.Channel),
            data.Signer);
        }

        public static MsgChannelOpenInit FromProto(PROTO.MsgChannelOpenInit data)
        {
            return new MsgChannelOpenInit(
            data.PortId,
            CN.Channel.FromProto(data.Channel),
            data.Signer);
        }

        public MsgChannelOpenInitDataArgs ToData()
        {
            return new MsgChannelOpenInitDataArgs()
            {
                Port_id = this.port_id,
                Signer = this.signer,
                Channel = this.channel.ToData(),
            };
        }

        public PROTO.MsgChannelOpenInit ToProtoWithType()
        {
            return new PROTO.MsgChannelOpenInit()
            {
                Signer = this.signer,
                Channel = this.channel.ToProtoWithType(),
                PortId = this.port_id,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgChannelOpenInit UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgChannelOpenInit>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_OPEN_INIT,
                Value = this.ToProto()
            };
        }
    }

    public class MsgChannelOpenInitDataArgs : MsgChannelOpenInitCommonArgs
    {
        public CN.ChannelDataArgs Channel { get; set; }
        public MsgChannelOpenInitDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_OPEN_INIT;
        }
    }

    public class MsgChannelOpenInitCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Port_id { get; set; }
        public string Signer { get; set; }
    }
}
