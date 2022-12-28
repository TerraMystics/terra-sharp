using System.Collections.Generic;
using System.Linq;
using Terra.Microsoft.Rest;
using COMB = cosmos.ibase.v1beta1;

namespace Terra.Microsoft.Client.Core.Extensions
{
    public static class CoinsExtensions
    {
        public static IEnumerable<CoinAminoArgs> ToAmino(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToAmino());
        }

        public static IEnumerable<CoinDataArgs> ToData(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToData());
        }

        public static IEnumerable<CoinJSON> ToJSON(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToJSON());
        }

        public static IEnumerable<COMB.Coin> ToProto(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToProtoWithType());
        }

        public static IEnumerable<Coin> FromAmino(this IEnumerable<CoinAminoArgs> coins)
        {
            return coins.ToList().ConvertAll(w => Coin.FromAmino(w));
        }

        public static IEnumerable<Coin> FromData(this IEnumerable<CoinDataArgs> coins)
        {
            return coins.ToList().ConvertAll(w => Coin.FromData(w));
        }
        public static IEnumerable<Coin> FromJSON(this IEnumerable<CoinJSON> coins)
        {
            return coins.ToList().ConvertAll(w => Coin.FromJSON(w));
        }
        public static IEnumerable<Coin> FromProto(this IEnumerable<COMB.Coin> coins)
        {
            return coins.ToList().ConvertAll(w => Coin.FromProto(w));
        }

        public static string ToString(this IEnumerable<Coin> coins)
        {
            return string.Join(",", coins.Select(w => w.ToString()));
        }

        public static IEnumerable<string> Denoms(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.denom);
        }

        public static IEnumerable<Coin> ToDecCoins(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToDecCoin());
        }

        public static IEnumerable<Coin> ToIntCoins(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToLongCoin());
        }

        public static IEnumerable<Coin> ToIntCeilCoins(this IEnumerable<Coin> coins)
        {
            return coins.ToList().ConvertAll(w => w.ToLongCeilCoin());
        }

        public static IEnumerable<Coin> Add(this IEnumerable<Coin> coins, IEnumerable<Coin> newCoins)
        {
            return coins.Concat(newCoins);
        }

        public static IEnumerable<Coin> Sub(this List<Coin> coins, IEnumerable<Coin> newCoins)
        {
            coins.RemoveAll(w => newCoins.Contains(w));

            return coins;
        }
    }
}
