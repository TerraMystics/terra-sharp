using TerraSharp.Rest.Gov.Proposals;

namespace TerraSharp.Core.Gov
{
    public class ProposalsTallyParams
    {
        public decimal quorum { get; set; }
        public decimal veto_threshold { get; set; }
        public decimal threshold { get; set; }
        public static ProposalsTallyParams FromJSON(ProposalsTallyParamsJSON json)
        {
            return new ProposalsTallyParams()
            {
                quorum = decimal.Parse(json.quorum),
                threshold = decimal.Parse(json.threshold),
                veto_threshold = decimal.Parse(json.veto_threshold)
            };
        }
    }
}
