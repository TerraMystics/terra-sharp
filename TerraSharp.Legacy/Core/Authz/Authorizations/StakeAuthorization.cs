using Google.Protobuf.WellKnownTypes;
using STAKE = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using static TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1.StakeAuthorization;
using Newtonsoft.Json;
using System.Linq;

namespace TerraSharp.Core.Authz.Authorizations
{
    public class StakeAuthorization
    {
        public readonly STAKE.AuthorizationType authorization_type;
        public readonly Coin max_tokens;
        public readonly StakeAuthorizationValidators allow_list;
        public readonly StakeAuthorizationValidators deny_list;

        public StakeAuthorization(
            STAKE.AuthorizationType authorization_type,
            Coin max_tokens,
            StakeAuthorizationValidators allow_list,
            StakeAuthorizationValidators deny_list)
        {
            this.authorization_type = authorization_type;
            this.max_tokens = max_tokens;
            this.allow_list = allow_list;
            this.deny_list = deny_list;
        }

        public static StakeAuthorization FromData(StakeAuthorizationDataArgs data)
        {
            return new StakeAuthorization(
                data.AuthorizationType,
                Coin.FromData(data.MaxTokens),
                StakeAuthorizationValidators.FromData(data.Allow_list),
                StakeAuthorizationValidators.FromData(data.Deny_list));
        }

        public static StakeAuthorization FromProto(STAKE.StakeAuthorization data)
        {
            return new StakeAuthorization(
               data.AuthorizationType,
                Coin.FromProto(data.MaxTokens),
                StakeAuthorizationValidators.FromProto(data.AllowList),
                StakeAuthorizationValidators.FromProto(data.DenyList));
        }

        public StakeAuthorizationDataArgs ToData()
        {
            return new StakeAuthorizationDataArgs()
            {
                Allow_list = this.allow_list.ToData(),
                AuthorizationType = this.authorization_type,
                Deny_list = this.deny_list.ToData(),
                MaxTokens = this.max_tokens.ToData()
            };
        }

        public STAKE.StakeAuthorization ToProtoWithType()
        {
            return new STAKE.StakeAuthorization()
            {
                AllowList = this.allow_list.ToProtoWithType(),
                AuthorizationType = this.authorization_type,
                DenyList = this.deny_list.ToProtoWithType(),
                MaxTokens = this.max_tokens.ToProtoWithType()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static StakeAuthorization UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<STAKE.StakeAuthorization>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_STAKE_AUTHORIZATION,
                Value = this.ToProto()
            };
        }
    }

    public class StakeAuthorizationDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public STAKE.AuthorizationType AuthorizationType;
        public CoinDataArgs MaxTokens;
        public StakeAuthorizationValidatorsDataArgs Allow_list;
        public StakeAuthorizationValidatorsDataArgs Deny_list;

        public StakeAuthorizationDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_STAKE_AUTHORIZATION;
        }
    }

    public class StakeAuthorizationValidators
    {
        public readonly string[] address;
        public StakeAuthorizationValidators(string[] address)
        {
            this.address = address;
        }

        public static StakeAuthorizationValidators FromData(StakeAuthorizationValidatorsDataArgs data)
        {
            return new StakeAuthorizationValidators(data.Address);
        }

        public static StakeAuthorizationValidators FromProto(Validators data)
        {
            return new StakeAuthorizationValidators(data.Addresses.ToArray());
        }

        public StakeAuthorizationValidatorsDataArgs ToData()
        {
            return new StakeAuthorizationValidatorsDataArgs()
            {
                Address = this.address,
            };
        }

        public Validators ToProtoWithType()
        {
            return new Validators()
            {
                Addresses = this.address.ToList()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

    }
    public class StakeAuthorizationValidatorsDataArgs
    {
        public string[] Address { get; set; }
        public StakeAuthorizationValidatorsDataArgs()
        {
        }
    }
}
