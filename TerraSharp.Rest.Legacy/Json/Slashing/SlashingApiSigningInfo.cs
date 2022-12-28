namespace Terra.Microsoft.Rest.Slashing
{
    public class SlashingApiSigningInfo
    {
        public string address { get; set; }
        public string start_height { get; set; }
        public string index_offset { get; set; }
        public string jailed_until { get; set; }
        public bool tombstoned { get; set; }
        public string missed_blocks_counter { get; set; }
    }
}
