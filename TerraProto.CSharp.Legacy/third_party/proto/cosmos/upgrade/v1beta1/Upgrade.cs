namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.upgrade.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Plan : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        [global::System.Obsolete]
        public global::System.DateTime? Time { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"info")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Info { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"upgraded_client_state")]
        [global::System.Obsolete]
        public global::Google.Protobuf.WellKnownTypes.Any UpgradedClientState { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SoftwareUpgradeProposal : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CancelSoftwareUpgradeProposal : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModuleVersion : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"version")]
        public ulong Version { get; set; }

    }
}
