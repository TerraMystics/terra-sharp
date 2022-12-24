using System;

namespace TerraSharp.Rest.Staking
{
    public class CommissionCommonArgsJSON
    {
        public CommissionRatesCommonValueArgs commission_rates { get; set; }
        public DateTime update_time { get; set; }
    }

    public class CommissionRatesCommonValueArgs
    {
        public decimal Rate { get; set; }
        public decimal Max_Rate { get; set; }
        public decimal Max_Change_Rate { get; set; }
    }
}
