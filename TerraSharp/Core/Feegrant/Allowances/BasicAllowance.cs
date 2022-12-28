using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.feegrant.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Terra.Microsoft.Client.Core.Feegrant.Allowances
{
    public class BasicAllowance
    {
        public readonly List<Coin> spend_limit;
        public readonly DateTime? expiration;

        public BasicAllowance(List<Coin> spend_limit, DateTime? expiration)
        {
            this.spend_limit = spend_limit;
            this.expiration = expiration;
        }

        public static BasicAllowance FromAmino(BasicAllowanceAminoArgs data)
        {
            return new BasicAllowance(CoinsExtensions.FromAmino(data.Value.Spend_Limit).ToList(), data.Value.Expiration.GetISODateTimeFromString());
        }

        public static BasicAllowance FromData(BasicAllowanceDataArgs data)
        {
            return new BasicAllowance(CoinsExtensions.FromData(data.Spend_Limit).ToList(), data.Expiration.GetISODateTimeFromString());
        }

        public static BasicAllowance FromProto(PROTO.BasicAllowance data)
        {
            return new BasicAllowance(CoinsExtensions.FromProto(data.SpendLimits).ToList(), data.Expiration.Value);
        }

        public BasicAllowanceAminoArgs ToAmino()
        {
            return new BasicAllowanceAminoArgs()
            {
                Value = new BasicAllowanceValueAminoArgs()
                {
                    Spend_Limit = CoinsExtensions.ToAmino(this.spend_limit).ToArray(),
                    Expiration = TerraStringExtensions.GetISOStringFromDate(this.expiration.Value),
                }
            };
        }

        public BasicAllowanceDataArgs ToData()
        {
            return new BasicAllowanceDataArgs()
            {
                Spend_Limit = CoinsExtensions.ToData(this.spend_limit).ToArray(),
                Expiration = TerraStringExtensions.GetISOStringFromDate(this.expiration.Value),
            };
        }

        public PROTO.BasicAllowance ToProtoWithType()
        {
            return new PROTO.BasicAllowance()
            {
                Expiration = this.expiration,
                SpendLimits = CoinsExtensions.ToProto(this.spend_limit).ToList()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_FEEGRANT_BASIC_ALLOWANCE,
                Value = this.ToProto()
            };
        }

        public static BasicAllowance UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.BasicAllowance>(msgAny.Value));
        }
    }

    public class BasicAllowanceAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public BasicAllowanceValueAminoArgs Value { get; set; }
        public BasicAllowanceAminoArgs()
        {
            this.Type = FeeGrantConstants.BASIC_ALLOWANCE;
        }
    }

    public class BasicAllowanceValueAminoArgs
    {
        public CoinAminoArgs[] Spend_Limit { get; set; }
        public string Expiration { get; set; }
    }

    public class BasicAllowanceDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public CoinDataArgs[] Spend_Limit { get; set; }
        public string Expiration { get; set; }

        public BasicAllowanceDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_FEEGRANT_BASIC_ALLOWANCE;
        }
    }
}
