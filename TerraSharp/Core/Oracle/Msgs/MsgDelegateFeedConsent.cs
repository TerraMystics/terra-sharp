using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.oracle.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Oracle.Msgs
{
    public class MsgDelegateFeedConsent : SignerData
    {
        public readonly string coperator;
        public readonly string cdelegate;

        public MsgDelegateFeedConsent(
            string coperator,
            string cdelegate)
        {
            this.coperator = coperator;
            this.cdelegate = cdelegate;
        }

        public static MsgDelegateFeedConsent FromAmino(MsgDelegateFeedConsentAminoArgs data)
        {
            return new MsgDelegateFeedConsent(data.Value.COperator, data.Value.CDelegate);
        }

        public static MsgDelegateFeedConsent FromData(MsgDelegateFeedConsentDataArgs data)
        {
            return new MsgDelegateFeedConsent(data.COperator, data.CDelegate);
        }

        public static MsgDelegateFeedConsent FromProto(PROTO.MsgDelegateFeedConsent data)
        {
            return new MsgDelegateFeedConsent(data.Operator, data.Delegate);
        }

        public MsgDelegateFeedConsentAminoArgs ToAmino()
        {
            return new MsgDelegateFeedConsentAminoArgs()
            {
                Value = new MsgDelegateFeedConsentValueAminoArgs()
                {
                    COperator = this.coperator,
                    CDelegate = this.cdelegate
                }
            };
        }

        public MsgDelegateFeedConsentDataArgs ToData()
        {
            return new MsgDelegateFeedConsentDataArgs()
            {
                COperator = this.coperator,
                CDelegate = this.cdelegate
            };
        }

        public PROTO.MsgDelegateFeedConsent ToProtoWithType()
        {
            return new PROTO.MsgDelegateFeedConsent()
            {
                Delegate = this.cdelegate,
                Operator = this.coperator
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
                TypeUrl = TerraConstants.TERRA_ORACLE_EXCHANGE_DELEGATE_FEED_CONSENT,
                Value = this.ToProto()
            };
        }

        public static MsgDelegateFeedConsent UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgDelegateFeedConsent>(msgAny.Value));
        }
    }

    public class MsgDelegateFeedConsentAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgDelegateFeedConsentValueAminoArgs Value { get; set; }
        public MsgDelegateFeedConsentAminoArgs()
        {
            this.Type = OracleConstants.ORACLE_MSG_AGGREGATE_EXCHANGE_DELEGATE_FEED_CONSENT;
        }
    }

    public class MsgDelegateFeedConsentValueAminoArgs
    {
        public string COperator { get; set; }
        public string CDelegate { get; set; }
    }

    public class MsgDelegateFeedConsentDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string COperator { get; set; }
        public string CDelegate { get; set; }

        public MsgDelegateFeedConsentDataArgs()
        {
            this.Type = TerraConstants.TERRA_ORACLE_EXCHANGE_DELEGATE_FEED_CONSENT;
        }
    }
}
