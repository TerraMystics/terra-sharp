using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraProto.CSharp.proto.keys;
using TerraSharp.Core.Keys.Constants;

namespace TerraSharp.Core.Extensions
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
