using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.authz.v1beta1;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Core.Authz.Authorizations;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.Authz.Msgs
{
    public class MsgGrantAuthorization : SignerData
    {
        public readonly string grantee;
        public readonly string granter;
        public readonly AuthorizationGrant grant;

        public MsgGrantAuthorization(
            string grantee,
            string granter,
            AuthorizationGrant grant)
        {
            this.grantee = grantee;
            this.granter = granter;
            this.grant = grant;
        }

        public static MsgGrantAuthorization FromAmino(MsgGrantAuthorizationAminoArgs data, AuthorizationGrantType grantType)
        {
            return new MsgGrantAuthorization(data.Value.Grantee, data.Value.Granter, AuthorizationGrant.FromAmino(data.Value.Grant, grantType));
        }

        public static MsgGrantAuthorization FromData(MsgGrantAuthorizationDataArgs data, AuthorizationGrantType grantType)
        {
            return new MsgGrantAuthorization(data.Grantee, data.Granter, AuthorizationGrant.FromData(data.Grant, grantType));
        }

        public static MsgGrantAuthorization FromProto(PROTO.MsgGrant data, AuthorizationGrantType grantType)
        {
            return new MsgGrantAuthorization(data.Grantee, data.Granter, AuthorizationGrant.FromProto(data.Grant, grantType));
        }

        public MsgGrantAuthorizationAminoArgs ToAmino()
        {
            return new MsgGrantAuthorizationAminoArgs()
            {
                Value = new MsgGrantAuthorizationValueArgs()
                {
                    Grantee = this.grantee,
                    Granter = this.granter,
                    Grant = this.grant.ToAmino()
                }
            };
        }

        public MsgGrantAuthorizationDataArgs ToData()
        {
            return new MsgGrantAuthorizationDataArgs()
            {
                Grantee = this.grantee,
                Granter = this.granter,
                Grant = this.grant.ToData()
            };
        }

        public PROTO.MsgGrant ToProtoWithType()
        {
            return new PROTO.MsgGrant()
            {
                Grantee = this.grantee,
                Granter = this.granter,
                Grant = this.grant.ToProtoWithType()
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

        public static MsgGrantAuthorization UnPackAny(Any msgAny, AuthorizationGrantType grantType)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgGrant>(msgAny.Value), grantType);
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_MSG_GRANT,
                Value = this.ToProto()
            };
        }
    }

    public class MsgGrantAuthorizationAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgGrantAuthorizationValueArgs Value { get; set; }

        public MsgGrantAuthorizationAminoArgs()
        {
            this.Type = MsgConstants.MSGAUTH_MSG_GRANT_AUTHORIZED;
        }
    }

    public class MsgGrantAuthorizationValueArgs : MsgGrantAuthorizationCommonArgs
    {
        public AuthorizationGrantAminoArgs Grant { get; set; }
    }

    public class MsgGrantAuthorizationDataArgs : MsgGrantAuthorizationCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public AuthorizationGrantDataArgs Grant { get; set; }

        public MsgGrantAuthorizationDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_MSG_GRANT;
        }
    }

    public class MsgGrantAuthorizationCommonArgs
    {
        public string Grantee { get; set; }
        public string Granter { get; set; }

    }
}
