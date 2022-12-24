using TerraNetExtensions.ProtoBufs;
using PROTO = TerraProto.CSharp.proto.oracle.v1beta1;

namespace TerraSharp.Core.Oracle
{
    public class ExchangeRateTuple
    {
        public readonly decimal exchange_rate;
        public readonly decimal denom;

        public ExchangeRateTuple(
            decimal exchange_rate,
            decimal denom)
        {
            this.exchange_rate = exchange_rate;
            this.denom = denom;
        }

        public static ExchangeRateTuple FromAmino(ExchangeRateTupleAminoArgs data)
        {
            return new ExchangeRateTuple(decimal.Parse(data.Exchange_Rate), decimal.Parse(data.Denom));
        }

        public static ExchangeRateTuple FromData(ExchangeRateTupleDataArgs data)
        {
            return new ExchangeRateTuple(decimal.Parse(data.Exchange_Rate), decimal.Parse(data.Denom));
        }

        public static ExchangeRateTuple FromProto(PROTO.ExchangeRateTuple data)
        {
            return new ExchangeRateTuple(decimal.Parse(data.ExchangeRate), decimal.Parse(data.Denom));
        }

        public ExchangeRateTupleAminoArgs ToAmino()
        {
            return new ExchangeRateTupleAminoArgs()
            {
                Exchange_Rate = this.exchange_rate.ToString(),
                Denom = this.denom.ToString()
            };
        }

        public ExchangeRateTupleDataArgs ToData()
        {
            return new ExchangeRateTupleDataArgs()
            {
                Exchange_Rate = this.exchange_rate.ToString(),
                Denom = this.denom.ToString()
            };
        }

        public PROTO.ExchangeRateTuple ToProtoWithType()
        {
            return new PROTO.ExchangeRateTuple()
            {
                Denom = this.denom.ToString(),
                ExchangeRate = this.exchange_rate.ToString()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class ExchangeRateTupleAminoArgs : ExchangeRateTupleCommonArgs
    {
    }

    public class ExchangeRateTupleDataArgs : ExchangeRateTupleCommonArgs
    {
    }

    public class ExchangeRateTupleCommonArgs
    {
        public string Exchange_Rate { get; set; }
        public string Denom { get; set; }
    }
}
