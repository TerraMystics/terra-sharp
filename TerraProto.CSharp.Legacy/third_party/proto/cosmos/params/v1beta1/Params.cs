namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.iparams.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class ParameterChangeProposal : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"changes")]
        public global::System.Collections.Generic.List<ParamChange> Changes { get; set; } = new global::System.Collections.Generic.List<ParamChange>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ParamChange : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"value")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Value { get; set; } = "";
    }
}
