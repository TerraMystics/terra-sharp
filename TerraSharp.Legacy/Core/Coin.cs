using CCF = cosmos.ibase.v1beta1;
using COMB = cosmos.ibase.v1beta1;
using System.Text.RegularExpressions;
using TerraSharp.Core.Extensions;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest;
using System;
using System.Linq;

namespace TerraSharp.Core
{
    public class Coin : INumeric<Coin, object>
    {
        private const string COIN_REGEX = "/^(-?[0-9]+(\\.[0-9]+)?)([0-9a-zA-Z/]+)$/";

        public readonly double amount;
        public readonly string denom;


        public Coin(string denom, double amount)
        {
            this.denom = denom;
            this.amount = amount;
        }

        public static Coin FromAmino(CoinAminoArgs data)
        {
            return new Coin(data.Denom, data.Amount);
        }

        public static Coin FromData(CoinDataArgs data)
        {
            return new Coin(data.Denom, data.Amount);
        }
        public static Coin FromJSON(CoinJSON data)
        {
            return new Coin(data.Denom, double.Parse(data.Amount));
        }

        public static Coin FromProto(COMB.Coin data)
        {
            return null;
        }

        public CoinDataArgs ToData()
        {
            return new CoinDataArgs()
            {
                Denom = this.denom,
                Amount = this.amount,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData<CCF.Coin>(new CCF.Coin()
            {
                Amount = this.amount.ToString(),
                Denom = this.denom
            });
        }
        public CCF.Coin ToProtoWithType()
        {
            return new CCF.Coin()
            {
                Amount = this.amount.ToString(),
                Denom = this.denom
            };
        }

        public CoinAminoArgs ToAmino()
        {
            return new CoinAminoArgs()
            {
                Denom = this.denom,
                Amount = this.amount,
            };
        }
        public CoinJSON ToJSON()
        {
            return new CoinJSON()
            {
                Denom = this.denom,
                Amount = this.amount.ToString(),
            };
        }

        public Coin ToLongCoin()
        {
            return new Coin(this.denom, this.amount);
        }

        public Coin ToLongCeilCoin()
        {
            return new Coin(this.denom, Math.Ceiling(this.amount));
        }

        public Coin ToDecCoin()
        {
            return new Coin(this.denom, this.amount);
        }

        public override string ToString()
        {
            return $"{this.amount}{this.denom}";
        }

        public static Coin FromString(string str)
        {
            bool m = Regex.IsMatch(str, COIN_REGEX);
            if (!m)
            {
                throw new Exception($"failed to parse to Coin: ${str}");
            }

            var amount = double.Parse(str.ElementAt(1).ToString());
            var denom = str.ElementAt(3).ToString();

            return new Coin(denom, amount);
        }

        public Coin Add(object value)
        {
            return new Coin(this.denom, this.amount + (double)value);
        }

        public Coin Sub(object value)
        {
            return new Coin(this.denom, this.amount - (double)value);
        }

        public Coin Mul(object value)
        {
            return new Coin(this.denom, this.amount * (double)value);
        }

        public Coin Div(object value)
        {
            return new Coin(this.denom, this.amount / (double)value);
        }

        public Coin Mod(object value)
        {
            return new Coin(this.denom, Math.Abs((double)value));
        }
    }

    public class CoinAminoArgs
    {
        public string Denom { get; set; }
        public double Amount { get; set; }
    }

    public class CoinDataArgs
    {
        public string Denom { get; set; }
        public double Amount { get; set; }
    }

}
