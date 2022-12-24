using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.client.v1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.IBC.Msgs.Client
{
    public class MsgCreateClient : SignerData
    {
        public readonly Any client_state;
        public readonly Any concensus_state;
        public readonly string signer;

        public MsgCreateClient(
            Any client_state,
            Any concensus_state,
            string signer)
        {
            this.client_state = client_state;
            this.concensus_state = concensus_state;
            this.signer = signer;
        }

        public static MsgCreateClient FromData(MsgCreateClientDataArgs data)
        {
            return new MsgCreateClient(data.Client_State, data.Concensus_State, data.Signer);
        }

        public static MsgCreateClient FromProto(PROTO.MsgCreateClient data)
        {
            return new MsgCreateClient(data.ClientState, data.ConsensusState, data.Signer);
        }

        public MsgCreateClientDataArgs ToData()
        {
            return new MsgCreateClientDataArgs()
            {
                Client_State = this.client_state,
                Concensus_State = this.concensus_state,
                Signer = this.signer,
            };
        }

        public PROTO.MsgCreateClient ToProtoWithType()
        {
            return new PROTO.MsgCreateClient()
            {
                ClientState = this.client_state,
                ConsensusState = this.concensus_state, 
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgCreateClient UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgCreateClient>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_CLIENT_CREATE,
                Value = this.ToProto()
            };
        }
    }

    public class MsgCreateClientDataArgs : MsgCreateClientCommonArgs
    {
        public MsgCreateClientDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_CLIENT_CREATE;
        }
    }

    public class MsgCreateClientCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public Any Client_State { get; set; }
        public Any Concensus_State { get; set; }
        public string Signer { get; set; }
    }
}
