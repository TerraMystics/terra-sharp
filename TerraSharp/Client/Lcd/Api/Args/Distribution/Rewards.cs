
using Terra.Microsoft.Client.Core;

namespace Terra.Microsoft.Client.Lcd.Api.Args.Distribution
{
    /// <summary>
    /// Total Rewards Queried against a Validator Address
    /// </summary>
    public class Rewards
    {
        /// <summary>
        /// Validator Address to query rewards
        /// </summary>
        public string Validator_address { get; set; }

        /// <summary>
        /// Amount of Rewards awarded to the user
        /// </summary>
        public Coin[] RewardsItems { get; set; }
    }
}
