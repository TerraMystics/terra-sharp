namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.auth.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"accounts")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> Accounts { get; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();

    }
}
