using PC = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.authz.v1beta1;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.bank.v1beta1;
using COMB = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.authz.v1beta1;
using STAKE = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;
using Google.Protobuf.WellKnownTypes;
using System;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.Authz.Authorizations
{
    public class AuthorizationGrant
    {
        public readonly object authorization;
        public readonly DateTime expiration;

        public AuthorizationGrant(object authorization, DateTime expiration)
        {
            this.authorization = authorization;
            this.expiration = expiration;
        }

        public static AuthorizationGrant FromAmino(AuthorizationGrantAminoArgs data, AuthorizationGrantType grantType)
        {
            return new AuthorizationGrant(AuthorizationExtensionsHelper.FromAmino(data, grantType), DateTime.Parse(data.Expiration));
        }

        public static AuthorizationGrant FromData(AuthorizationGrantDataArgs data, AuthorizationGrantType grantType)
        {
            return new AuthorizationGrant(AuthorizationExtensionsHelper.FromData(data, grantType), DateTime.Parse(data.Expiration));
        }

        public static AuthorizationGrant FromProto(PC.Grant data, AuthorizationGrantType grantType)
        {
            return new AuthorizationGrant(AuthorizationExtensionsHelper.FromProto(data, grantType), data.Expiration.Value);
        }

        public AuthorizationGrantAminoArgs ToAmino()
        {
            return new AuthorizationGrantAminoArgs()
            {
                Authorization = authorization,
                Expiration = this.expiration.GetISOStringFromDate(),
            };
        }

        public AuthorizationGrantDataArgs ToData()
        {
            return new AuthorizationGrantDataArgs()
            {
                Authorization = authorization,
                Expiration = this.expiration.GetISOStringFromDate(),
            };
        }

        public PC.Grant ToProtoWithType()
        {
            Any cauth;
            if (this.authorization.GetType() == typeof(GenericAuthorization))
            {
                cauth = ((GenericAuthorization)this.authorization).PackAny();
            }
            else if (this.authorization.GetType() == typeof(SendAuthorization))
            {
                cauth = ((SendAuthorization)this.authorization).PackAny();
            }
            else
            {
                cauth = ((StakeAuthorization)this.authorization).PackAny();
            }

            return new PC.Grant()
            {
                Authorization = cauth,
                Expiration = this.expiration
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class AuthorizationGrantAminoArgs
    {
        public object Authorization { get; set; }
        public string Expiration { get; set; }
    }

    public class AuthorizationGrantDataArgs
    {
        public object Authorization { get; set; }
        public string Expiration { get; set; }
    }

    public static class AuthorizationExtensionsHelper
    {
        public static object FromAmino(object data, AuthorizationGrantType grantType)
        {
            if (grantType == AuthorizationGrantType.SendAuthorization)
            {
                return SendAuthorization.FromAmino(data as SendAuthorizationAminoArgs);
            }
            else
            {
                return GenericAuthorization.FromAmino(data as GenericAuthorizationAminoArgs);
            }
        }

        public static object FromData(object data, AuthorizationGrantType grantType)
        {
            if (grantType == AuthorizationGrantType.SendAuthorization)
            {
                return SendAuthorization.FromData(data as SendAuthorizationDataArgs);
            }
            else if (grantType == AuthorizationGrantType.GenericAuthorization)
            {
                return GenericAuthorization.FromData(data as GenericAuthorizationDataArgs);
            }
            else
            {
                return StakeAuthorization.FromData(data as StakeAuthorizationDataArgs);
            }
        }

        public static object FromProto(object data, AuthorizationGrantType grantType)
        {
            if (grantType == AuthorizationGrantType.SendAuthorization)
            {
                return SendAuthorization.FromProto(data as PROTO.SendAuthorization);
            }
            else if (grantType == AuthorizationGrantType.GenericAuthorization)
            {
                return GenericAuthorization.FromProto(data as COMB.GenericAuthorization);
            }
            else
            {
                return StakeAuthorization.FromProto(data as STAKE.StakeAuthorization);
            }
        }
    }

    public enum AuthorizationGrantType
    {
        SendAuthorization = 0,
        GenericAuthorization = 1,
        StakeAuthorization = 2
    }
}
