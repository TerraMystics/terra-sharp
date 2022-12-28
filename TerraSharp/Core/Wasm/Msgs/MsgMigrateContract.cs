using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.wasm.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Wasm.Msgs
{
    public class MsgMigrateContract : SignerData
    {
        public readonly string admin;
        public readonly string contract;
        public readonly double new_code_id;
        public readonly string migrate_msg;

        public MsgMigrateContract(
            string admin,
            string contract,
            double new_code_id,
            string migrate_msg)
        {
            this.admin = admin;
            this.contract = contract;
            this.new_code_id = new_code_id;
            this.migrate_msg = migrate_msg;
        }

        public static MsgMigrateContract FromAmino(MsgMigrateContractAminoArgs data)
        {
            return new MsgMigrateContract(
                data.Value.Admin,
                data.Value.Contract,
                double.Parse(data.Value.New_Code_Id),
                data.Value.Migrate_Msg);
        }

        public static MsgMigrateContract FromData(MsgMigrateContractDataArgs data)
        {
            return new MsgMigrateContract(
                 data.Admin,
                 data.Contract,
                 double.Parse(data.New_Code_Id),
                 data.Migrate_Msg);
        }

        public static MsgMigrateContract FromProto(PROTO.MsgMigrateContract data)
        {
            return new MsgMigrateContract(
                 data.Admin,
                 data.Contract,
                 data.NewCodeId,
                 TerraStringExtensions.GetStringFromBytes(data.MigrateMsg));
        }

        public MsgMigrateContractAminoArgs ToAmino()
        {
            return new MsgMigrateContractAminoArgs()
            {
                Value = new MsgMigrateContractValueAminoArgs()
                {
                    Admin = this.admin,
                    Contract = this.contract,
                    Migrate_Msg = this.migrate_msg,
                    New_Code_Id = this.new_code_id.ToString()
                }
            };
        }

        public MsgMigrateContractDataArgs ToData()
        {
            return new MsgMigrateContractDataArgs()
            {
                Admin = this.admin,
                Contract = this.contract,
                Migrate_Msg = this.migrate_msg,
                New_Code_Id = this.new_code_id.ToString()
            };
        }

        public PROTO.MsgMigrateContract ToProtoWithType()
        {
            return new PROTO.MsgMigrateContract()
            {
                Admin = this.admin,
                Contract = this.contract,
                MigrateMsg = TerraStringExtensions.GetBytesFromString(this.migrate_msg),
                NewCodeId = (ulong)this.new_code_id
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
                TypeUrl = TerraConstants.TERRA_WASM_MSG_MIGRATE_CODE,
                Value = this.ToProto()
            };
        }

        public static MsgMigrateContract UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgMigrateContract>(msgAny.Value));
        }
    }

    public class MsgMigrateContractAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgMigrateContractValueAminoArgs Value { get; set; }
        public MsgMigrateContractAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_MIGRATE_CODE;
        }
    }

    public class MsgMigrateContractValueAminoArgs
    {
        public string Admin { get; set; }
        public string Contract { get; set; }
        public string New_Code_Id { get; set; }
        public string Migrate_Msg { get; set; }
    }

    public class MsgMigrateContractDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Admin { get; set; }
        public string Contract { get; set; }
        public string New_Code_Id { get; set; }
        public string Migrate_Msg { get; set; }

        public MsgMigrateContractDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_MIGRATE_CODE;
        }
    }
}
