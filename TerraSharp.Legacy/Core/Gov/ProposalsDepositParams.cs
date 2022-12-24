using System.Linq;
using TerraSharp.Core.Extensions;
using TerraSharp.Rest.Gov.Proposals;

namespace TerraSharp.Core.Gov
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
