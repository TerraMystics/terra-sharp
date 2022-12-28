using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.wasm.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Linq;

namespace Terra.Microsoft.Client.Core.Wasm.Msgs
{
    public class MsgInstantiateContract : SignerData
    {
        public readonly Coin[] init_coins;
        public readonly string sender;
        public readonly string admin;
        public readonly double code_id;
        public readonly object init_msg;

        public MsgInstantiateContract(
            string sender,
            string admin,
            double code_id,
            object init_msg,
            Coin[] init_coins)
        {
            this.sender = sender;
            this.admin = admin;
            this.code_id = code_id;
            this.init_msg = init_msg;
            this.init_coins = init_coins;
        }

        public static MsgInstantiateContract FromAmino(MsgInstantiateContractAminoArgs data)
        {
            return new MsgInstantiateContract(
                data.Value.Sender,
                data.Value.Admin,
                double.Parse(data.Value.Code_Id),
                data.Value.Init_msg,
                CoinsExtensions.FromAmino(data.Value.Init_coins).ToArray());
        }

        public static MsgInstantiateContract FromData(MsgInstantiateContractDataArgs data)
        {
            return new MsgInstantiateContract(
                 data.Sender,
                 data.Admin,
                 double.Parse(data.Code_Id),
                 data.Init_msg,
                 CoinsExtensions.FromData(data.Init_coins).ToArray());
        }

        public static MsgInstantiateContract FromProto(PROTO.MsgInstantiateContract data)
        {
            return new MsgInstantiateContract(
                data.Sender,
                data.Admin,
                data.CodeId,
                data.InitMsg,
                CoinsExtensions.FromProto(data.InitCoins).ToArray());
        }

        public MsgInstantiateContractAminoArgs ToAmino()
        {
            return new MsgInstantiateContractAminoArgs()
            {
                Value = new MsgInstantiateContractValueAminoArgs()
                {
                    Sender = this.sender,
                    Admin = this.admin,
                    Code_Id = this.code_id.ToString(),
                    Init_msg = this.init_msg,
                    Init_coins = CoinsExtensions.ToAmino(this.init_coins).ToArray()
                }
            };
        }

        public MsgInstantiateContractDataArgs ToData()
        {
            return new MsgInstantiateContractDataArgs()
            {
                Sender = this.sender,
                Admin = this.admin,
                Code_Id = this.code_id.ToString(),
                Init_msg = this.init_msg,
                Init_coins = CoinsExtensions.ToData(this.init_coins).ToArray()
            };
        }

        public PROTO.MsgInstantiateContract ToProtoWithType()
        {
            return new PROTO.MsgInstantiateContract()
            {
                CodeId = (ulong)this.code_id,
                Sender = this.sender,
                Admin = this.admin,
                InitCoins = CoinsExtensions.ToProto(this.init_coins).ToList(),
                InitMsg = TerraStringExtensions.GetBytesFromString(TerraStringExtensions.GetJSONFromobject(this.init_msg)),
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
                TypeUrl = TerraConstants.TERRA_WASM_MSG_INSTANTIATE_CONTRACT,
                Value = this.ToProto()
            };
        }

        public static MsgInstantiateContract UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgInstantiateContract>(msgAny.Value));
        }
    }

    public class MsgInstantiateContractAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgInstantiateContractValueAminoArgs Value { get; set; }
        public MsgInstantiateContractAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_INSTANTIATE_CONTRACT;
        }
    }

    public class MsgInstantiateContractValueAminoArgs
    {
        public CoinAminoArgs[] Init_coins { get; set; }
        public string Sender { get; set; }
        public string Admin { get; set; }
        public string Code_Id { get; set; }
        public object Init_msg { get; set; }
    }

    public class MsgInstantiateContractDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public CoinDataArgs[] Init_coins { get; set; }
        public string Sender { get; set; }
        public string Admin { get; set; }
        public string Code_Id { get; set; }
        public object Init_msg { get; set; }

        public MsgInstantiateContractDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_INSTANTIATE_CONTRACT;
        }
    }
}
