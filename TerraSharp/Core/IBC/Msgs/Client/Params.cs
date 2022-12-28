using Google.Protobuf.WellKnownTypes;
using System.Linq;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Client
{
    public class Params
    {
        public readonly string[] allowed_clients;

        public Params(string[] allowed_clients)
        {
            this.allowed_clients = allowed_clients;
        }

        public static Params FromData(ParamsDataArgs data)
        {
            return new Params(data.Allowed_Clients);
        }

        public static Params FromProto(PROTO.Params data)
        {
            return new Params(data.AllowedClients.ToArray());
        }

        public ParamsDataArgs ToData()
        {
            return new ParamsDataArgs()
            {
                Allowed_Clients = this.allowed_clients,
            };
        }

        public PROTO.Params ToProtoWithType()
        {
            return new PROTO.Params()
            {
                AllowedClients = this.allowed_clients.ToList()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class ParamsDataArgs : ParamsCommonArgs
    {
    }

    public class ParamsCommonArgs
    {
        public string[] Allowed_Clients { get; set; }
    }
}
