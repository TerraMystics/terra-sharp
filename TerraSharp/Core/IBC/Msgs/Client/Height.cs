using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;

namespace Terra.Microsoft.Client.Core.IBC.Msgs.Client
{
    public class Height
    {
        public readonly double revision_number;
        public readonly double revision_height;

        public Height(
            double revision_number,
            double revision_height)
        {
            this.revision_number = revision_number;
            this.revision_height = revision_height;
        }

        public static Height FromAmino(HeightAminoArgs data)
        {
            return new Height(double.Parse(data.Revision_Number), double.Parse(data.Revision_Height));
        }

        public static Height FromData(HeightDataArgs data)
        {
            return new Height(double.Parse(data.Revision_Number), double.Parse(data.Revision_Height));
        }

        public static Height FromProto(PROTO.Height data)
        {
            return new Height(data.RevisionNumber, data.RevisionHeight);
        }
        public static Height FromJSON(HeightJSON data)
        {
            return new Height(double.Parse(data.Revision_Number), double.Parse(data.Revision_Height));
        }

        public HeightAminoArgs ToAmino()
        {
            return new HeightAminoArgs()
            {
                Revision_Number = this.revision_number.ToString(),
                Revision_Height = this.revision_height.ToString(),
            };
        }

        public HeightDataArgs ToData()
        {
            return new HeightDataArgs()
            {
                Revision_Number = this.revision_number.ToString(),
                Revision_Height = this.revision_height.ToString(),
            };
        }

        public PROTO.Height ToProtoWithType()
        {
            return new PROTO.Height()
            {
                RevisionHeight = (ulong)this.revision_height,
                RevisionNumber = (ulong)this.revision_number
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class HeightAminoArgs : HeightCommonArgs
    {
    }

    public class HeightDataArgs : HeightCommonArgs
    {
    }

    public class HeightCommonArgs
    {
        public string Revision_Number { get; set; }
        public string Revision_Height { get; set; }
    }
}
