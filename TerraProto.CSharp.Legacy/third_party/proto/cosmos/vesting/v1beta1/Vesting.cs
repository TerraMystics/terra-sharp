using cosmos.ibase.v1beta1;
using TerraProto.CSharp.third_party.proto.cosmos.auth.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.vesting.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class BaseVestingAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_account")]
        public BaseAccount BaseAccount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"original_vesting")]
        public global::System.Collections.Generic.List<Coin> OriginalVestings { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(3, Name = @"delegated_free")]
        public global::System.Collections.Generic.List<Coin> DelegatedFrees { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(4, Name = @"delegated_vesting")]
        public global::System.Collections.Generic.List<Coin> DelegatedVestings { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(5, Name = @"end_time")]
        public long EndTime { get; set; }
    }
}
