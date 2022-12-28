using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crypto.multisig.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MultiSignature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signatures")]
        public global::System.Collections.Generic.List<byte[]> Signatures { get; set; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CompactBitArray : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"extra_bits_stored")]
        public uint ExtraBitsStored { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"elems")]
        public byte[] Elems { get; set; }
    }
}
