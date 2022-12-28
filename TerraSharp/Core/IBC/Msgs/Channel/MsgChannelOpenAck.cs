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
    public class MsgChannelOpenAck : SignerData
    {
        public readonly string port_id;
        public readonly string channel_id;
        public readonly string counterparty_channel_id;
        public readonly string counterparty_version;
        public readonly string proof_try;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgChannelOpenAck(
            string port_id,
            string channel_id,
            string counterparty_channel_id,
            string counterparty_version,
            string proof_try,
            Height proof_height,
            string signer)
        {
            this.port_id = port_id;
            this.channel_id = channel_id;
            this.counterparty_channel_id = counterparty_channel_id;
            this.counterparty_version = counterparty_version;
            this.proof_try = proof_try;
            this.proof_height = proof_height;
            this.signer = signer;
        }

        public static MsgChannelOpenAck FromData(MsgChannelOpenAckDataArgs data)
        {
            return new MsgChannelOpenAck(
                data.Port_id,
                data.Channel_id,
                data.Counterparty_channel_id,
                data.Counterparty_version,
                data.Proof_try,
                Height.FromData(data.Proof_height),
                data.Signer);
        }

        public static MsgChannelOpenAck FromProto(PROTO.MsgChannelOpenAck data)
        {
            return new MsgChannelOpenAck(
                   data.PortId,
                   data.ChannelId,
                   data.CounterpartyChannelId,
                   data.CounterpartyVersion,
                   TerraStringExtensions.GetBase64FromBytes(data.ProofTry),
                   Height.FromProto(data.ProofHeight),
                   data.Signer);
        }

        public MsgChannelOpenAckDataArgs ToData()
        {
            return new MsgChannelOpenAckDataArgs()
            {
                Port_id = this.port_id,
                Channel_id = this.channel_id,
                Signer = this.signer,
                Counterparty_channel_id = this.counterparty_channel_id,
                Counterparty_version = this.counterparty_version,
                Proof_height = this.proof_height.ToData(),
                Proof_try = this.proof_try,
            };
        }

        public PROTO.MsgChannelOpenAck ToProtoWithType()
        {
            return new PROTO.MsgChannelOpenAck()
            {
                Signer = this.signer,
                ProofHeight = this.proof_height.ToProtoWithType(),
                ChannelId = this.channel_id,
                CounterpartyChannelId = this.counterparty_channel_id,
                CounterpartyVersion = this.counterparty_version,
                PortId = this.port_id,
                ProofTry = TerraStringExtensions.GetBase64BytesFromString(this.proof_try)
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgChannelOpenAck UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgChannelOpenAck>(msgAny.Value));
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

    public class MsgChannelOpenAckDataArgs : MsgChannelOpenAckCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public MsgChannelOpenAckDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_CLOSE_OPEN_ACK;
        }
    }

    public class MsgChannelOpenAckCommonArgs
    {
        public string Port_id { get; set; }
        public string Channel_id { get; set; }
        public string Signer { get; set; }
        public string Counterparty_channel_id { get; set; }
        public string Counterparty_version { get; set; }
        public string Proof_try { get; set; }
        public HeightDataArgs Proof_height { get; set; }
    }
}
