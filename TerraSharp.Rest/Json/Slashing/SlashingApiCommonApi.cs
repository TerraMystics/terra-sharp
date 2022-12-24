namespace TerraSharp.Rest.Slashing
{
    public class SlashingApiCommonApi
    {
        public SlashingApiSigningInfo val_signing_info { get; set; }
        public SlashingApiSigningInfo[] info { get; set; }
        public PaginationJson pagination { get; set; }
        public SlashingApiSigningInfoParams @params { get; set; }
    }
}
