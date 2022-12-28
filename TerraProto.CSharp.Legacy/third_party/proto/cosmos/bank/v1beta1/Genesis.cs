using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.bank.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"balances")]
        public global::System.Collections.Generic.List<Balance> Balances { get; } = new global::System.Collections.Generic.List<Balance>();

        [global::ProtoBuf.ProtoMember(3, Name = @"supply")]
        public global::System.Collections.Generic.List<Coin> Supplies { get; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(4, Name = @"denom_metadata")]
        public global::System.Collections.Generic.List<Metadata> DenomMetadatas { get; } = new global::System.Collections.Generic.List<Metadata>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Balance : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"coins")]
        public global::System.Collections.Generic.List<Coin> Coins { get; } = new global::System.Collections.Generic.List<Coin>();
    }
}
