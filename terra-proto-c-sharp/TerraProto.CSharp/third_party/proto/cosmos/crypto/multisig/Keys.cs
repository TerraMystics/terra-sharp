namespace TerraProto.CSharp.third_party.proto.cosmos.crypto.multisig
{
    [global::ProtoBuf.ProtoContract()]
    public partial class LegacyAminoPubKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"threshold")]
        public uint Threshold { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"public_keys")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> PublicKeys { get; set; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();
    }
}
