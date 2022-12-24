using System;

namespace TerraSharp.Rest.Tendermint.Blocks
{
    public class BlockHeader
    {
        public BlockVersion version { get; set; }
        public string chain_id { get; set; }
        public string height { get; set; }
        public DateTime time { get; set; }
        public BlockInfo last_block_id { get; set; }
        public string last_commit_hash { get; set; }
        public string data_hash { get; set; }
        public string validators_hash { get; set; }
        public string next_validators_hash { get; set; }
        public string consensus_hash { get; set; }
        public string app_hash { get; set; }
        public string last_results_hash { get; set; }
        public string evidence_hash { get; set; }
        public string proposer_address { get; set; }


    }
}
