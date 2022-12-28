
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;

namespace Terra.Microsoft.Rest
{
    public class PaginationOptions
    {
        public string Limit { get; set; }
        public string Offset { get; set; }
        public string Key { get; set; }
        public bool Count_total { get; set; }
        public bool Reverse { get; set; }
        public OrderBy Order_by { get; set; }
    }
}
