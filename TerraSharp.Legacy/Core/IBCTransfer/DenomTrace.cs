using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest;
using PROTO = ibc.applications.transfer.v1;

namespace TerraSharp.Core.IBCTransfer
{
    public class DenomTrace
    {
        public readonly string path;
        public readonly string base_denom;

        public DenomTrace(
           string path,
           string base_denom)
        {
            this.path = path;
            this.base_denom = base_denom;
        }

        public static DenomTrace FromAmino(DenomTraceAminoArgs data)
        {
            return new DenomTrace(
                data.Path,
                data.Base_Denom);
        }

        public static DenomTrace FromData(DenomTraceDataArgs data)
        {
            return new DenomTrace(
                data.Path,
                data.Base_Denom);
        }
        public static DenomTrace FromJSON(DenomTraceJSON data)
        {
            return new DenomTrace(
                data.Path,
                data.Base_Denom);
        }

        public static DenomTrace FromProto(PROTO.DenomTrace data)
        {
            return new DenomTrace(
                data.Path,
                data.BaseDenom);
        }

        public DenomTraceAminoArgs ToAmino()
        {
            return new DenomTraceAminoArgs()
            {
                Path = this.path,
                Base_Denom = this.base_denom,
            };
        }

        public DenomTraceDataArgs ToData()
        {
            return new DenomTraceDataArgs()
            {
                Path = this.path,
                Base_Denom = this.base_denom,
            };
        }

        public PROTO.DenomTrace ToProtoWithType()
        {
            return new PROTO.DenomTrace()
            {
                BaseDenom = this.base_denom,
                Path = this.path
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class DenomTraceAminoArgs : DenomTraceCommonArgs
    {
    }

    public class DenomTraceDataArgs : DenomTraceCommonArgs
    {

    }
    public class DenomTraceCommonArgs
    {
        public string Path { get; set; }
        public string Base_Denom { get; set; }
    }
}
