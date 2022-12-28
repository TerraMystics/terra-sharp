using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.bank.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Client.Key.Data.SimplePublicKey;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Terra.Microsoft.Client.Core.Bank.Msgs
{
    public class MsgSend : SignerData
    {
        public List<Coin> amount;
        public readonly string from_address;
        public readonly string to_address;

        public MsgSend(string from_address, string to_address, List<Coin> amount)
        {
            this.from_address = from_address;
            this.to_address = to_address;
            this.amount = amount;
        }

        public static MsgSend FromAmino(MsgSendAminoArgs data)
        {
            return new MsgSend(data.Value.From_Address, data.Value.To_Address, CoinsExtensions.FromAmino(data.Value.Amount).ToList());
        }

        public static MsgSend FromData(MsgSendDataArgs data)
        {
            return new MsgSend(data.From_Address, data.To_Address, CoinsExtensions.FromData(data.Amount).ToList());
        }

        public static MsgSend FromProto(PROTO.MsgSend data)
        {
            return new MsgSend(data.FromAddress, data.ToAddress, CoinsExtensions.FromProto(data.Amounts).ToList());
        }

        public MsgSendAminoArgs ToAmino()
        {
            return new MsgSendAminoArgs()
            {
                Value = new MsgSendValueAminoArgs()
                {
                    Amount = CoinsExtensions.ToAmino(this.amount).ToArray(),
                    From_Address = this.from_address,
                    To_Address = this.to_address,
                }
            };
        }

        public MsgSendDataArgs ToData()
        {
            return new MsgSendDataArgs()
            {
                Amount = CoinsExtensions.ToData(this.amount).ToArray(),
                From_Address = this.from_address,
                To_Address = this.to_address,
            };
        }

        public PROTO.MsgSend ToProtoWithType()
        {
            return new PROTO.MsgSend()
            {
                Amounts = this.amount.ConvertAll(w => w.ToProtoWithType()).ToList(),
                FromAddress = this.from_address,
                ToAddress = this.to_address
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class MsgSendAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgSendValueAminoArgs Value { get; set; }
        public MsgSendAminoArgs()
        {
            this.Type = BankConstants.BANK_MSG_SEND;
        }
    }

    public class MsgSendValueAminoArgs
    {
        public string From_Address { get; set; }
        public string To_Address { get; set; }
        public CoinAminoArgs[] Amount { get; set; }
    }

    public class MsgSendDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string From_Address { get; set; }
        public string To_Address { get; set; }
        public CoinDataArgs[] Amount { get; set; }

        public MsgSendDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_BANK_MSG_SEND;
        }
    }
}
