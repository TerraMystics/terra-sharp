using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Client.Core.IBC.Msgs.Client;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Connection
{
    public class MsgConnectionOpenConfirm : SignerData
    {
        public readonly string connection_id;
        public readonly string proof_ack;
        public readonly Height proof_height;
        public readonly string signer;

        public MsgConnectionOpenConfirm(
            string connection_id,
            string proof_ack,
            Height proof_height,
            string signer)
        {
            this.connection_id = connection_id;
            this.proof_ack = proof_ack;
            this.proof_height = proof_height;
            this.signer = signer;
        }

        public static MsgConnectionOpenConfirm FromData(MsgConnectionOpenConfirmDataArgs data)
        {
            return new MsgConnectionOpenConfirm(
                data.Connection_id,
                data.Proof_Ack,
                Height.FromData(data.Proof_Height),
                data.Signer);
        }

        public static MsgConnectionOpenConfirm FromProto(PROTO.MsgConnectionOpenConfirm data)
        {
            return new MsgConnectionOpenConfirm(
                data.ConnectionId,
                TerraStringExtensions.GetBase64FromBytes(data.ProofAck),
                Height.FromProto(data.ProofHeight),
                data.Signer);
        }

        public MsgConnectionOpenConfirmDataArgs ToData()
        {
            return new MsgConnectionOpenConfirmDataArgs()
            {
                Connection_id = this.connection_id,
                Proof_Ack = this.proof_ack,
                Proof_Height = this.proof_height.ToData(),
                Signer = this.signer
            };
        }

        public PROTO.MsgConnectionOpenConfirm ToProtoWithType()
        {
            return new PROTO.MsgConnectionOpenConfirm()
            {
                Signer = this.signer,
                ConnectionId = this.connection_id,
                ProofAck = TerraStringExtensions.GetBase64BytesFromString(this.proof_ack),
                ProofHeight = this.proof_height.ToProtoWithType()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }


    public class MsgConnectionOpenConfirmDataArgs : MsgConnectionOpenConfirmCommonArgs
    {
        public HeightDataArgs Proof_Height { get; set; }
        public MsgConnectionOpenConfirmDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_IBC_CONNECTION_MSG_OPEN_CONFIRM;
        }
    }

    public class MsgConnectionOpenConfirmCommonArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Connection_id { get; set; }
        public string Proof_Ack { get; set; }
        public string Signer { get; set; }
    }
}
