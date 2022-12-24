namespace TerraSharp.Rest.IBC
{
    public class CommonIBCParamsJson
    {
        public IBCApiClientStates[] client_states { get; set; }
        public IBCAPIParams @params { get; set; }
        public PaginationJson pagination { get; set; }
        public IBCApiConsensusState[] consensus_states { get; set; }
    }
}
