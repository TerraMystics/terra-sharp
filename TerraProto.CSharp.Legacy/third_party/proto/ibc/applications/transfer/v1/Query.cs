using ibc.applications.transfer.v1;
using TerraProto.CSharp.third_party.proto.cosmos.ibase.query.v1beta1;

namespace TerraProto.CSharp.third_party.proto.ibc.applications.transfer.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDenomTraceRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hash")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Hash { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDenomTraceResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom_trace")]
        public DenomTrace DenomTrace { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDenomTracesRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDenomTracesResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom_traces")]
        public global::System.Collections.Generic.List<DenomTrace> DenomTraces { get; } = new global::System.Collections.Generic.List<DenomTrace>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

    }
    public partial interface IQuery
    {
        global::System.Threading.Tasks.ValueTask<QueryDenomTraceResponse> DenomTraceAsync(QueryDenomTraceRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryDenomTracesResponse> DenomTracesAsync(QueryDenomTracesRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryParamsResponse> ParamsAsync(QueryParamsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
