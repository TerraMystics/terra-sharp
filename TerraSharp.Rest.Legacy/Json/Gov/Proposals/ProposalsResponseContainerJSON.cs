using Newtonsoft.Json;
using System;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1;

namespace Terra.Microsoft.Rest.Gov.Proposals
{
    public class ProposalsResponseContainerJSON
    {
        public ProposalsResponseContainerValueJSON proposal { get; set; }
    }

    public class ProposalsResponseContainerValueJSON
    {
        public string proposal_id { get; set; }
        public string status { get; set; }
        public DateTime submit_time { get; set; }
        public ProposalsFinallTallyResults final_tally_result { get; set; }
        public DateTime deposit_end_time { get; set; }
        public ProposalsFinallTallyResults tally { get; set; }
        public CoinJSON[] total_deposit { get; set; }
        public DateTime voting_start_time { get; set; }
        public DateTime voting_end_time { get; set; }
        public ProposalDepositsJSON[] deposits { get; set; }
        public VotesJSON[] votes { get; set; }
        public ProposalContent content { get; set; }
    }

    public class ProposalContent
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string subject_client_id { get; set; }
        public string substitute_client_id { get; set; }
    }
}
