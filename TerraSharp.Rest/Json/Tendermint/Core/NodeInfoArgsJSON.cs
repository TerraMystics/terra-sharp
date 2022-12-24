namespace TerraSharp.Rest.Tendermint.Core
{
    public class NodeInfoArgsJSON
    {
        public NodeInfoArgsProtocolVersion protocol_version { get; set; }

        public string default_node_id { get; set; }
        public string listen_addr { get; set; }
        public string network { get; set; }
        public string version { get; set; }
        public string channels { get; set; }
        public string moniker { get; set; }
        public NodeInfoOtherJSON other { get; set; }
    }
}
