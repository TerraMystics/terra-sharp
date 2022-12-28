using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.market.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Market.Msgs
{
    public class MsgSwapSend : SignerData
    {
        public readonly string from_address;
        public readonly string to_address;
        public readonly Coin offer_coin;
        public readonly string ask_denom;

        public MsgSwapSend(
            string from_address,
            string to_address,
            Coin offer_coin,
            string ask_denom)
        {
            this.from_address = from_address;
            this.to_address = to_address;
            this.offer_coin = offer_coin;
            this.ask_denom = ask_denom;
        }

        public static MsgSwapSend FromAmino(MsgSwapSendAminoArgs data)
        {
            return new MsgSwapSend(data.Value.From_Address, data.Value.To_Address, Coin.FromAmino(data.Value.Offer_Coin), data.Value.Ask_Denom);
        }

        public static MsgSwapSend FromData(MsgSwapSendDataArgs data)
        {
            return new MsgSwapSend(data.From_Address, data.To_Address, Coin.FromData(data.Offer_Coin), data.Ask_Denom);
        }

        public static MsgSwapSend FromProto(PROTO.MsgSwapSend data)
        {
            return new MsgSwapSend(data.FromAddress, data.ToAddress, Coin.FromProto(data.OfferCoin), data.AskDenom);
        }

        public MsgSwapSendAminoArgs ToAmino()
        {
            return new MsgSwapSendAminoArgs()
            {
                Value = new MsgSwapSendValueAminoArgs()
                {
                    Ask_Denom = this.ask_denom,
                    Offer_Coin = this.offer_coin.ToAmino(),
                    From_Address = this.from_address,
                    To_Address = this.to_address,
                }
            };
        }

        public MsgSwapSendDataArgs ToData()
        {
            return new MsgSwapSendDataArgs()
            {
                Ask_Denom = this.ask_denom,
                Offer_Coin = this.offer_coin.ToData(),
                From_Address = this.from_address,
                To_Address = this.to_address,
            };
        }

        public PROTO.MsgSwapSend ToProtoWithType()
        {
            return new PROTO.MsgSwapSend()
            {
                AskDenom = this.ask_denom,
                FromAddress = this.from_address,
                OfferCoin = this.offer_coin.ToProtoWithType(),
                ToAddress = this.to_address
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
                TypeUrl = TerraConstants.TERRA_MARKET_MSGSWAP_SEND,
                Value = this.ToProto()
            };
        }

        public static MsgSwapSend UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgSwapSend>(msgAny.Value));
        }
    }

    public class MsgSwapSendAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgSwapSendValueAminoArgs Value { get; set; }
        public MsgSwapSendAminoArgs()
        {
            this.Type = MarketConstants.TERRA_MARKET_MSGSWAP_SEND;
        }
    }

    public class MsgSwapSendValueAminoArgs
    {
        public string From_Address { get; set; }
        public string To_Address { get; set; }
        public CoinAminoArgs Offer_Coin { get; set; }
        public string Ask_Denom { get; set; }
    }

    public class MsgSwapSendDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string From_Address { get; set; }
        public string To_Address { get; set; }
        public CoinDataArgs Offer_Coin { get; set; }
        public string Ask_Denom { get; set; }

        public MsgSwapSendDataArgs()
        {
            this.Type = TerraConstants.TERRA_MARKET_MSGSWAP_SEND;
        }
    }
}
