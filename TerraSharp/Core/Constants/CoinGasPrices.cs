using System;
using Terra.Microsoft.Rest.Treasury;

namespace Terra.Microsoft.Client.Core.Constants
{
    public class CoinGasPrices
    {
        public static double GetGasPriceForDenom(string denom, DenomGasPrices gas)
        {
            switch (denom)
            {
                case CoinDenoms.UUSD:
                    return gas.UUSD;
                case CoinDenoms.ULUNA:
                    return gas.ULUNA;
                case CoinDenoms.UIDR:
                    return gas.UIDR;
                case CoinDenoms.UKRW:
                    return gas.UKRW;
                case CoinDenoms.UMNT:
                    return gas.UMNT;
                case CoinDenoms.UPHP:
                    return gas.UPHP;
                case CoinDenoms.USDR:
                    return gas.USDR;
                case CoinDenoms.UEUR:
                    return gas.UEUR;
                case CoinDenoms.UCNY:
                    return gas.UCNY;
                case CoinDenoms.UJPY:
                    return gas.UJPY;
                case CoinDenoms.UGBP:
                    return gas.UGBP;
                case CoinDenoms.UINR:
                    return gas.UINR;
                case CoinDenoms.UCHF:
                    return gas.UCHF;
                case CoinDenoms.UCAD:
                    return gas.UCAD;
                case CoinDenoms.UAUD:
                    return gas.UAUD;
                case CoinDenoms.USGD:
                    return gas.USGD;
                case CoinDenoms.UTHB:
                    return gas.UTHB;
                case CoinDenoms.USEK:
                    return gas.USEK;
                case CoinDenoms.UNOK:
                    return gas.UNOK;
                case CoinDenoms.UDKK:
                    return gas.UDKK;
                case CoinDenoms.UHKD:
                    return gas.UHKD;
                case CoinDenoms.UMYR:
                    return gas.UMYR;
                case CoinDenoms.UTWD:
                    return gas.UTWD;
            }

            throw new ArgumentException($"Could not find a gas price for the specified Denom {denom}");
        }
    }
}
