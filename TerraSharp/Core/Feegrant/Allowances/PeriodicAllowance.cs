using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.StringExt;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.feegrant.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.bank.v1beta1;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Terra.Microsoft.Client.Core.Feegrant.Allowances
{
    public class PeriodicAllowance
    {
        public readonly List<Coin> period_spend_limit;
        public readonly List<Coin> period_can_spend;

        public readonly BasicAllowance basic;
        public readonly TimeSpan period;
        public readonly DateTime period_reset;

        public PeriodicAllowance(
            List<Coin> period_spend_limit,
            List<Coin> period_can_spend,
            BasicAllowance basic,
            TimeSpan period,
            DateTime period_reset)
        {
            this.basic = basic;
            this.period = period;
            this.period_reset = period_reset;

            this.period_spend_limit = period_spend_limit;
            this.period_can_spend = period_can_spend;
        }

        public static PeriodicAllowance FromAmino(PeriodicAllowanceAminoArgs data)
        {
            //return new PeriodicAllowance(
            //    CoinsExtensions.FromAmino(data.Value.Period_spend_limit).ToList(),
            //    CoinsExtensions.FromAmino(data.Value.Period_can_spend).ToList(),
            //    data.Value.Basic,
            //    TimeSpan.FromDays(data.Value.Period),
            //    data.Value.Period_Reset.GetISODateTimeFromString());
            throw new NotImplementedException("");
        }

        public static PeriodicAllowance FromData(PeriodicAllowanceDataArgs data)
        {
            //return new PeriodicAllowance(
            //    CoinsExtensions.FromData(data.Period_spend_limit).ToList(),
            //    CoinsExtensions.FromData(data.Period_can_spend).ToList(),
            //    data.Basic,
            //    TimeSpan.FromDays(data.Period),
            //    data.Period_Reset.GetISODateTimeFromString());
            throw new NotImplementedException("");
        }

        public static PeriodicAllowance FromProto(PROTO.PeriodicAllowance data)
        {
            return new PeriodicAllowance(
                CoinsExtensions.FromProto(data.PeriodSpendLimits).ToList(),
                CoinsExtensions.FromProto(data.PeriodCanSpends).ToList(),
                BasicAllowance.FromProto(data.Basic),
                data.Period.Value,
                data.PeriodReset.Value);
        }

        public PeriodicAllowanceAminoArgs ToAmino()
        {
            return new PeriodicAllowanceAminoArgs()
            {
                Value = new PeriodicAllowanceValueAminoArgs()
                {
                    Period_spend_limit = CoinsExtensions.ToAmino(this.period_spend_limit).ToArray(),
                    Period_can_spend = CoinsExtensions.ToAmino(this.period_can_spend).ToArray(),
                    Period_Reset = TerraStringExtensions.GetISOStringFromDate(this.period_reset),
                    Basic = this.basic,
                //    Period = this.period
                }
            };
        }

        public PeriodicAllowanceDataArgs ToData()
        {
            return new PeriodicAllowanceDataArgs()
            {
                Period_spend_limit = CoinsExtensions.ToData(this.period_spend_limit).ToArray(),
                Period_can_spend = CoinsExtensions.ToData(this.period_can_spend).ToArray(),
                Period_Reset = TerraStringExtensions.GetISOStringFromDate(this.period_reset),
                Basic = this.basic,
         //       Period = this.period.TotalDays
            };
        }

        public PROTO.PeriodicAllowance ToProtoWithType()
        {
            return new PROTO.PeriodicAllowance()
            {
                Basic = this.basic.ToProtoWithType(),
                Period = this.period,
                PeriodCanSpends = CoinsExtensions.ToProto(this.period_can_spend).ToList(),
                PeriodSpendLimits = CoinsExtensions.ToProto(this.period_spend_limit).ToList(),
                PeriodReset = this.period_reset
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
                TypeUrl = CosmosConstants.COSMOS_FEEGRANT_PERIODIC_ALLOWANCE,
                Value = this.ToProto()
            };
        }

        public static PeriodicAllowance UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.PeriodicAllowance>(msgAny.Value));
        }
    }

    public class PeriodicAllowanceAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public PeriodicAllowanceValueAminoArgs Value { get; set; }
        public PeriodicAllowanceAminoArgs()
        {
            this.Type = FeeGrantConstants.PERIODIC_MSG_ALLOWANCE;
        }
    }

    public class PeriodicAllowanceValueAminoArgs
    {
        public CoinAminoArgs[] Period_spend_limit;
        public CoinAminoArgs[] Period_can_spend;

        public BasicAllowance Basic;
        public string Period;
        public string Period_Reset;
    }

    public class PeriodicAllowanceDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public CoinDataArgs[] Period_spend_limit;
        public CoinDataArgs[] Period_can_spend;

        public BasicAllowance Basic;
        public string Period;
        public string Period_Reset;

        public PeriodicAllowanceDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_FEEGRANT_PERIODIC_ALLOWANCE;
        }
    }
}
