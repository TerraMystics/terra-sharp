using TerraProto.CSharp.third_party.proto.cosmos.ibase.query.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.authz.v1beta1
{
    public partial interface IQuery
    {
        global::System.Threading.Tasks.ValueTask<QueryGrantsResponse> GrantsAsync(QueryGrantsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }


    [global::ProtoBuf.ProtoContract()]
    public partial class QueryGrantsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"msg_type_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MsgTypeUrl { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryGrantsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"grants")]
        public global::System.Collections.Generic.List<Grant> Grants { get; } = new global::System.Collections.Generic.List<Grant>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }
    }
}
