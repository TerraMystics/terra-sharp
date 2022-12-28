namespace Terra.Microsoft.Rest.Tx.Transaction
{
    public class TxFee
    {
        public CoinJSON[] amount { get; set; }
        public double gas_limit { get; set; }
        public string payer { get; set; }
        public string granter { get; set; }
    }


}
