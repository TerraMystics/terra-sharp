using Newtonsoft.Json;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Terra.Microsoft.Client.Core.Constants;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Connection
{
    public class MsgConnectionOpenInit : SignerData
    {
        public readonly string client_id;
        public readonly Counterparty counterparty;
        public readonly Version version;
        public readonly double delay_period;
        public readonly string signer;

        public MsgConnectionOpenInit(
            string client_id,
            Counterparty counterparty,
            Version version,
            double delay_period,
            string signer)
        {
            this.client_id = client_id;
            this.counterparty = counterparty;
            this.version = version;
            this.delay_period = delay_period;
            this.signer = signer;
        }

        public static MsgConnectionOpenInit FromData(MsgConnectionOpenInitDataArgs data)
        {
            return new MsgConnectionOpenInit(
                data.client_id,
                Counterparty.FromData(data.Counterparty),
                Version.FromData(data.Version),
                double.Parse(data.Delay_Period),
                data.Signer);
        }

        public static MsgConnectionOpenInit FromProto(PROTO.MsgConnectionOpenInit data)
        {
            return new MsgConnectionOpenInit(
                 data.ClientId,
                 Counterparty.FromProto(data.Counterparty),
                 Version.FromProto(data.Version),
                 data.DelayPeriod,
                 data.Signer);
        }

        public MsgConnectionOpenInitDataArgs ToData()
        {
            return new MsgConnectionOpenInitDataArgs()
            {
                client_id = this.client_id,
                Counterparty = this.counterparty.ToData(),
                Version = this.version.ToData(),
                Delay_Period = this.delay_period.ToString(),
                Signer = this.signer
            };
        }

        public PROTO.MsgConnectionOpenInit ToProtoWithType()
        {
            return new PROTO.MsgConnectionOpenInit()
            {
                ClientId = this.client_id,
                Counterparty = this.counterparty.ToProtoWithType(),
                DelayPeriod = (ulong)this.delay_period,
                Signer = this.signer,
                Version = this.version.ToProtoWithType(),
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MsgConnectionOpenInitDataArgs : MsgConnectionOpenInitCommonArgs
    {
        public CounterpartyDataArgs Counterparty { get; set; }
        public VersionDataArgs Version { get; set; }
        public MsgConnectionOpenInitDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CONNECTION_MSG_OPEN_INIT;
        }
    }

    public class MsgConnectionOpenInitCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string client_id { get; set; }
        public string Signer { get; set; }
        public string Delay_Period { get; set; }
    }
}
