using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraProto.CSharp.third_party.proto.cosmos.evidence.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"evidence")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> Evidences { get; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();
    }
}
