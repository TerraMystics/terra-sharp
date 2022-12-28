namespace Terra.Microsoft.Rest.Tx.Transaction.Upload
{
    public class TxUploadBodyJSON
    {
        public string memo { get; set; }
        public double? timeout_height { get; set; }
        public TxUploadMessageData[] messages { get; set; }
    }
}
