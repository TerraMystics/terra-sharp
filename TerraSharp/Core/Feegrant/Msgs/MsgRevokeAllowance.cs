using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.feegrant.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Feegrant.Allowances;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Feegrant.Msgs
{
    public class MsgRevokeAllowance : SignerData
    {
        public readonly string granter;
        public readonly string grantee;

        public MsgRevokeAllowance(string granter, string grantee)
        {
            this.granter = granter;
            this.grantee = grantee;
        }

        public static MsgRevokeAllowance FromAmino(MsgRevokeAllowanceAminoArgs data)
        {
            return new MsgRevokeAllowance(data.Value.Granter, data.Value.Grantee);
        }

        public static MsgRevokeAllowance FromData(MsgRevokeAllowanceDataArgs data)
        {
            return new MsgRevokeAllowance(data.Granter, data.Grantee);
        }

        public static MsgRevokeAllowance FromProto(PROTO.MsgRevokeAllowance data)
        {
            return new MsgRevokeAllowance(data.Granter, data.Grantee);
        }

        public MsgRevokeAllowanceAminoArgs ToAmino()
        {
            return new MsgRevokeAllowanceAminoArgs()
            {
                Value = new MsgRevokeAllowanceValueAminoArgs()
                {
                    Grantee = this.grantee,
                    Granter = this.granter,
                }
            };
        }

        public MsgRevokeAllowanceDataArgs ToData()
        {
            return new MsgRevokeAllowanceDataArgs()
            {
                Grantee = this.grantee,
                Granter = this.granter,
            };
        }

        public PROTO.MsgRevokeAllowance ToProtoWithType()
        {
            return new PROTO.MsgRevokeAllowance()
            {
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
                TypeUrl = CosmosConstants.COSMOS_FEEGRANT_MSG_REVOKE_ALLOWANCE,
                Value = this.ToProto()
            };
        }

        public static MsgRevokeAllowance UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgRevokeAllowance>(msgAny.Value));
        }
    }

    public class MsgRevokeAllowanceAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgRevokeAllowanceValueAminoArgs Value { get; set; }
        public MsgRevokeAllowanceAminoArgs()
        {
            this.Type = FeeGrantConstants.MSG_REVOKE_ALLOWANCE;
        }
    }

    public class MsgRevokeAllowanceValueAminoArgs
    {
        public string Grantee { get; set; }
        public string Granter { get; set; }
    }

    public class MsgRevokeAllowanceDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Grantee { get; set; }
        public string Granter { get; set; }

        public MsgRevokeAllowanceDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_FEEGRANT_MSG_REVOKE_ALLOWANCE;
        }
    }
}
