using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crypto.multisig;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Client
{
    public class MsgSubmitMisbehavior : SignerData
    {
        public readonly string client_id;
        public readonly Any misbehaviour;
        public readonly string signer;

        public MsgSubmitMisbehavior(string client_id, Any misbehaviour, string signer)
        {
            this.client_id = client_id;
            this.misbehaviour = misbehaviour;
            this.signer = signer;
        }

        public static MsgSubmitMisbehavior FromData(MsgSubmitMisbehaviorDataArgs data)
        {
            return new MsgSubmitMisbehavior(data.Client_id, data.Misbehaviour, data.Signer);
        }

        public static MsgSubmitMisbehavior FromProto(PROTO.MsgSubmitMisbehaviour data)
        {
            return new MsgSubmitMisbehavior(data.ClientId, data.Misbehaviour, data.Signer);
        }

        public MsgSubmitMisbehaviorDataArgs ToData()
        {
            return new MsgSubmitMisbehaviorDataArgs()
            {
                Client_id = this.client_id,
                Misbehaviour = this.misbehaviour,
                Signer = this.signer,
            };
        }

        public PROTO.MsgSubmitMisbehaviour ToProtoWithType()
        {
            return new PROTO.MsgSubmitMisbehaviour()
            {
                ClientId = this.client_id,
                Misbehaviour = this.misbehaviour,
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgSubmitMisbehavior UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgSubmitMisbehaviour>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_SUBMIT_MISBEHAVIOUR,
                Value = this.ToProto()
            };
        }
    }

    public class MsgSubmitMisbehaviorDataArgs : MsgSubmitMisbehaviorCommonArgs
    {
        public MsgSubmitMisbehaviorDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_SUBMIT_MISBEHAVIOUR;
        }
    }

    public class MsgSubmitMisbehaviorCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Client_id { get; set; }
        public Any Misbehaviour { get; set; }
        public string Signer { get; set; }
    }
}
