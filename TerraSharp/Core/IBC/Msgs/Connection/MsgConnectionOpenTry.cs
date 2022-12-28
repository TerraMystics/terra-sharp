using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Linq;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Constants;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Connection
{
    public class MsgConnectionOpenTry : SignerData
    {
        public readonly string client_id;
        public readonly string previous_connection_id;
        public readonly Any client_state;
        public readonly Counterparty counterparty;
        public readonly Version[] counterparty_versions;
        public readonly double delay_period;
        public readonly Height proof_height;
        public readonly string proof_init;
        public readonly string proof_client;
        public readonly string proof_consensus;
        public readonly Height consensus_height;
        public readonly string signer;

        public MsgConnectionOpenTry(
            string client_id,
            string previous_connection_id,
            Any client_state,
            Counterparty counterparty,
            Version[] counterparty_versions,
            double delay_period,
            Height proof_height,
            string proof_init,
            string proof_client,
            string proof_consensus,
            Height consensus_height,
            string signer)
        {
            this.client_id = client_id;
            this.counterparty = counterparty;
            this.client_state = client_state;
            this.counterparty_versions = counterparty_versions;
            this.proof_height = proof_height;
            this.proof_init = proof_init;
            this.proof_client = proof_client;
            this.proof_consensus = proof_consensus;
            this.consensus_height = consensus_height;
            this.previous_connection_id = previous_connection_id;
            this.delay_period = delay_period;
            this.signer = signer;
        }

        public static MsgConnectionOpenTry FromData(MsgConnectionOpenTryDataArgs data)
        {
            return new MsgConnectionOpenTry(
                data.Client_Id,
                data.Previous_Connection_Id,
                data.Client_State,
                Counterparty.FromData(data.Counterparty),
                data.Counterparty_Versions.ToList().ConvertAll(w => Version.FromData(w)).ToArray(),
                double.Parse(data.Delay_Period),
                Height.FromData(data.Proof_Height),
                data.Proof_Init,
                data.Proof_Client,
                data.Proof_Consensus,
                Height.FromData(data.Consensus_Height),
                data.Signer);
        }

        public static MsgConnectionOpenTry FromProto(PROTO.MsgConnectionOpenTry data)
        {
            return new MsgConnectionOpenTry(
                data.ClientId,
                data.PreviousConnectionId,
                data.ClientState,
                Counterparty.FromProto(data.Counterparty),
                data.CounterpartyVersions.ToList().ConvertAll(w => Version.FromProto(w)).ToArray(),
                data.DelayPeriod,
                Height.FromProto(data.ProofHeight),
                TerraStringExtensions.GetBase64FromBytes(data.ProofInit),
                TerraStringExtensions.GetBase64FromBytes(data.ProofClient),
                TerraStringExtensions.GetBase64FromBytes(data.ProofConsensus),
                Height.FromProto(data.ConsensusHeight),
                data.Signer);
        }

        public MsgConnectionOpenTryDataArgs ToData()
        {
            return new MsgConnectionOpenTryDataArgs()
            {
                Client_Id = this.client_id,
                Client_State = this.client_state,
                Consensus_Height = this.consensus_height.ToData(),
                Proof_Client = this.proof_client,
                Proof_Consensus = this.proof_consensus,
                Previous_Connection_Id = this.previous_connection_id,
                Proof_Height = this.proof_height.ToData(),
                Proof_Init = this.proof_init,
                Counterparty_Versions = this.counterparty_versions.ToList().ConvertAll(w => w.ToData()).ToArray(),
                Counterparty = this.counterparty.ToData(),
                Delay_Period = this.delay_period.ToString(),
                Signer = this.signer,
            };
        }

        public PROTO.MsgConnectionOpenTry ToProtoWithType()
        {
            return new PROTO.MsgConnectionOpenTry()
            {
                ClientId = this.client_id,
                ClientState = this.client_state,
                ConsensusHeight = this.consensus_height.ToProtoWithType(),
                Counterparty = this.counterparty.ToProtoWithType(),
                CounterpartyVersions = this.counterparty_versions.ToList().ConvertAll(w => w.ToProtoWithType()),
                DelayPeriod = (ulong)this.delay_period,
                PreviousConnectionId = this.previous_connection_id,
                ProofClient = TerraStringExtensions.GetBase64BytesFromString(this.proof_client),
                ProofConsensus = TerraStringExtensions.GetBase64BytesFromString(this.proof_consensus),
                ProofHeight = this.proof_height.ToProtoWithType(),
                ProofInit = TerraStringExtensions.GetBase64BytesFromString(this.proof_init),
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MsgConnectionOpenTryDataArgs : MsgConnectionOpenTryCommonArgs
    {
        public CounterpartyDataArgs Counterparty { get; set; }
        public VersionDataArgs[] Counterparty_Versions { get; set; }
        public HeightDataArgs Proof_Height { get; set; }
        public HeightDataArgs Consensus_Height { get; set; }
        public MsgConnectionOpenTryDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CONNECTION_MSG_OPEN_TRY;
        }
    }

    public class MsgConnectionOpenTryCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Client_Id { get; set; }
        public string Previous_Connection_Id { get; set; }
        public Any Client_State { get; set; }
        public string Delay_Period { get; set; }
        public string Proof_Init { get; set; }
        public string Proof_Client { get; set; }
        public string Proof_Consensus { get; set; }
        public string Signer { get; set; }
    }
}
