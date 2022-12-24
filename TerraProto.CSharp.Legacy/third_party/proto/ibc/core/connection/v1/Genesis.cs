namespace TerraProto.CSharp.third_party.proto.ibc.core.connection.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"connections")]
        public global::System.Collections.Generic.List<IdentifiedConnection> Connections { get; } = new global::System.Collections.Generic.List<IdentifiedConnection>();

        [global::ProtoBuf.ProtoMember(2, Name = @"client_connection_paths")]
        public global::System.Collections.Generic.List<ConnectionPaths> ClientConnectionPaths { get; } = new global::System.Collections.Generic.List<ConnectionPaths>();

        [global::ProtoBuf.ProtoMember(3, Name = @"next_connection_sequence")]
        public ulong NextConnectionSequence { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"params")]
        public Params Params { get; set; }
    }
}
