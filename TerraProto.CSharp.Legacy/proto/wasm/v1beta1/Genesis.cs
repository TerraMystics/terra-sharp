namespace Terra.Microsoft.ProtoBufs.proto.wasm.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params")]
        public Params Params { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"last_code_id")]
        public ulong LastCodeId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"last_instance_id")]
        public ulong LastInstanceId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"codes")]
        public global::System.Collections.Generic.List<Code> Codes { get; } = new global::System.Collections.Generic.List<Code>();

        [global::ProtoBuf.ProtoMember(5, Name = @"contracts")]
        public global::System.Collections.Generic.List<Contract> Contracts { get; } = new global::System.Collections.Generic.List<Contract>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Model : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        public byte[] Value { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Code : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code_info")]
        public CodeInfo CodeInfo { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"code_bytes")]
        public byte[] CodeBytes { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Contract : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"contract_info")]
        public ContractInfo ContractInfo { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"contract_store")]
        public global::System.Collections.Generic.List<Model> ContractStores { get; } = new global::System.Collections.Generic.List<Model>();

    }
}
