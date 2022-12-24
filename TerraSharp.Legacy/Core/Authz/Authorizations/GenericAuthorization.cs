using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Authz.Msgs;
using TerraSharp.Core.Constants;
using TerraSharp.Key.Data.SimplePublicKey;
using COMB = TerraProto.CSharp.third_party.proto.cosmos.authz.v1beta1;

namespace TerraSharp.Core.Authz.Authorizations
{
    public class GenericAuthorization
    {
        public readonly string msg;
        public GenericAuthorization(string msg)
        {
            this.msg = msg;
        }

        public static GenericAuthorization FromAmino(GenericAuthorizationAminoArgs data)
        {
            return new GenericAuthorization(data.Value.Msg);
        }

        public static GenericAuthorization FromData(GenericAuthorizationDataArgs data)
        {
            return new GenericAuthorization(data.Msg);
        }

        public static GenericAuthorization FromProto(COMB.GenericAuthorization data)
        {
            return new GenericAuthorization(data.Msg);
        }

        public GenericAuthorizationAminoArgs ToAmino()
        {
            return new GenericAuthorizationAminoArgs()
            {
                Value = new GenericAuthorizationAminoValueArgs()
                {
                    Msg = this.msg,
                }
            };
        }
        public GenericAuthorizationDataArgs ToData()
        {
            return new GenericAuthorizationDataArgs()
            {
                Msg = this.msg,
            };
        }

        public COMB.GenericAuthorization ToProtoWithType()
        {
            return new COMB.GenericAuthorization()
            {
                Msg = this.msg
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static GenericAuthorization UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<COMB.GenericAuthorization>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_GENERIC_AUTHORIZATION,
                Value = this.ToProto()
            };
        }
    }

    public class GenericAuthorizationAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public GenericAuthorizationAminoValueArgs Value { get; set; }

        public GenericAuthorizationAminoArgs()
        {
            this.Type = AuthConstants.GENERIC_AUTHORIZATION;
        }
    }

    public class GenericAuthorizationAminoValueArgs
    {
        public string Msg { get; set; }
    }

    public class GenericAuthorizationDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Msg { get; set; }
        public GenericAuthorizationDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_GENERIC_AUTHORIZATION;
        }
    }
}
