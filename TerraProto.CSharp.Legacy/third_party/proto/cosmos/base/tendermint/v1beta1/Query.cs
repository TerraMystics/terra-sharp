using tendermint.types;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.query.v1beta1;
using Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.types;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.tendermint.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GetValidatorSetByHeightRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetValidatorSetByHeightResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_height")]
        public long BlockHeight { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validators")]
        public global::System.Collections.Generic.List<Validator> Validators { get; } = new global::System.Collections.Generic.List<Validator>();

        [global::ProtoBuf.ProtoMember(3, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetLatestValidatorSetRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetLatestValidatorSetResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_height")]
        public long BlockHeight { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validators")]
        public global::System.Collections.Generic.List<Validator> Validators { get; } = new global::System.Collections.Generic.List<Validator>();

        [global::ProtoBuf.ProtoMember(3, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Validator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"pub_key")]
        public global::Google.Protobuf.WellKnownTypes.Any PubKey { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"voting_power")]
        public long VotingPower { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proposer_priority")]
        public long ProposerPriority { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetBlockByHeightRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetBlockByHeightResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_id")]
        public BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"block")]
        public Block Block { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetLatestBlockRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetLatestBlockResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block_id")]
        public BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"block")]
        public Block Block { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetSyncingRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetSyncingResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"syncing")]
        public bool Syncing { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetNodeInfoRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetNodeInfoResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"default_node_info")]
        public DefaultNodeInfo DefaultNodeInfo { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"application_version")]
        public VersionInfo ApplicationVersion { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VersionInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"app_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AppName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"git_commit")]
        [global::System.ComponentModel.DefaultValue("")]
        public string GitCommit { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"build_tags")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BuildTags { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"go_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string GoVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"build_deps")]
        public global::System.Collections.Generic.List<Module> BuildDeps { get; } = new global::System.Collections.Generic.List<Module>();

        [global::ProtoBuf.ProtoMember(8, Name = @"cosmos_sdk_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CosmosSdkVersion { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Module : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Path { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"sum")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sum { get; set; } = "";

    }
}
