using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1;
using Terra.Microsoft.Client.Core.IBC.Core.Commitment;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Connection
{
    public class Counterparty
    {
        public readonly string client_id;
        public readonly string connection_id;
        public readonly MerklePrefix prefix;

        public Counterparty(
            string client_id,
            string connection_id,
            MerklePrefix prefix)
        {
            this.client_id = client_id;
            this.connection_id = connection_id;
            this.prefix = prefix;
        }

        public static Counterparty FromData(CounterpartyAminoArgs data)
        {
            return new Counterparty(
                data.Client_Id,
                data.Connection_Id,
                MerklePrefix.FromAmino(data.Prefix));
        }
        public static Counterparty FromData(CounterpartyDataArgs data)
        {
            return new Counterparty(
                data.Client_Id,
                data.Connection_Id,
                MerklePrefix.FromData(data.Prefix));
        }

        public static Counterparty FromProto(PROTO.Counterparty data)
        {
            return new Counterparty(
                data.ClientId,
                data.ConnectionId,
                MerklePrefix.FromProto(data.Prefix));
        }
        public CounterpartyAminoArgs ToAmino()
        {
            return new CounterpartyAminoArgs()
            {
                Client_Id = this.client_id,
                Connection_Id = this.connection_id,
                Prefix = this.prefix.ToAmino()
            };
        }

        public CounterpartyDataArgs ToData()
        {
            return new CounterpartyDataArgs()
            {
                Client_Id = this.client_id,
                Connection_Id = this.connection_id,
                Prefix = this.prefix.ToData()
            };
        }

        public PROTO.Counterparty ToProtoWithType()
        {
            return new PROTO.Counterparty()
            {
                ClientId = this.client_id,
                ConnectionId = this.connection_id,
                Prefix = this.prefix.ToProtoWithType()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class CounterpartyAminoArgs : CounterpartyCommonArgs
    {
        public MerklePrefixAminoArgs Prefix { get; set; }
    }
    public class CounterpartyDataArgs : CounterpartyCommonArgs
    {
        public MerklePrefixDataArgs Prefix { get; set; }
    }

    public class CounterpartyCommonArgs
    {
        public string Client_Id { get; set; }
        public string Connection_Id { get; set; }
    }
}
