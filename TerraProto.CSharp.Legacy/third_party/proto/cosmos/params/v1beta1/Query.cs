using TerraProto.CSharp.third_party.proto.ibc.applications.transfer.v1;

namespace TerraProto.CSharp.third_party.proto.cosmos.iparams.v1beta1
{
    public partial interface IQuery
    {
        global::System.Threading.Tasks.ValueTask<QueryParamsResponse> ParamsAsync(QueryParamsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"subspace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Subspace { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Key { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"param")]
        public ParamChange Param { get; set; }

    }
}
