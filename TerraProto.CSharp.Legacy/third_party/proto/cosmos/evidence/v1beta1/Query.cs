using System;
using System.Collections.Generic;
using TerraProto.CSharp.third_party.proto.cosmos.ibase.query.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.evidence.v1beta1
{
    public partial interface IQuery
    {
        global::System.Threading.Tasks.ValueTask<QueryEvidenceResponse> EvidenceAsync(QueryEvidenceRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryAllEvidenceResponse> AllEvidenceAsync(QueryAllEvidenceRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryEvidenceRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"evidence_hash")]
        public byte[] EvidenceHash { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryEvidenceResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"evidence")]
        public global::Google.Protobuf.WellKnownTypes.Any Evidence { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryAllEvidenceRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryAllEvidenceResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"evidence")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> Evidences { get; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }
}
