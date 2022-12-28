using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.ProtoBufs.proto.keys;

namespace Terra.Microsoft.Client.Core.Extensions
{
    public static class KeysDtoExtensions
    {
        public static Any PackAny(this KeysDto dto)
        {
            return new Any()
            {
                TypeUrl = dto.TypeUrl,
                Value = TerraStringExtensions.GetBase64BytesFromString(dto.Key)
            };
        }
    }
}
