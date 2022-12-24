using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.bank.v1beta1;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Extensions;
using TerraNetExtensions.ProtoBufs;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Core.Authz.Authorizations
{
    public class SendAuthorization
    {
        public List<Coin> spend_limit;
        public SendAuthorization(List<Coin> spend_limit)
        {
            this.spend_limit = spend_limit;
        }

        public static SendAuthorization FromAmino(SendAuthorizationAminoArgs data)
        {
            return new SendAuthorization(CoinsExtensions.FromAmino(data.Value.Spend_limit.ConvertAll(w => w.ToAmino())).ToList());
        }

        public static SendAuthorization FromData(SendAuthorizationDataArgs data)
        {
            return new SendAuthorization(CoinsExtensions.FromData(data.Spend_limit.ConvertAll(w => w.ToData())).ToList());
        }

        public static SendAuthorization FromProto(PROTO.SendAuthorization data)
        {
            return new SendAuthorization(CoinsExtensions.FromProto(data.SpendLimits).ToList());
        }

        public SendAuthorizationAminoArgs ToAmino()
        {
            return new SendAuthorizationAminoArgs()
            {
                Value = new SendAuthorizationValueArgs()
                {
                    Spend_limit = this.spend_limit
                }
            };
        }

        public SendAuthorizationDataArgs ToData()
        {
            return new SendAuthorizationDataArgs()
            {
                Spend_limit = this.spend_limit
            };
        }

        public PROTO.SendAuthorization ToProtoWithType()
        {
            return new PROTO.SendAuthorization()
            {
                SpendLimits = CoinsExtensions.ToProto(this.spend_limit).ToList()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static SendAuthorization UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.SendAuthorization>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_SEND_AUTHORIZATION,
                Value = this.ToProto()
            };
        }
    }

    public class SendAuthorizationAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public SendAuthorizationValueArgs Value { get; set; }

        public SendAuthorizationAminoArgs()
        {
            this.Type = AuthConstants.SEND_AUTHORIZATION;
        }
    }

    public class SendAuthorizationValueArgs
    {
        public List<Coin> Spend_limit { get; set; }
    }

    public class SendAuthorizationDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public List<Coin> Spend_limit { get; set; }
        public SendAuthorizationDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_SEND_AUTHORIZATION;
        }
    }
}
