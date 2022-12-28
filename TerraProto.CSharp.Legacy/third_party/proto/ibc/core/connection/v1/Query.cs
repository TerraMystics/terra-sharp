using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.query.v1beta1;
using Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.connection.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConnectionId { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection")]
        public ConnectionEnd Connection { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connections")]
        public global::System.Collections.Generic.List<IdentifiedConnection> Connections { get; } = new global::System.Collections.Generic.List<IdentifiedConnection>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public Height Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientConnectionsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientConnectionsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection_paths")]
        public global::System.Collections.Generic.List<string> ConnectionPaths { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionClientStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConnectionId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionClientStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"identified_client_state")]
        public IdentifiedClientState IdentifiedClientState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionConsensusStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connection_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConnectionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"revision_number")]
        public ulong RevisionNumber { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"revision_height")]
        public ulong RevisionHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConnectionConsensusStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proof_height")]
        public Height ProofHeight { get; set; }
    }

    public partial interface IQuery
    {
        global::System.Threading.Tasks.ValueTask<QueryConnectionResponse> ConnectionAsync(QueryConnectionRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryConnectionsResponse> ConnectionsAsync(QueryConnectionsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryClientConnectionsResponse> ClientConnectionsAsync(QueryClientConnectionsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryConnectionClientStateResponse> ConnectionClientStateAsync(QueryConnectionClientStateRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryConnectionConsensusStateResponse> ConnectionConsensusStateAsync(QueryConnectionConsensusStateRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
