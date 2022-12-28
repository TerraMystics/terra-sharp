using cosmos.ibase.v1beta1;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;

namespace Terra.Microsoft.ProtoBufs.proto.tx.v1beta1
{
    public partial interface IService
    {
        global::System.Threading.Tasks.ValueTask<ComputeTaxResponse> ComputeTaxAsync(ComputeTaxRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ComputeTaxRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        [global::System.Obsolete]
        public Tx Tx { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_bytes")]
        public byte[] TxBytes { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ComputeTaxResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tax_amount")]
        public global::System.Collections.Generic.List<Coin> TaxAmounts { get; } = new global::System.Collections.Generic.List<Coin>();

    }
}
