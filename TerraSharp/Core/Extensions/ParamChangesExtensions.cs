using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.iparams.v1beta1;
using System.Linq;
using System.Collections.Generic;
using Terra.Microsoft.Client.Core.Params;

namespace Terra.Microsoft.Client.Core.Extensions
{
    public static class ParamChangesExtensions
    {
        public static IEnumerable<ParamChangeAminoArgs> ToAmino(this IEnumerable<ParamChange> param)
        {
            return param.ToList().ConvertAll(w => w.ToAmino());
        }

        public static IEnumerable<ParamChangeDataArgs> ToData(this IEnumerable<ParamChange> param)
        {
            return param.ToList().ConvertAll(w => w.ToData());
        }

        public static IEnumerable<PROTO.ParamChange> ToProto(this IEnumerable<ParamChange> param)
        {
            return param.ToList().ConvertAll(w => w.ToProtoWithType());
        }

        public static IEnumerable<ParamChange> FromAmino(this IEnumerable<ParamChangeAminoArgs> param)
        {
            return param.ToList().ConvertAll(w => ParamChange.FromAmino(w));
        }

        public static IEnumerable<ParamChange> FromData(this IEnumerable<ParamChangeDataArgs> param)
        {
            return param.ToList().ConvertAll(w => ParamChange.FromData(w));
        }

        public static IEnumerable<ParamChange> FromProto(this IEnumerable<PROTO.ParamChange> param)
        {
            return param.ToList().ConvertAll(w => ParamChange.FromProto(w));
        }
    }
}
