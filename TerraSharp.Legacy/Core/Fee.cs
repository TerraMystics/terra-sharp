using COMB = TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;
using TerraSharp.Core.Extensions;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Key.Data.SimplePublicKey;
using TerraSharp.Rest.Tx.Transaction;
using TerraSharp.Rest;
using System.Collections.Generic;
using System.Linq;

namespace TerraSharp.Core
{
    public class Fee
    {
        public readonly List<Coin> amount;
        public readonly double gas_limit;
        public readonly string payer;
        public readonly string granter;

        public Fee(double gas_limit, List<Coin> amount, string payer = "", string granter = "")
        {
            this.gas_limit = gas_limit;
            this.amount = amount;
            this.payer = payer;
            this.granter = granter;
        }

        public FeeAminoArgs ToAmino()
        {
            return new FeeAminoArgs()
            {
                Gas = this.gas_limit.ToString(),
                Amount = CoinsExtensions.ToAmino(this.amount).ToArray()
            };
        }

        public FeeDataArgs ToData()
        {
            return new FeeDataArgs()
            {
                Payer = this.payer,
                Granter = this.granter,
                Gas_Limit = this.gas_limit.ToString(),
                Amount = CoinsExtensions.ToData(this.amount).ToArray()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public COMB.Fee ToProtoWithType()
        {
            return new COMB.Fee()
            {
                GasLimit = (ulong)this.gas_limit,
                Granter = this.granter,
                Payer = this.payer,
                Amounts = this.amount.ConvertAll(w => w.ToProtoWithType())
            };
        }

        public static Fee FromAmino(FeeAminoArgs data)
        {
            return new Fee(double.Parse(data.Gas), CoinsExtensions.FromAmino(data.Amount).ToList(), string.Empty, string.Empty);
        }

        public static Fee FromJSON(TxFee data)
        {
            return new Fee(data.gas_limit, CoinsExtensions.FromJSON(data.amount).ToList(), data.payer, data.granter);
        }

        public static Fee FromData(FeeDataArgs data)
        {
            return new Fee(double.Parse(data.Gas_Limit), CoinsExtensions.FromData(data.Amount).ToList(), data.Payer, data.Granter);
        }
        public static Fee FromProto(COMB.Fee data)
        {
            return new Fee(data.GasLimit, CoinsExtensions.FromProto(data.Amounts).ToList(), data.Payer, data.Granter);
        }

        public IEnumerable<Coin> GasPrices()
        {
            return this.amount.ConvertAll(w => w.ToDecCoin().Div(this.gas_limit));
        }
        public TxFee ToJson()
        {
            return new TxFee()
            {
                amount = CoinsExtensions.ToJSON(this.amount).ToArray(),
                gas_limit = this.gas_limit,
                granter = this.granter,
                payer = this.payer
            };
        }
    }

    public class FeeAminoArgs
    {
        public string Gas { get; set; }
        public CoinAminoArgs[] Amount { get; set; }
    }

    public class FeeDataArgs
    {
        public string Gas_Limit { get; set; }
        public string Payer { get; set; }
        public string Granter { get; set; }
        public CoinDataArgs[] Amount { get; set; }
    }
}
