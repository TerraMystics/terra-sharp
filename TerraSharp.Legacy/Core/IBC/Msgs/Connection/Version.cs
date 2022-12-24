using System.Linq;
using TerraNetExtensions.ProtoBufs;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.connection.v1;

namespace TerraSharp.Core.IBC.Msgs.Connection
{
    public class Version
    {
        public readonly string identifier;
        public readonly string[] features;

        public Version(
            string identifier,
            string[] features)
        {
            this.identifier = identifier;
            this.features = features;
        }
        public static Version FromAmino(VersionAminoArgs data)
        {
            return new Version(data.Identifier, data.Features);
        }

        public static Version FromData(VersionDataArgs data)
        {
            return new Version(data.Identifier, data.Features);
        }

        public static Version FromProto(PROTO.Version data)
        {
            return new Version(data.Identifier, data.Features.ToArray());
        }

        public VersionAminoArgs ToAmino()
        {
            return new VersionAminoArgs()
            {
                Identifier = this.identifier,
                Features = this.features
            };
        }

        public VersionDataArgs ToData()
        {
            return new VersionDataArgs()
            {
                Identifier = this.identifier,
                Features = this.features
            };
        }

        public PROTO.Version ToProtoWithType()
        {
            return new PROTO.Version()
            {
                Features = this.features.ToList(),
                Identifier = this.identifier
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }
    public class VersionAminoArgs : VersionCommonArgs
    {
    }
    public class VersionDataArgs : VersionCommonArgs
    {
    }

    public class VersionCommonArgs
    {
        public string Identifier { get; set; }
        public string[] Features { get; set; }
    }
}
