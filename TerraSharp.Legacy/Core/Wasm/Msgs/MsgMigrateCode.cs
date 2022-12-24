using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.proto.wasm.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.StringExt;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Wasm.Msgs
{
    public class MsgMigrateCode : SignerData
    {
        public readonly string sender;
        public readonly double code_id;
        public readonly string wasm_byte_code;

        public MsgMigrateCode(
            string sender,
            double code_id,
            string wasm_byte_code)
        {
            this.sender = sender;
            this.code_id = code_id;
            this.wasm_byte_code = wasm_byte_code;
        }

        public static MsgMigrateCode FromAmino(MsgMigrateCodeAminoArgs data)
        {
            return new MsgMigrateCode(
                data.Value.Sender,
                double.Parse(data.Value.Code_Id),
                data.Value.Wasm_Byte_Code);
        }

        public static MsgMigrateCode FromData(MsgMigrateCodeDataArgs data)
        {
            return new MsgMigrateCode(
               data.Sender,
               double.Parse(data.Code_Id),
               data.Wasm_Byte_Code);
        }

        public static MsgMigrateCode FromProto(PROTO.MsgMigrateCode data)
        {
            return new MsgMigrateCode(
              data.Sender,
              data.CodeId,
             TerraStringExtensions.GetStringFromBytes(data.WasmByteCode));
        }

        public MsgMigrateCodeAminoArgs ToAmino()
        {
            return new MsgMigrateCodeAminoArgs()
            {
                Value = new MsgMigrateCodeValueAminoArgs()
                {
                    Sender = this.sender,
                    Wasm_Byte_Code = this.wasm_byte_code,
                    Code_Id = this.code_id.ToString()
                }
            };
        }

        public MsgMigrateCodeDataArgs ToData()
        {
            return new MsgMigrateCodeDataArgs()
            {
                Sender = this.sender,
                Wasm_Byte_Code = this.wasm_byte_code,
                Code_Id = this.code_id.ToString()
            };
        }

        public PROTO.MsgMigrateCode ToProtoWithType()
        {
            return new PROTO.MsgMigrateCode()
            {
                CodeId = (ulong)this.code_id,
                Sender = this.sender,
                WasmByteCode = TerraStringExtensions.GetBase64BytesFromString(this.wasm_byte_code)
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

        public static MsgMigrateCode UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgMigrateCode>(msgAny.Value));
        }
    }

    public class MsgMigrateCodeAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgMigrateCodeValueAminoArgs Value { get; set; }
        public MsgMigrateCodeAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_MIGRATE_CODE;
        }
    }

    public class MsgMigrateCodeValueAminoArgs
    {
        public string Sender { get; set; }
        public string Code_Id { get; set; }
        public string Wasm_Byte_Code { get; set; }
    }

    public class MsgMigrateCodeDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Sender { get; set; }
        public string Code_Id { get; set; }
        public string Wasm_Byte_Code { get; set; }

        public MsgMigrateCodeDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_MIGRATE_CODE;
        }
    }
}
