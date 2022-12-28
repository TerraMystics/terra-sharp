using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using CN = Terra.Microsoft.Client.Core.IBC.Msgs.Channel.Main;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel
{
    public class MsgChannelOpenTry : SignerData
    {
        public readonly string port_id;
        public readonly CN.Channel channel;
        public readonly string previous_channel_id;
        public readonly string counterparty_version;
        public readonly string proof_init;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgChannelOpenTry(
            string port_id,
            string previous_channel_id,
            CN.Channel channel,
            string counterparty_version,
            string proof_init,
            Height proof_height,
            string signer)
        {
            this.port_id = port_id;
            this.channel = channel;
            this.signer = signer;
            this.previous_channel_id = previous_channel_id;
            this.counterparty_version = counterparty_version;
            this.proof_init = proof_init;
            this.proof_height = proof_height;
        }

        public static MsgChannelOpenTry FromData(MsgChannelOpenTryDataArgs data)
        {
            return new MsgChannelOpenTry(
            data.Port_id,
            data.Previous_Channel_Id,
            CN.Channel.FromData(data.Channel),
            data.Counterparty_Version,
            data.Proof_Init,
            Height.FromData(data.Proof_Height),
            data.Signer);
        }

        public static MsgChannelOpenTry FromProto(PROTO.MsgChannelOpenTry data)
        {
            return new MsgChannelOpenTry(
                data.PortId,
                data.PreviousChannelId,
                CN.Channel.FromProto(data.Channel),
                data.CounterpartyVersion,
                TerraStringExtensions.GetBase64FromBytes(data.ProofInit),
                Height.FromProto(data.ProofHeight),
                data.Signer);
        }

        public MsgChannelOpenTryDataArgs ToData()
        {
            return new MsgChannelOpenTryDataArgs()
            {
                Port_id = this.port_id,
                Signer = this.signer,
                Channel = this.channel.ToData(),
                Previous_Channel_Id = this.previous_channel_id,
                Counterparty_Version = this.counterparty_version,
                Proof_Height = this.proof_height.ToData(),
                Proof_Init = this.proof_init,
            };
        }
       
        public PROTO.MsgChannelOpenTry ToProtoWithType()
        {
            return new PROTO.MsgChannelOpenTry()
            {
                Signer = this.signer,
                Channel = this.channel.ToProtoWithType(),
                PortId = this.port_id,
                CounterpartyVersion = this.counterparty_version,
                PreviousChannelId = this.previous_channel_id,
                ProofHeight = this.proof_height.ToProtoWithType(),
                ProofInit = TerraStringExtensions.GetBase64BytesFromString(this.proof_init)
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgChannelOpenTry UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgChannelOpenTry>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_OPEN_TRY,
                Value = this.ToProto()
            };
        }
    }

    public class MsgChannelOpenTryDataArgs : MsgChannelOpenTryCommonArgs
    {
        public CN.ChannelDataArgs Channel { get; set; }
        public HeightDataArgs Proof_Height { get; set; }
        public MsgChannelOpenTryDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_OPEN_TRY;
        }
    }

    public class MsgChannelOpenTryCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Port_id { get; set; }
        public string Signer { get; set; }
        public string Previous_Channel_Id { get; set; }
        public string Counterparty_Version { get; set; }
        public string Proof_Init { get; set; }
    }
}
