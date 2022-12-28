using System.Linq;
using Terra.Microsoft.Client.Core.Extensions;
using Terra.Microsoft.Rest.Gov.Proposals;

namespace Terra.Microsoft.Client.Core.Gov
{
    public class ProposalsDepositParams
    {
        public decimal max_deposit_period { get; set; }
        public Coin[] min_deposit { get; set; }

        public static ProposalsDepositParams FromJSON(ProposalsDepositParamsJSON json)
        {
            return new ProposalsDepositParams()
            {
                max_deposit_period = decimal.Parse(json.max_deposit_period.Replace("s", string.Empty)),
                min_deposit = CoinsExtensions.FromJSON(json.min_deposit).ToArray()
            };
        }
    }
}
