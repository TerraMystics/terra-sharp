using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.wasm.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Linq;

namespace Terra.Microsoft.Client.Core.Wasm.Msgs
{
    public class MsgExecuteContract : SignerData
    {
        public readonly Coin[] coins;
        public readonly string sender;
        public readonly string contract;
        public readonly string execute_msg;

        public MsgExecuteContract(
            string sender,
            string contract,
            string execute_msg,
            Coin[] coins)
        {
            this.sender = sender;
            this.contract = contract;
            this.execute_msg = execute_msg;
            this.coins = coins;
        }

        public static MsgExecuteContract FromAmino(MsgExecuteContractAminoArgs data)
        {
            return new MsgExecuteContract(data.Value.Sender, data.Value.Contract, data.Value.Execute_Msg, CoinsExtensions.FromAmino(data.Value.Coins).ToArray());
        }

        public static MsgExecuteContract FromData(MsgExecuteContractDataArgs data)
        {
            return new MsgExecuteContract(data.Sender, data.Contract, data.Execute_Msg, CoinsExtensions.FromData(data.Coins).ToArray());
        }

        public static MsgExecuteContract FromProto(PROTO.MsgExecuteContract data)
        {
            return new MsgExecuteContract(data.Sender, data.Contract, TerraStringExtensions.GetStringFromBytes(data.ExecuteMsg), CoinsExtensions.FromProto(data.Coins).ToArray());
        }

        public MsgExecuteContractAminoArgs ToAmino()
        {
            return new MsgExecuteContractAminoArgs()
            {
                Value = new MsgExecuteContractValueAminoArgs()
                {
                    Sender = this.sender,
                    Contract = this.contract,
                    Execute_Msg = this.execute_msg,
                    Coins = CoinsExtensions.ToAmino(this.coins).ToArray()
                }
            };
        }

        public MsgExecuteContractDataArgs ToData()
        {
            return new MsgExecuteContractDataArgs()
            {
                Sender = this.sender,
                Contract = this.contract,
                Execute_Msg = this.execute_msg,
                Coins = CoinsExtensions.ToData(this.coins).ToArray()
            };
        }

        public PROTO.MsgExecuteContract ToProtoWithType()
        {
            return new PROTO.MsgExecuteContract()
            {
                Sender = this.sender,
                Coins = CoinsExtensions.ToProto(this.coins).ToList(),
                Contract = this.contract,
                ExecuteMsg = TerraStringExtensions.GetBytesFromString(this.execute_msg)
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
                TypeUrl = TerraConstants.TERRA_WASM_MSG_EXECUTE_CONTRACT,
                Value = this.ToProto()
            };
        }

        public static MsgExecuteContract UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgExecuteContract>(msgAny.Value));
        }
    }

    public class MsgExecuteContractAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgExecuteContractValueAminoArgs Value { get; set; }
        public MsgExecuteContractAminoArgs()
        {
            this.Type = WasmConstants.WASM_MSG_EXECUTE_CONTRACT;
        }
    }

    public class MsgExecuteContractValueAminoArgs
    {
        public CoinAminoArgs[] Coins { get; set; }
        public string Sender { get; set; }
        public string Contract { get; set; }
        public string Execute_Msg { get; set; }
    }

    public class MsgExecuteContractDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public CoinDataArgs[] Coins { get; set; }
        public string Sender { get; set; }
        public string Contract { get; set; }
        public string Execute_Msg { get; set; }

        public MsgExecuteContractDataArgs()
        {
            this.Type = TerraConstants.TERRA_WASM_MSG_EXECUTE_CONTRACT;
        }
    }
}
