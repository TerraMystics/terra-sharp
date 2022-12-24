namespace TerraProto.CSharp.third_party.proto.tendermint.version
{
    [global::ProtoBuf.ProtoContract()]
    public partial class App : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"protocol")]
        public ulong Protocol { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"software")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Software { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Consensus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"block")]
        public ulong Block { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"app")]
        public ulong App { get; set; }
    }
}
