using Google.Protobuf.WellKnownTypes;
using System.Linq;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Client.Core.Constants;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;
using STATE = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel.Main
{
    public class Channel
    {
        public readonly STATE.State state;
        public readonly PROTO.Order ordering;
        public readonly Counterparty counterParty;
        public readonly string[] connection_hops;
        public readonly string version;

        public Channel(
            STATE.State state,
            PROTO.Order ordering,
            Counterparty counterParty,
            string[] connection_hops,
            string version)
        {
            this.state = state;
            this.ordering = ordering;
            this.counterParty = counterParty;
            this.connection_hops = connection_hops;
            this.version = version;
        }

        public static Channel FromAmino(ChannelAminoArgs data)
        {
            return new Channel(
                data.State,
                data.Ordering,
                Counterparty.FromAmino(data.CounterParty),
                data.Connection_hops,
                data.Version);
        }

        public static Channel FromData(ChannelDataArgs data)
        {
            return new Channel(
                data.State,
                data.Ordering,
                Counterparty.FromData(data.CounterParty),
                data.Connection_hops,
                data.Version);
        }

        public static Channel FromProto(PROTO.Channel data)
        {
            return new Channel(
                data.State,
                data.Ordering,
                Counterparty.FromProto(data.Counterparty),
                data.ConnectionHops.ToArray(),
                data.Version);
        }

        public ChannelAminoArgs ToAmino()
        {
            return new ChannelAminoArgs()
            {
                State = this.state,
                Ordering = this.ordering,
                CounterParty = this.counterParty.ToAmino(),
                Connection_hops = this.connection_hops.ToArray(),
                Version = this.version
            };
        }

        public ChannelDataArgs ToData()
        {
            return new ChannelDataArgs()
            {
                State = this.state,
                Ordering = this.ordering,
                CounterParty = this.counterParty.ToData(),
                Connection_hops = this.connection_hops.ToArray(),
                Version = this.version
            };
        }


        public PROTO.Channel ToProtoWithType()
        {
            return new PROTO.Channel()
            {
                ConnectionHops = this.connection_hops.ToList(),
                Counterparty = this.counterParty.ToProtoWithType(),
                Ordering = this.ordering,
                State = this.state,
                Version = this.version
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class ChannelAminoArgs : ChannelCommonArgs
    {
        public CounterpartyAminoArgs CounterParty { get; set; }
    }

    public class ChannelDataArgs : ChannelCommonArgs
    {
        public CounterpartyDataArgs CounterParty { get; set; }
    }

    public class ChannelCommonArgs
    {
        public STATE.State State { get; set; }
        public PROTO.Order Ordering { get; set; }
        public string[] Connection_hops { get; set; }
        public string Version { get; set; }
    }
}
