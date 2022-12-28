using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.authz.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Linq;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.Authz.Msgs
{
    public class MsgExecAuthorized : SignerData
    {
        public readonly string grantee;
        public readonly Any[] msgs;

        public MsgExecAuthorized(
            string grantee,
            Any[] msgs)
        {
            this.grantee = grantee;
            this.msgs = msgs;
        }

        public static MsgExecAuthorized FromAmino(MsgExecAuthorizedAminoArgs data)
        {
            return new MsgExecAuthorized(data.Value.Grantee, data.Value.Msgs);
        }

        public static MsgExecAuthorized FromData(MsgExecAuthorizedDataArgs data)
        {
            return new MsgExecAuthorized(data.Grantee, data.Msgs);
        }

        public static MsgExecAuthorized FromProto(PROTO.MsgExec data)
        {
            return new MsgExecAuthorized(data.Grantee, data.Msgs.ToArray());
        }

        public MsgExecAuthorizedAminoArgs ToAmino()
        {
            return new MsgExecAuthorizedAminoArgs()
            {
                Value = new MsgExecAuthorizedValueArgs()
                {
                    Grantee = this.grantee,
                    Msgs = this.msgs
                }
            };
        }

        public MsgExecAuthorizedDataArgs ToData()
        {
            return new MsgExecAuthorizedDataArgs()
            {
                Grantee = this.grantee,
                Msgs = this.msgs
            };
        }

        public PROTO.MsgExec ToProtoWithType()
        {
            return new PROTO.MsgExec()
            {
                Grantee = this.grantee,
                Msgs = this.msgs.ToList()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgExecAuthorized UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgExec>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_MSG_EXEC,
                Value = this.ToProto()
            };
        }
    }

    public class MsgExecAuthorizedAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgExecAuthorizedValueArgs Value { get; set; }

        public MsgExecAuthorizedAminoArgs()
        {
            this.Type = MsgConstants.MSGAUTH_MSG_EXEC_AUTHORIZED;
        }
    }

    public class MsgExecAuthorizedValueArgs
    {
        public string Grantee { get; set; }
        public Any[] Msgs { get; set; }
    }

    public class MsgExecAuthorizedDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Grantee { get; set; }
        public Any[] Msgs { get; set; }

        public MsgExecAuthorizedDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_MSG_EXEC;
        }
    }
}
