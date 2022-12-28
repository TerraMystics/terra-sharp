using Google.Protobuf.WellKnownTypes;
using PROTO = Terra.Microsoft.ProtoBufs.proto.market.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Client.Core.Keys.Constants;
using Terra.Microsoft.Client.Core.Keys;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;

namespace Terra.Microsoft.Client.Core.Market.Msgs
{
    public class MsgSwap : SignerData
    {
        public readonly string trader;
        public readonly Coin offer_coin;
        public readonly string ask_denom;

        public MsgSwap(
            string trader,
            Coin offer_coin,
            string ask_denom)
        {
            this.trader = trader;
            this.offer_coin = offer_coin;
            this.ask_denom = ask_denom;
        }

        public static MsgSwap FromAmino(MsgSwapAminoArgs data)
        {
            return new MsgSwap(data.Value.Trader, Coin.FromAmino(data.Value.Offer_Coin), data.Value.Ask_Denom);
        }

        public static MsgSwap FromData(MsgSwapDataArgs data)
        {
            return new MsgSwap(data.Trader, Coin.FromData(data.Offer_Coin), data.Ask_Denom);
        }

        public static MsgSwap FromProto(PROTO.MsgSwap data)
        {
            return new MsgSwap(data.Trader, Coin.FromProto(data.OfferCoin), data.AskDenom);
        }

        public MsgSwapAminoArgs ToAmino()
        {
            return new MsgSwapAminoArgs()
            {
                Value = new MsgSwapValueAminoArgs()
                {
                    Ask_Denom = this.ask_denom,
                    Offer_Coin = this.offer_coin.ToAmino(),
                    Trader = this.trader
                }
            };
        }

        public MsgSwapDataArgs ToData()
        {
            return new MsgSwapDataArgs()
            {
                Ask_Denom = this.ask_denom,
                Offer_Coin = this.offer_coin.ToData(),
                Trader = this.trader
            };
        }

        public PROTO.MsgSwap ToProtoWithType()
        {
            return new PROTO.MsgSwap()
            {
                AskDenom = this.ask_denom,
                OfferCoin = this.offer_coin.ToProtoWithType(),
                Trader = this.trader
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
                TypeUrl = TerraConstants.TERRA_MARKET_MSGSWAP,
                Value = this.ToProto()
            };
        }

        public static MsgSwap UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgSwap>(msgAny.Value));
        }
    }

    public class MsgSwapAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgSwapValueAminoArgs Value { get; set; }
        public MsgSwapAminoArgs()
        {
            this.Type = MarketConstants.TERRA_MARKET_MSGSWAP;
        }
    }

    public class MsgSwapValueAminoArgs
    {
        public string Trader { get; set; }
        public CoinAminoArgs Offer_Coin { get; set; }
        public string Ask_Denom { get; set; }
    }

    public class MsgSwapDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Trader { get; set; }
        public CoinDataArgs Offer_Coin { get; set; }
        public string Ask_Denom { get; set; }

        public MsgSwapDataArgs()
        {
            this.Type = TerraConstants.TERRA_MARKET_MSGSWAP;
        }
    }
}
