using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.ProtoBufs;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.channel.v1;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Channel
{
    public class Counterparty
    {
        public readonly string port_id;
        public readonly string channel_id;

        public Counterparty(
            string port_id,
            string channel_id)
        {
            this.channel_id = channel_id;
            this.port_id = port_id;
        }

        public static Counterparty FromAmino(CounterpartyAminoArgs data)
        {
            return new Counterparty(data.Port_Id, data.Channel_Id);
        }

        public static Counterparty FromData(CounterpartyDataArgs data)
        {
            return new Counterparty(data.Port_Id, data.Channel_Id);
        }

        public static Counterparty FromProto(PROTO.Counterparty data)
        {
            return new Counterparty(data.PortId, data.ChannelId);
        }

        public CounterpartyAminoArgs ToAmino()
        {
            return new CounterpartyAminoArgs()
            {
                Port_Id = this.port_id,
                Channel_Id = this.channel_id,
            };
        }

        public CounterpartyDataArgs ToData()
        {
            return new CounterpartyDataArgs()
            {
                Port_Id = this.port_id,
                Channel_Id = this.channel_id,
            };
        }

        public PROTO.Counterparty ToProtoWithType()
        {
            return new PROTO.Counterparty()
            {
                ChannelId = this.channel_id,
                PortId = this.port_id,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class CounterpartyAminoArgs : CounterpartyCommonArgs
    {
    }

    public class CounterpartyDataArgs : CounterpartyCommonArgs
    {
    }

    public class CounterpartyCommonArgs
    {
        public string Port_Id { get; set; }
        public string Channel_Id { get; set; }
    }
}
