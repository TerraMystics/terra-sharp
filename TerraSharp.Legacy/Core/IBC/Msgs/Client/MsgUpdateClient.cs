using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.client.v1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.IBC.Msgs.Client
{
    public class MsgUpdateClient : SignerData
    {
        public readonly string client_id;
        public readonly Any header;
        public readonly string signer;

        public MsgUpdateClient(string client_id, Any header, string signer)
        {
            this.client_id = client_id;
            this.header = header;
            this.signer = signer;
        }

        public static MsgUpdateClient FromData(MsgUpdateClientDataArgs data)
        {
            return new MsgUpdateClient(data.Client_id, data.Header, data.Signer);
        }

        public static MsgUpdateClient FromProto(PROTO.MsgUpdateClient data)
        {
            return new MsgUpdateClient(data.ClientId, data.Header, data.Signer);
        }

        public MsgUpdateClientDataArgs ToData()
        {
            return new MsgUpdateClientDataArgs()
            {
                Client_id = this.client_id,
                Header = this.header,
                Signer = this.signer,
            };
        }

        public PROTO.MsgUpdateClient ToProtoWithType()
        {
            return new PROTO.MsgUpdateClient()
            {
                ClientId = this.client_id,
                Header = this.header,
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgUpdateClient UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgUpdateClient>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_UPDATE_CLIENT,
                Value = this.ToProto()
            };
        }
    }

    public class MsgUpdateClientDataArgs : MsgUpdateClientCommonArgs
    {
        public MsgUpdateClientDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_UPDATE_CLIENT;
        }
    }

    public class MsgUpdateClientCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Client_id { get; set; }
        public Any Header { get; set; }
        public string Signer { get; set; }
    }
}
