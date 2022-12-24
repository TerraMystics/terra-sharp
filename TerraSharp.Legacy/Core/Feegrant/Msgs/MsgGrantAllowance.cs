using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.feegrant.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Extensions;
using TerraProto.CSharp.third_party.proto.cosmos.bank.v1beta1;
using TerraSharp.Core.Feegrant.Allowances;
using Newtonsoft.Json;

namespace TerraSharp.Core.Feegrant.Msgs
{
    public class MsgGrantAllowance
    {
        public readonly string granter;
        public readonly string grantee;
        public readonly object allowance;

        public MsgGrantAllowance(string granter, string grantee, object allowance)
        {
            this.granter = granter;
            this.grantee = grantee;
            this.allowance = allowance;
        }

        public static MsgGrantAllowance FromAmino(MsgGrantAllowanceAminoArgs data)
        {
            return new MsgGrantAllowance(data.Value.Granter, data.Value.Grantee, data.Value.Allowance);
        }

        public static MsgGrantAllowance FromData(MsgGrantAllowanceDataArgs data)
        {
            return new MsgGrantAllowance(data.Granter, data.Grantee, data.Allowance);
        }

        public static MsgGrantAllowance FromProto(PROTO.MsgGrantAllowance data)
        {
            return new MsgGrantAllowance(data.Granter, data.Grantee, data.Allowance);
        }

        public MsgGrantAllowanceAminoArgs ToAmino()
        {
            return new MsgGrantAllowanceAminoArgs()
            {
                Value = new MsgGrantAllowanceValueAminoArgs()
                {
                    Allowance = this.allowance,
                    Grantee = this.grantee,
                    Granter = this.granter,
                }
            };
        }

        public MsgGrantAllowanceDataArgs ToData()
        {
            return new MsgGrantAllowanceDataArgs()
            {
                Allowance = this.allowance,
                Grantee = this.grantee,
                Granter = this.granter,
            };
        }

        public PROTO.MsgGrantAllowance ToProtoWithType()
        {
            Any callowance;
            if (this.allowance.GetType() == typeof(BasicAllowance))
            {
                callowance = ((BasicAllowance)this.allowance).PackAny();
            }
            else if (this.allowance.GetType() == typeof(PeriodicAllowance))
            {
                callowance = ((PeriodicAllowance)this.allowance).PackAny();
            }
            else 
            {
                callowance = ((AllowedMessageAllowance)this.allowance).PackAny();
            }

            return new PROTO.MsgGrantAllowance()
            {
                Allowance = callowance,
                Granter = this.granter,
                Grantee = this.grantee
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
                TypeUrl = CosmosConstants.COSMOS_FEEGRANT_MSG_GRANT_ALLOWANCE,
                Value = this.ToProto()
            };
        }

        public static MsgGrantAllowance UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgGrantAllowance>(msgAny.Value));
        }
    }

    public class MsgGrantAllowanceAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgGrantAllowanceValueAminoArgs Value { get; set; }
        public MsgGrantAllowanceAminoArgs()
        {
            this.Type = FeeGrantConstants.MSG_GRANT_ALLOWANCE;
        }
    }

    public class MsgGrantAllowanceValueAminoArgs
    {
        public object Allowance { get; set; }
        public string Grantee { get; set; }
        public string Granter { get; set; }
    }

    public class MsgGrantAllowanceDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public object Allowance { get; set; }
        public string Grantee { get; set; }
        public string Granter { get; set; }

        public MsgGrantAllowanceDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_FEEGRANT_MSG_GRANT_ALLOWANCE;
        }
    }
}
