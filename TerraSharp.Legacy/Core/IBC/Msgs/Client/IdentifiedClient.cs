using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.IBC;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.client.v1;

namespace TerraSharp.Core.IBC.Msgs.Client
{
    public class IdentifiedClientState
    {
        public readonly string client_id;
        public readonly IBCApiClientStatesValue client_state;

        public IdentifiedClientState(
            string client_id,
            IBCApiClientStatesValue client_state)
        {
            this.client_id = client_id;
            this.client_state = client_state;
        }

        public static IdentifiedClientState FromAmino(IdentifiedClientStateAminoArgs data)
        {
            return new IdentifiedClientState(data.Client_Id, data.Client_State);
        }

        public static IdentifiedClientState FromData(IdentifiedClientStateDataArgs data)
        {
            return new IdentifiedClientState(data.Client_Id, data.Client_State);
        }

        public IdentifiedClientStateAminoArgs ToAmino()
        {
            return new IdentifiedClientStateAminoArgs()
            {
                Client_State = this.client_state,
                Client_Id = this.client_id,
            };
        }

        public IdentifiedClientStateDataArgs ToData()
        {
            return new IdentifiedClientStateDataArgs()
            {
                Client_State = this.client_state,
                Client_Id = this.client_id,
            };
        }

        public PROTO.IdentifiedClientState ToProtoWithType()
        {
            return new PROTO.IdentifiedClientState()
            {
                ClientId = this.client_id,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class IdentifiedClientStateAminoArgs : IdentifiedClientStateCommonArgs
    {
    }

    public class IdentifiedClientStateDataArgs : IdentifiedClientStateCommonArgs
    {
    }

    public class IdentifiedClientStateCommonArgs
    {
        public string Client_Id { get; set; }
        public IBCApiClientStatesValue Client_State { get; set; }
    }
}
