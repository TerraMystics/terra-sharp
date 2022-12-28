using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.feegrant.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using ALLNCE = Terra.Microsoft.Client.Core.Feegrant.Allowances;
using Terra.Microsoft.Extensions.ProtoBufs;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Terra.Microsoft.Client.Core.Feegrant.Allowances
{
    public class AllowedMessageAllowance
    {
        public readonly object allowance;
        public readonly string[] allowed_messages;

        public AllowedMessageAllowance(object allowance, string[] allowed_messages)
        {
            this.allowance = allowance;
            this.allowed_messages = allowed_messages;
        }

        public static AllowedMessageAllowance FromAmino(AllowedMessageAllowanceAminoArgs data)
        {
            return new AllowedMessageAllowance(data.Value.Allowance, data.Value.Allowed_Messages);
        }

        public static AllowedMessageAllowance FromData(AllowedMessageAllowanceDataArgs data)
        {
            return new AllowedMessageAllowance(data.Allowance, data.Allowed_Messages);
        }

        public static AllowedMessageAllowance FromProto(PROTO.AllowedMsgAllowance data)
        {
            return new AllowedMessageAllowance(data.Allowance, data.AllowedMessages.ToArray());
        }

        public AllowedMessageAllowanceAminoArgs ToAmino()
        {
            return new AllowedMessageAllowanceAminoArgs()
            {
                Value = new AllowedMessageAllowanceValueAminoArgs()
                {
                    Allowance = this.allowance,
                    Allowed_Messages = this.allowed_messages,
                }
            };
        }

        public AllowedMessageAllowanceDataArgs ToData()
        {
            return new AllowedMessageAllowanceDataArgs()
            {
                Allowance = this.allowance,
                Allowed_Messages = this.allowed_messages,
            };
        }

        public PROTO.AllowedMsgAllowance ToProtoWithType()
        {
            Any callowance;
            if (this.allowance.GetType() == typeof(ALLNCE.BasicAllowance))
            {
                callowance = ((ALLNCE.BasicAllowance)this.allowance).PackAny();
            }
            else
            {
                callowance = ((ALLNCE.PeriodicAllowance)this.allowance).PackAny();
            }

            return new PROTO.AllowedMsgAllowance()
            {
                Allowance = callowance,
                AllowedMessages = this.allowed_messages.ToList()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public Any PackAny()
        {
            throw new NotImplementedException("");
        }

        public static AllowedMessageAllowance UnPackAny(Any msgAny)
        {
            throw new NotImplementedException("");

        }
    }

    public class AllowedMessageAllowanceAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public AllowedMessageAllowanceValueAminoArgs Value { get; set; }
        public AllowedMessageAllowanceAminoArgs()
        {
            this.Type = FeeGrantConstants.ALLOWS_MSG_ALLOWANCE;
        }
    }

    public class AllowedMessageAllowanceValueAminoArgs
    {
        public object Allowance;
        public string[] Allowed_Messages;
    }

    public class AllowedMessageAllowanceDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public object Allowance;
        public string[] Allowed_Messages;

        public AllowedMessageAllowanceDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_FEEGRANT_ALLOWED_MSG_ALLOWANCE;
        }
    }
}
