using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.authz.v1beta1;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Core.Authz.Authorizations;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.Authz.Msgs
{
    public class MsgRevokeAuthorization : SignerData
    {
        public readonly string grantee;
        public readonly string granter;
        public readonly string msg_type_url;

        public MsgRevokeAuthorization(
            string grantee,
            string granter,
            string msg_type_url)
        {
            this.grantee = grantee;
            this.granter = granter;
            this.msg_type_url = msg_type_url;
        }

        public static MsgRevokeAuthorization FromAmino(MsgRevokeAuthorizationAminoArgs data)
        {
            return new MsgRevokeAuthorization(data.Value.Grantee, data.Value.Granter, data.Value.Msg_type_url);
        }

        public static MsgRevokeAuthorization FromData(MsgRevokeAuthorizationDataArgs data)
        {
            return new MsgRevokeAuthorization(data.Grantee, data.Granter, data.Msg_type_url);
        }

        public static MsgRevokeAuthorization FromProto(PROTO.MsgRevoke data)
        {
            return new MsgRevokeAuthorization(data.Grantee, data.Granter, data.MsgTypeUrl);
        }

        public MsgRevokeAuthorizationAminoArgs ToAmino()
        {
            return new MsgRevokeAuthorizationAminoArgs()
            {
                Value = new MsgRevokeAuthorizationValueArgs()
                {
                    Grantee = this.grantee,
                    Granter = this.granter,
                    Msg_type_url = this.msg_type_url
                }
            };
        }

        public MsgRevokeAuthorizationDataArgs ToData()
        {
            return new MsgRevokeAuthorizationDataArgs()
            {
                Grantee = this.grantee,
                Granter = this.granter,
                Msg_type_url = this.msg_type_url
            };
        }

        public PROTO.MsgRevoke ToProtoWithType()
        {
            return new PROTO.MsgRevoke()
            {
                Grantee = this.grantee,
                Granter = this.granter,
                MsgTypeUrl = this.msg_type_url
            };
        }
        //public TxBodyJSONMessages ToJson()
        //{
        //    return new TxBodyJSONMessages()
        //    {
        //        withdraw_address = this.withdraw_address,
        //        delegator_address = this.delegator_address,
        //        type = this.ToData().Type,
        //    };
        //}
        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgRevokeAuthorization UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgRevoke>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_MSG_REVOKE,
                Value = this.ToProto()
            };
        }
    }

    public class MsgRevokeAuthorizationAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgRevokeAuthorizationValueArgs Value { get; set; }

        public MsgRevokeAuthorizationAminoArgs()
        {
            this.Type = MsgConstants.MSGAUTH_MSG_REVOKE_AUTHORIZED;
        }
    }

    public class MsgRevokeAuthorizationValueArgs : MsgRevokeAuthorizationCommonArgs
    {
        public AuthorizationGrantAminoArgs Grant { get; set; }
    }

    public class MsgRevokeAuthorizationDataArgs : MsgRevokeAuthorizationCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public AuthorizationGrantDataArgs Grant { get; set; }

        public MsgRevokeAuthorizationDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_MSG_REVOKE;
        }
    }

    public class MsgRevokeAuthorizationCommonArgs
    {
        public string Msg_type_url { get; set; }
        public string Grantee { get; set; }
        public string Granter { get; set; }
    }
}
