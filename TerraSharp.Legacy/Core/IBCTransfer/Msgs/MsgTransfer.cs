using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.applications.transfer.v1;
using TerraSharp.Core.Constants;
using TerraSharp.Core.IBC.Msgs.Client;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using System;

namespace TerraSharp.Core.IBCTransfer.Msgs
{
    public class MsgTransfer : SignerData
    {
        public readonly string source_port;
        public readonly string source_channel;
        public readonly Coin token;
        public readonly string sender;
        public readonly string receiver;
        public readonly Height timeout_height;
        public readonly decimal timeout_timestamp;

        public MsgTransfer(
            string source_port,
            string source_channel,
            Coin token,
            string sender,
            string receiver,
            Height timeout_height,
            decimal timeout_timestamp)
        {
            this.source_port = source_port;
            this.source_channel = source_channel;
            this.token = token;
            this.sender = sender;
            this.receiver = receiver;
            this.timeout_height = timeout_height;
            this.timeout_timestamp = timeout_timestamp;
        }

        public static MsgTransfer FromAmino(MsgTransferAminoArgs data)
        {
            if (data.Value.Timeout_Height == null && data.Value.Timeout_Timestamp == null)
            {
                throw new Exception("both of timeout_height and timeout_timestamp are undefined");
            }

            return new MsgTransfer(
                data.Value.Source_Port,
                data.Value.Source_Channel,
                Coin.FromAmino(data.Value.Token),
                data.Value.Sender,
                data.Value.Receiver,
                Height.FromAmino(data.Value.Timeout_Height),
                decimal.Parse(data.Value.Timeout_Timestamp));
        }

        public static MsgTransfer FromData(MsgTransferDataArgs data)
        {
            if (data.Timeout_Height == null && data.Timeout_Timestamp == null)
            {
                throw new Exception("both of timeout_height and timeout_timestamp are undefined");
            }

            return new MsgTransfer(
                data.Source_Port,
                data.Source_Channel,
                Coin.FromData(data.Token),
                data.Sender,
                data.Receiver,
                Height.FromData(data.Timeout_Height),
                decimal.Parse(data.Timeout_Timestamp));
        }

        public static MsgTransfer FromProto(PROTO.MsgTransfer data)
        {
            return new MsgTransfer(
            data.SourcePort,
            data.SourceChannel,
            Coin.FromProto(data.Token),
            data.Sender,
            data.Receiver,
            Height.FromProto(data.TimeoutHeight),
            data.TimeoutTimestamp);
        }

        public MsgTransferAminoArgs ToAmino()
        {
            return new MsgTransferAminoArgs()
            {
                Value = new MsgTransferValueAminoArgs()
                {
                    Source_Port = this.source_port,
                    Source_Channel = this.source_channel,
                    Receiver = this.receiver,
                    Sender = this.sender,
                    Timeout_Height = this.timeout_height.ToAmino(),
                    Timeout_Timestamp = this.timeout_timestamp.ToString(),
                    Token = this.token.ToAmino()
                }
            };
        }

        public MsgTransferDataArgs ToData()
        {
            return new MsgTransferDataArgs()
            {
                Source_Port = this.source_port,
                Source_Channel = this.source_channel,
                Receiver = this.receiver,
                Sender = this.sender,
                Timeout_Height = this.timeout_height.ToData(),
                Timeout_Timestamp = this.timeout_timestamp.ToString(),
                Token = this.token.ToData()
            };
        }

        public PROTO.MsgTransfer ToProtoWithType()
        {
            return new PROTO.MsgTransfer()
            {
                Receiver = this.receiver,
                Sender = this.sender,
                SourceChannel = this.source_channel,
                SourcePort = this.source_port,
                TimeoutHeight = this.timeout_height.ToProtoWithType(),
                TimeoutTimestamp = (ulong)this.timeout_timestamp,
                Token = this.token.ToProtoWithType()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBCTRANSFER_MSG,
                Value = this.ToProto()
            };
        }
        public static MsgTransfer UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgTransfer>(msgAny.Value));
        }
    }

    public class MsgTransferAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgTransferValueAminoArgs Value { get; set; }
        public MsgTransferAminoArgs()
        {
            this.Type = IBCTransferConstants.IBC_TRANSFER_MSGTRANSFER;
        }
    }

    public class MsgTransferValueAminoArgs
    {
        public string Source_Port { get; set; }
        public string Source_Channel { get; set; }
        public CoinAminoArgs Token { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public HeightAminoArgs Timeout_Height { get; set; }
        public string Timeout_Timestamp { get; set; }
    }

    public class MsgTransferDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Source_Port { get; set; }
        public string Source_Channel { get; set; }
        public CoinDataArgs Token { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public HeightDataArgs Timeout_Height { get; set; }
        public string Timeout_Timestamp { get; set; }

        public MsgTransferDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBCTRANSFER_MSG;
        }
    }
}
