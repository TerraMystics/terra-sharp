using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.upgrade.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.client.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class IdentifiedClientState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ClientState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConsensusStateWithHeight : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public Height Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"consensus_state")]
        public global::Google.Protobuf.WellKnownTypes.Any ConsensusState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClientConsensusStates : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"consensus_states")]
        public global::System.Collections.Generic.List<ConsensusStateWithHeight> ConsensusStates { get; set; } = new global::System.Collections.Generic.List<ConsensusStateWithHeight>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClientUpdateProposal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"title")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Title { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"description")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Description { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"subject_client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SubjectClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"substitute_client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SubstituteClientId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UpgradeProposal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"title")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Title { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"description")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Description { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"plan")]
        public Plan Plan { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"upgraded_client_state")]
        public global::Google.Protobuf.WellKnownTypes.Any UpgradedClientState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Height : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"revision_number")]
        public ulong RevisionNumber { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"revision_height")]
        public ulong RevisionHeight { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"allowed_clients")]
        public global::System.Collections.Generic.List<string> AllowedClients { get; set; } = new global::System.Collections.Generic.List<string>();

    }
}
