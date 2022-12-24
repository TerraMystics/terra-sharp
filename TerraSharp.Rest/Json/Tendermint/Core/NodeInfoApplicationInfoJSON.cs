namespace TerraSharp.Rest.Tendermint.Core
{
    public class NodeInfoApplicationInfoJSON
    {
        public string name { get; set; }
        public string app_name { get; set; }
        public string version { get; set; }
        public string git_commit { get; set; }
        public string build_tags { get; set; }
        public string go_version { get; set; }
        public string cosmos_sdk_version { get; set; }
        public NodeInfoBuildDepsJSON[] build_deps { get; set; }
    }
}
