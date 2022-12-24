using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.connection.v1;
using TerraSharp.Core.IBC.Msgs.Client;
using TerraNetExtensions.StringExt;
using Google.Protobuf.WellKnownTypes;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.IBC.Msgs.Connection
{
    public class MsgConnectionOpenAck : SignerData
    {
        public readonly string connection_id;
        public readonly string counterparty_connection_id;
        public readonly Version version;
        public readonly Any client_state;
        public readonly Height proof_height;
        public readonly string proof_try;
        public readonly string proof_client;
        public readonly string proof_consensus;
        public readonly Height consensus_height;
        public readonly string signer;

        public MsgConnectionOpenAck(
            string connection_id,
            string counterparty_connection_id,
            Version version,
            Any client_state,
            Height proof_height,
            string proof_try,
            string proof_client,
            string proof_consensus,
            Height consensus_height,
            string signer)
        {
            this.connection_id = connection_id;
            this.counterparty_connection_id = counterparty_connection_id;
            this.version = version;
            this.client_state = client_state;
            this.proof_height = proof_height;
            this.proof_try = proof_try;
            this.proof_client = proof_client;
            this.proof_consensus = proof_consensus;
            this.consensus_height = consensus_height;
            this.signer = signer;
        }

        public static MsgConnectionOpenAck FromData(MsgConnectionOpenAckDataArgs data)
        {
            return new MsgConnectionOpenAck(
               data.Connection_id,
               data.Counterparty_Connection_Id,
               Version.FromData(data.Version),
               data.Client_State,
               Height.FromData(data.Proof_Height),
               data.Proof_Try,
               data.Proof_Client,
               data.Proof_Consensus,
               Height.FromData(data.Consensus_Height),
               data.Signer);
        }

        public static MsgConnectionOpenAck FromProto(PROTO.MsgConnectionOpenAck data)
        {
            return new MsgConnectionOpenAck(
                data.ConnectionId,
                data.CounterpartyConnectionId,
                Version.FromProto(data.Version),
                data.ClientState,
                Height.FromProto(data.ProofHeight),
                TerraStringExtensions.GetBase64FromBytes(data.ProofTry),
                TerraStringExtensions.GetBase64FromBytes(data.ProofClient),
                TerraStringExtensions.GetBase64FromBytes(data.ProofConsensus),
                Height.FromProto(data.ConsensusHeight),
                data.Signer);
        }

        public MsgConnectionOpenAckDataArgs ToData()
        {
            return new MsgConnectionOpenAckDataArgs()
            {
                Client_State = this.client_state,
                Connection_id = this.connection_id,
                Consensus_Height = this.consensus_height.ToData(),
                Counterparty_Connection_Id = counterparty_connection_id,
                Proof_Client = this.proof_client,
                Proof_Consensus = this.proof_consensus,
                Proof_Height = this.proof_height.ToData(),
                Proof_Try = this.proof_try,
                Signer = this.signer,
                Version = this.version.ToData()
            };
        }

        public PROTO.MsgConnectionOpenAck ToProtoWithType()
        {
            return new PROTO.MsgConnectionOpenAck()
            {
                ConnectionId = this.connection_id,
                CounterpartyConnectionId = this.counterparty_connection_id,
                ProofTry = TerraStringExtensions.GetBase64BytesFromString(this.proof_try),
                Version = this.version.ToProtoWithType(),
                ClientState = this.client_state,
                ConsensusHeight = this.consensus_height.ToProtoWithType(),
                ProofClient = TerraStringExtensions.GetBase64BytesFromString(this.proof_client),
                ProofConsensus = TerraStringExtensions.GetBase64BytesFromString(this.proof_consensus),
                ProofHeight = this.proof_height.ToProtoWithType(),
                Signer = this.signer,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MsgConnectionOpenAckDataArgs : MsgConnectionOpenAckCommonArgs
    {
        public VersionDataArgs Version { get; set; }
        public HeightDataArgs Proof_Height { get; set; }
        public HeightDataArgs Consensus_Height { get; set; }

        public MsgConnectionOpenAckDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CONNECTION_MSG_OPEN_ACK;
        }
    }

    public class MsgConnectionOpenAckCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Connection_id { get; set; }
        public string Counterparty_Connection_Id { get; set; }
        public Any Client_State { get; set; }
        public string Proof_Try { get; set; }
        public string Proof_Client { get; set; }
        public string Proof_Consensus { get; set; }
        public string Signer { get; set; }
    }
}
