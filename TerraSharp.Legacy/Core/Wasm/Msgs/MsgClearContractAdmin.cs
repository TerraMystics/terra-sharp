using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.proto.wasm.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraSharp.Core.Extensions;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Wasm.Msgs
{
    public class MsgClearContractAdmin : SignerData
    {
        public readonly string admin;
        public readonly string contract;

        public MsgClearContractAdmin(string admin, string contract)
        {
            this.admin = admin;
            this.contract = contract;
        }

        public static MsgClearContractAdmin FromAmino(MsgClearContractAdminAminoArgs data)
        {
            return new MsgClearContractAdmin(data.Value.Admin, data.Value.Contract);
        }

        public static MsgClearContractAdmin FromData(MsgClearContractAdminDataArgs data)
        {
            return new MsgClearContractAdmin(data.Admin, data.Contract);
        }

        public static MsgClearContractAdmin FromProto(PROTO.MsgClearContractAdmin data)
        {
            return new MsgClearContractAdmin(data.Admin, data.Contract);
        }

        public MsgClearContractAdminAminoArgs ToAmino()
        {
            return new MsgClearContractAdminAminoArgs()
            {
                Value = new MsgClearContractAdminValueAminoArgs()
                {
                    Admin = this.admin,
                    Contract = this.contract,
                }
            };
        }

        public MsgClearContractAdminDataArgs ToData()
        {
            return new MsgClearContractAdminDataArgs()
            {
                Admin = this.admin,
                Contract = this.contract,
            };
        }

        public PROTO.MsgClearContractAdmin ToProtoWithType()
        {
            return new PROTO.MsgClearContractAdmin()
            {
                Contract = this.contract,
                Admin = this.admin,
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
                TypeUrl = TerraConstants.TERRA_WASM_MSG_CLEAR_CONTRACT_ADMIN,
                Value = this.ToProto()
            };
        }

        public static MsgClearContractAdmin UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgClearContractAdmin>(msgAny.Value));
        }
    }

    public class MsgClearContractAdminAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgClearContractAdminValueAminoArgs Value { get; set; }
        public MsgClearContractAdminAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_CLEAR_CONTRACT;
        }
    }

    public class MsgClearContractAdminValueAminoArgs
    {
        public string Admin { get; set; }
        public string Contract { get; set; }
    }

    public class MsgClearContractAdminDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Admin { get; set; }
        public string Contract { get; set; }

        public MsgClearContractAdminDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_CLEAR_CONTRACT_ADMIN;
        }
    }
}
