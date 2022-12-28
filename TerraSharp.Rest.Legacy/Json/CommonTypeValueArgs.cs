using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.StringExt;

namespace Terra.Microsoft.Rest
{
    public class CommonTypeValueArgs
    {
        public string Type_url { get; set; }
        public string Value { get; set; }

        public Any ToProto()
        {
            return new Any()
            {
                Value = TerraStringExtensions.GetBytesFromString(this.Value),
                TypeUrl = this.Type_url
            };
        }
    }
}
