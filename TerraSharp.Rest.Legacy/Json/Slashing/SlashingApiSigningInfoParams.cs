namespace Terra.Microsoft.Rest.Slashing
{
    public class SlashingApiSigningInfoParams
    {
        public string signed_blocks_window { get; set; }
        public string min_signed_per_window { get; set; }
        public string downtime_jail_duration { get; set; }
        public string slash_fraction_double_sign { get; set; }
        public string slash_fraction_downtime { get; set; }
    }
}
