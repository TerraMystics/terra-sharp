using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.proto.wasm.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Wasm.Msgs
{
    public class MsgUpdateContractAdmin : SignerData
    {
        public readonly string admin;
        public readonly string new_admin;
        public readonly string contract;

        public MsgUpdateContractAdmin(
            string admin,
            string contract,
            string new_admin)
        {
            this.admin = admin;
            this.contract = contract;
            this.new_admin = new_admin;
        }

        public static MsgUpdateContractAdmin FromAmino(MsgUpdateContractAdminAminoArgs data)
        {
            return new MsgUpdateContractAdmin(
                data.Value.Admin,
                data.Value.Contract,
                data.Value.New_Admin);
        }

        public static MsgUpdateContractAdmin FromData(MsgUpdateContractAdminDataArgs data)
        {
            return new MsgUpdateContractAdmin(
                data.Admin,
                data.Contract,
                data.New_Admin);
        }

        public static MsgUpdateContractAdmin FromProto(PROTO.MsgUpdateContractAdmin data)
        {
            return new MsgUpdateContractAdmin(
                data.Admin,
                data.Contract,
                data.NewAdmin);
        }

        public MsgUpdateContractAdminAminoArgs ToAmino()
        {
            return new MsgUpdateContractAdminAminoArgs()
            {
                Value = new MsgUpdateContractAdminValueAminoArgs()
                {
                    Admin = this.admin,
                    Contract = this.contract,
                    New_Admin = this.new_admin,
                }
            };
        }

        public MsgUpdateContractAdminDataArgs ToData()
        {
            return new MsgUpdateContractAdminDataArgs()
            {
                Admin = this.admin,
                Contract = this.contract,
                New_Admin = this.new_admin,
            };
        }

        public PROTO.MsgUpdateContractAdmin ToProtoWithType()
        {
            return new PROTO.MsgUpdateContractAdmin()
            {
                Admin = this.admin,
                Contract = this.contract,
                NewAdmin = this.new_admin
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
                TypeUrl = TerraConstants.TERRA_WASM_MSG_UPDATE_CONTRACT_ADMIN,
                Value = this.ToProto()
            };
        }

        public static MsgUpdateContractAdmin UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgUpdateContractAdmin>(msgAny.Value));
        }
    }

    public class MsgUpdateContractAdminAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgUpdateContractAdminValueAminoArgs Value { get; set; }
        public MsgUpdateContractAdminAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_UDPATE_CONTRACT_ADMIN;
        }
    }

    public class MsgUpdateContractAdminValueAminoArgs
    {
        public string Admin { get; set; }
        public string New_Admin { get; set; }
        public string Contract { get; set; }
    }

    public class MsgUpdateContractAdminDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Admin { get; set; }
        public string New_Admin { get; set; }
        public string Contract { get; set; }

        public MsgUpdateContractAdminDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_UPDATE_CONTRACT_ADMIN;
        }
    }
}
