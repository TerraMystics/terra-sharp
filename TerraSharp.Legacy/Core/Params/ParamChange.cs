using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.iparams.v1beta1;
using TerraSharp.Core.Constants;
using TerraSharp.Key.Data.SimplePublicKey;
using TerraNetExtensions.ProtoBufs;

namespace TerraSharp.Core.Params
{
    public class ParamChange
    {
        public readonly string subspace;
        public readonly string key;
        public readonly string value;

        public ParamChange(string subspace, string key, string value)
        {
            this.subspace = subspace;
            this.key = key;
            this.value = value;
        }

        public static ParamChange FromAmino(ParamChangeAminoArgs data)
        {
            return new ParamChange(data.Value.Subspace, data.Value.Key, data.Value.Value);
        }

        public static ParamChange FromData(ParamChangeDataArgs data)
        {
            return new ParamChange(data.Subspace, data.Key, data.Value);
        }

        public static ParamChange FromProto(PROTO.ParamChange data)
        {
            return new ParamChange(data.Subspace, data.Key, data.Value);
        }

        public ParamChangeAminoArgs ToAmino()
        {
            return new ParamChangeAminoArgs()
            {
                Value = new ParamChangeValueAminoArgs()
                {
                    Subspace = this.subspace,
                    Value = this.value,
                    Key = this.key,
                }
            };
        }

        public ParamChangeDataArgs ToData()
        {
            return new ParamChangeDataArgs()
            {
                Subspace = this.subspace,
                Value = this.value,
                Key = this.key,
            };
        }

        public PROTO.ParamChange ToProtoWithType()
        {
            return new PROTO.ParamChange()
            {
                Key = this.key,
                Subspace = this.subspace,
                Value = this.value
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class ParamChangeAminoArgs
    {
        public ParamChangeValueAminoArgs Value { get; set; }
    }

    public class ParamChangeValueAminoArgs
    {
        public string Subspace { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class ParamChangeDataArgs
    {
        public string Subspace { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
