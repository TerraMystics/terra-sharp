using Terra.Microsoft.Rest.Tx.Transaction.Response;

namespace Terra.Microsoft.Rest.Tx.Transaction.Upload
{
    public class TxUploadContainerJSON
    {
        public TxUploadValueJSON tx { get; set; }
        public string tx_bytes { get; set; }
        public CoinJSON[] tax_amount { get; set; }
        public TxGasInfoResponse gas_info { get; set; }
        public TxResponse tx_response { get; set; }
    }
}
