using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel
{
    public class Packet
    {
        public readonly double sequence;
        public readonly string source_port;
        public readonly string source_channel;
        public readonly string destination_port;
        public readonly string destination_channel;
        public readonly string data;
        public readonly Height timeout_height;
        public readonly double timeout_timestamp;

        public Packet(
            double sequence,
            string source_port,
            string source_channel,
            string destination_port,
            string destination_channel,
            string data,
            Height timeout_height,
            double timeout_timestamp)
        {
            this.sequence = sequence;
            this.source_port = source_port;
            this.source_channel = source_channel;
            this.destination_port = destination_port;
            this.destination_channel = destination_channel;
            this.data = data;
            this.timeout_height = timeout_height;
            this.timeout_timestamp = timeout_timestamp;
        }

        public static Packet FromData(PacketDataArgs data)
        {
            return new Packet(
                data.Sequence,
                data.Source_Port,
                data.Source_Channel,
                data.Destination_Port,
                data.Destination_Channel,
                data.Data,
                Height.FromData(data.Timeout_Height),
                double.Parse(data.Timeout_TimeStamp));
        }

        public static Packet FromProto(PROTO.Packet data)
        {
            return new Packet(
                 data.Sequence,
                 data.SourcePort,
                 data.SourceChannel,
                 data.DestinationPort,
                 data.DestinationChannel,
                 TerraStringExtensions.GetBase64FromBytes(data.Data),
                 Height.FromProto(data.TimeoutHeight),
                 data.TimeoutTimestamp);
        }

        public PacketDataArgs ToData()
        {
            return new PacketDataArgs()
            {
                Data = this.data,
                Destination_Channel = this.destination_channel,
                Destination_Port = this.destination_port,
                Source_Port = this.source_port,
                Sequence = this.sequence,
                Source_Channel = this.source_channel,
                Timeout_Height = this.timeout_height.ToData(),
                Timeout_TimeStamp = this.timeout_timestamp.ToString(),
            };
        }


        public PROTO.Packet ToProtoWithType()
        {
            return new PROTO.Packet()
            {
                Data = TerraStringExtensions.GetBase64BytesFromString(this.data),
                DestinationChannel = this.destination_channel,
                DestinationPort = this.destination_port,
                Sequence = (ulong)this.sequence,
                SourceChannel = this.source_channel,
                SourcePort = this.source_port,
                TimeoutHeight = this.timeout_height.ToProtoWithType(),
                TimeoutTimestamp = (ulong)this.timeout_timestamp
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }
    public class PacketAminoArgs : PacketCommonArgs
    {
        public HeightAminoArgs Timeout_Height { get; set; }
    }
    public class PacketDataArgs : PacketCommonArgs
    {
        public HeightDataArgs Timeout_Height { get; set; }
    }

    public class PacketCommonArgs
    {
        public double Sequence { get; set; }
        public string Source_Port { get; set; }
        public string Source_Channel { get; set; }
        public string Destination_Port { get; set; }
        public string Destination_Channel { get; set; }
        public string Data { get; set; }
        public string Timeout_TimeStamp { get; set; }
    }
}