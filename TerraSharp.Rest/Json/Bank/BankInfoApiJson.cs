namespace TerraSharp.Rest.Bank
{
    public class BankInfoApiJson
    {
        public CoinJSON[] supply { get; set; }
        public CoinJSON[] balances { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
