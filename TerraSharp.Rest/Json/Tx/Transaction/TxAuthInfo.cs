namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxAuthInfo
    {
        public TxSignerInfo[] signer_infos { get; set; }
        public TxFee fee { get; set; }
    }


}
