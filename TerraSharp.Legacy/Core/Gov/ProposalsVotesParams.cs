using TerraSharp.Rest.Gov.Proposals;

namespace TerraSharp.Core.Gov
{
    public class ProposalsVotesParams
    {
        public double voting_period { get; set; }
        public static ProposalsVotesParams FromJSON(ProposalsVotingParamsJSON json)
        {
            return new ProposalsVotesParams()
            {
                voting_period = double.Parse(json.voting_period.Replace("s", string.Empty))
            };
        }
    }
}
