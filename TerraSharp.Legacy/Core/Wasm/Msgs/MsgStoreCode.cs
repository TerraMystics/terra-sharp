using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.proto.wasm.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.StringExt;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Wasm.Msgs
{
    public class MsgStoreCode : SignerData
    {
        public readonly string sender;
        public readonly string wasm_byte_code;

        public MsgStoreCode(
            string sender,
            string wasm_byte_code)
        {
            this.sender = sender;
            this.wasm_byte_code = wasm_byte_code;
        }

        public static MsgStoreCode FromAmino(MsgStoreCodeAminoArgs data)
        {
            return new MsgStoreCode(
                data.Value.Sender,
                data.Value.Wasm_Byte_Code);
        }

        public static MsgStoreCode FromData(MsgStoreCodeDataArgs data)
        {
            return new MsgStoreCode(
                data.Sender,
                data.Wasm_Byte_Code);
        }

        public static MsgStoreCode FromProto(PROTO.MsgStoreCode data)
        {
            return new MsgStoreCode(
                   data.Sender,
                   TerraStringExtensions.GetBase64FromBytes(data.WasmByteCode));
        }

        public MsgStoreCodeAminoArgs ToAmino()
        {
            return new MsgStoreCodeAminoArgs()
            {
                Value = new MsgStoreCodeValueAminoArgs()
                {
                    Sender = this.sender,
                    Wasm_Byte_Code = this.wasm_byte_code,
                }
            };
        }

        public MsgStoreCodeDataArgs ToData()
        {
            return new MsgStoreCodeDataArgs()
            {
                Sender = this.sender,
                Wasm_Byte_Code = this.wasm_byte_code,
            };
        }


        public PROTO.MsgStoreCode ToProtoWithType()
        {
            return new PROTO.MsgStoreCode()
            {
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
                TypeUrl = TerraConstants.TERRA_WASM_MSG_STORE_CODE,
                Value = this.ToProto()
            };
        }

        public static MsgStoreCode UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgStoreCode>(msgAny.Value));
        }
    }

    public class MsgStoreCodeAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgStoreCodeValueAminoArgs Value { get; set; }
        public MsgStoreCodeAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_STORE_CODE;
        }
    }

    public class MsgStoreCodeValueAminoArgs
    {
        public string Sender { get; set; }
        public string Wasm_Byte_Code { get; set; }
    }

    public class MsgStoreCodeDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Sender { get; set; }
        public string Wasm_Byte_Code { get; set; }

        public MsgStoreCodeDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_STORE_CODE;
        }
    }
}
