using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraProto.CSharp.third_party.proto.cosmos.ibase.query.v1beta1;

namespace TerraProto.CSharp.third_party.proto.ibc.core.client.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientStatesRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientStatesResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_states")]
        public global::System.Collections.Generic.List<IdentifiedClientState> ClientStates { get; } = new global::System.Collections.Generic.List<IdentifiedClientState>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConsensusStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"revision_number")]
        public ulong RevisionNumber { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"revision_height")]
        public ulong RevisionHeight { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"latest_height")]
        public bool LatestHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConsensusStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"proof")]
        public byte[] Proof { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"proof_height")]
        public Height ProofHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConsensusStatesRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryConsensusStatesResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"consensus_states")]
        public global::System.Collections.Generic.List<ConsensusStateWithHeight> ConsensusStates { get; } = new global::System.Collections.Generic.List<ConsensusStateWithHeight>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientStatusRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientStatusResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"status")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Status { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientParamsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClientParamsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUpgradedClientStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUpgradedClientStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"upgraded_client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any UpgradedClientState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUpgradedConsensusStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryUpgradedConsensusStateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"upgraded_consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any UpgradedConsensusState { get; set; }

    }

}
