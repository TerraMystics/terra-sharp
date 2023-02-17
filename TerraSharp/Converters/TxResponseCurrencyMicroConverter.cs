using Terra.Microsoft.Rest.Tx.Transaction;
using Terra.Microsoft.Rest.Tx.Transaction.Response;

namespace TerraSharp.Converters
{
    public static class TxResponseCurrencyMicroConverter
    {
        public static TxGasInfoResponse ReformatGasResponse(TxGasInfoResponse response)
        {
            response.gas_wanted = $"{CurrencyConverter.ConvertMicroToStandard(double.Parse(response.gas_wanted))}";
            response.gas_used = $"{CurrencyConverter.ConvertMicroToStandard(double.Parse(response.gas_used))}";

            return response;
        }

        public static TxResponse ReformatTxResponse(TxResponse response)
        {
            response.gas_wanted = CurrencyConverter.ConvertMicroToStandard(response.gas_wanted);
            response.gas_used = CurrencyConverter.ConvertMicroToStandard(response.gas_used);

            return response;
        }
    }
}
