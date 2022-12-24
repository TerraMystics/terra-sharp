using PROTO = TerraProto.CSharp.third_party.proto.cosmos.bank.v1beta1;
using TerraSharp.Core.Extensions;
using TerraSharp.Core.Bank.Msgs.TerraSharp.Core.Bank.Msgs.Input;
using TerraSharp.Core.Bank.Msgs.TerraSharp.Core.Bank.Msgs.Output;
using Google.Protobuf.WellKnownTypes;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Authz.Msgs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using TerraSharp.Rest.Tx.Block;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Core.Bank.Msgs
{
    public class MsgMultiSend : SignerData
    {
        public readonly Input[] inputs;
        public readonly Output[] outputs;

        public MsgMultiSend(Input[] inputs, Output[] outputs)
        {
            this.inputs = inputs;
            this.outputs = outputs;
        }

        public static MsgMultiSend FromAmino(MsgMultiSendAminoArgs data)
        {
            return new MsgMultiSend(
                data.Value.Inputs.ToList().ConvertAll(w => Input.FromAmino(w)).ToArray(),
                data.Value.Outputs.ToList().ConvertAll(w => Output.FromAmino(w)).ToArray());
        }

        public static MsgMultiSend FromData(MsgMultiSendDataArgs data)
        {
            return new MsgMultiSend(
                data.Inputs.ToList().ConvertAll(w => Input.FromData(w)).ToArray(),
                data.Outputs.ToList().ConvertAll(w => Output.FromData(w)).ToArray());
        }

        public static MsgMultiSend FromProto(PROTO.MsgMultiSend data)
        {
            return new MsgMultiSend(
                data.Inputs.ToList().ConvertAll(w => Input.FromProto(w)).ToArray(),
                data.Outputs.ToList().ConvertAll(w => Output.FromProto(w)).ToArray());
        }

        public MsgMultiSendAminoArgs ToAmino()
        {
            return new MsgMultiSendAminoArgs()
            {
                Value = new MsgMultiSendValueAminoArgs()
                {
                    Inputs = this.inputs.ToList().ConvertAll(w => w.ToAmino()).ToArray(),
                    Outputs = this.outputs.ToList().ConvertAll(w => w.ToAmino()).ToArray(),
                }
            };
        }

        public MsgMultiSendDataArgs ToData()
        {
            return new MsgMultiSendDataArgs()
            {
                Inputs = this.inputs.ToList().ConvertAll(w => w.ToData()).ToArray(),
                Outputs = this.outputs.ToList().ConvertAll(w => w.ToData()).ToArray(),
            };
        }

        public PROTO.MsgMultiSend ToProtoWithType()
        {
            return new PROTO.MsgMultiSend()
            {
                Inputs = this.inputs.ToList().ConvertAll(w => w.ToProtoWithType()),
                Outputs = this.outputs.ToList().ConvertAll(w => w.ToProtoWithType())
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
                TypeUrl = CosmosConstants.COSMOS_BANK_MSG_MULTISEND,
                Value = this.ToProto()
            };
        }

        public static MsgMultiSend UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgMultiSend>(msgAny.Value));
        }
    }

    public class MsgMultiSendAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgMultiSendValueAminoArgs Value { get; set; }
        public MsgMultiSendAminoArgs()
        {
            this.Type = BankConstants.BANK_MSG_MULTISEND;
        }
    }

    public class MsgMultiSendValueAminoArgs
    {
        public InputAminoArgs[] Inputs { get; set; }
        public OutputAminoArgs[] Outputs { get; set; }
    }

    public class MsgMultiSendDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public InputDataArgs[] Inputs { get; set; }
        public OutputDataArgs[] Outputs { get; set; }

        public MsgMultiSendDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_BANK_MSG_MULTISEND;
        }
    }

    namespace TerraSharp.Core.Bank.Msgs.Input
    {
        public class Input
        {
            public List<Coin> coins;
            public string address;

            public Input(string address, List<Coin> coins)
            {
                this.address = address;
                this.coins = coins;
            }

            public static Input FromAmino(InputAminoArgs data)
            {
                return new Input(data.Address, CoinsExtensions.FromAmino(data.Coins).ToList());
            }

            public static Input FromData(InputDataArgs data)
            {
                return new Input(data.Address, CoinsExtensions.FromData(data.Coins).ToList());
            }

            public static Input FromProto(PROTO.Input data)
            {
                return new Input(data.Address, CoinsExtensions.FromProto(data.Coins).ToList());
            }

            public InputAminoArgs ToAmino()
            {
                return new InputAminoArgs()
                {
                    Address = this.address,
                    Coins = CoinsExtensions.ToAmino(this.coins).ToArray()
                };
            }

            public InputDataArgs ToData()
            {
                return new InputDataArgs()
                {
                    Address = this.address,
                    Coins = CoinsExtensions.ToData(this.coins).ToArray()
                };
            }

            public PROTO.Input ToProtoWithType()
            {
                return new PROTO.Input()
                {
                    Address = this.address,
                    Coins = CoinsExtensions.ToProto(this.coins).ToList()
                };
            }

            public byte[] ToProto()
            {
                return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
            }
        }

        public class InputAminoArgs
        {
            public string Address { get; set; }
            public CoinAminoArgs[] Coins { get; set; }
        }

        public class InputDataArgs
        {
            public string Address { get; set; }
            public CoinDataArgs[] Coins { get; set; }
        }
    }

    namespace TerraSharp.Core.Bank.Msgs.Output
    {
        public class Output
        {
            public List<Coin> coins;
            public string address;

            public Output(string address, List<Coin> coins)
            {
                this.address = address;
                this.coins = coins;
            }

            public static Output FromAmino(OutputAminoArgs data)
            {
                return new Output(data.Address, CoinsExtensions.FromAmino(data.Coins).ToList());
            }

            public static Output FromData(OutputDataArgs data)
            {
                return new Output(data.Address, CoinsExtensions.FromData(data.Coins).ToList());
            }

            public static Output FromProto(PROTO.Output data)
            {
                return new Output(data.Address, CoinsExtensions.FromProto(data.Coins).ToList());
            }

            public OutputAminoArgs ToAmino()
            {
                return new OutputAminoArgs()
                {
                    Address = this.address,
                    Coins = CoinsExtensions.ToAmino(this.coins).ToArray()
                };
            }

            public OutputDataArgs ToData()
            {
                return new OutputDataArgs()
                {
                    Address = this.address,
                    Coins = CoinsExtensions.ToData(this.coins).ToArray()
                };
            }

            public PROTO.Output ToProtoWithType()
            {
                return new PROTO.Output()
                {
                    Address = this.address,
                    Coins = CoinsExtensions.ToProto(this.coins).ToList()
                };
            }

            public byte[] ToProto()
            {
                return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
            }
        }

        public class OutputAminoArgs
        {
            public string Address { get; set; }
            public CoinAminoArgs[] Coins { get; set; }
        }

        public class OutputDataArgs
        {
            public string Address { get; set; }
            public CoinDataArgs[] Coins { get; set; }
        }


    }

}
