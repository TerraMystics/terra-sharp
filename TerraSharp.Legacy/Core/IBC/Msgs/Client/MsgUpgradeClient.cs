using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.client.v1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.StringExt;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.IBC.Msgs.Client
{
    public class MsgUpgradeClient : SignerData
    {
        public readonly string client_id;
        public readonly Any client_state;
        public readonly Any consensus_state;
        public readonly string proof_upgrade_client;
        public readonly string proof_upgrade_consensus_state;
        public readonly string signer;

        public MsgUpgradeClient(
            string client_id,
            Any client_state,
            Any consensus_state,
            string proof_upgrade_client,
            string proof_upgrade_consensus_state,
            string signer)
        {
            this.client_id = client_id;
            this.client_state = client_state;
            this.consensus_state = consensus_state;
            this.proof_upgrade_client = proof_upgrade_client;
            this.proof_upgrade_consensus_state = proof_upgrade_consensus_state;
            this.signer = signer;
        }

        public static MsgUpgradeClient FromData(MsgUpgradeClientDataArgs data)
        {
            return new MsgUpgradeClient(
                data.Client_id,
                data.Client_State,
                data.Consensus_State,
                data.Proof_Upgrade_Client,
                data.Proof_Upgrade_Consensus_State,
                data.Signer);
        }

        public static MsgUpgradeClient FromProto(PROTO.MsgUpgradeClient data)
        {
            return new MsgUpgradeClient(
                data.ClientId,
                data.ClientState,
                data.ConsensusState,
                TerraStringExtensions.GetBase64FromBytes(data.ProofUpgradeClient),
                TerraStringExtensions.GetBase64FromBytes(data.ProofUpgradeConsensusState),
                data.Signer);
        }

        public MsgUpgradeClientDataArgs ToData()
        {
            return new MsgUpgradeClientDataArgs()
            {
                Client_id = this.client_id,
                Client_State = this.client_state,
                Consensus_State = this.consensus_state,
                Proof_Upgrade_Client = this.proof_upgrade_client,
                Proof_Upgrade_Consensus_State = this.proof_upgrade_consensus_state,
                Signer = this.signer,
            };
        }

        public PROTO.MsgUpgradeClient ToProtoWithType()
        {
            return new PROTO.MsgUpgradeClient()
            {
                ClientId = this.client_id,
                ClientState = this.client_state,
                ConsensusState = this.consensus_state,
                ProofUpgradeClient = TerraStringExtensions.GetBase64BytesFromString(this.proof_upgrade_client),
                ProofUpgradeConsensusState = TerraStringExtensions.GetBase64BytesFromString(this.proof_upgrade_consensus_state),
                Signer = this.signer
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static MsgUpgradeClient UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgUpgradeClient>(msgAny.Value));
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_UPGRADE_CLIENT,
                Value = this.ToProto()
            };
        }
    }

    public class MsgUpgradeClientDataArgs : MsgUpgradeClientCommonArgs
    {
        public MsgUpgradeClientDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CHANNEL_MSG_UPGRADE_CLIENT;
        }
    }

    public class MsgUpgradeClientCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Client_id { get; set; }
        public Any Client_State { get; set; }
        public Any Consensus_State { get; set; }
        public string Proof_Upgrade_Client { get; set; }
        public string Proof_Upgrade_Consensus_State { get; set; }
        public string Signer { get; set; }
    }
}
