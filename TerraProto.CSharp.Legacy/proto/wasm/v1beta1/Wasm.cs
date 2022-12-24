namespace TerraProto.CSharp.proto.wasm.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_contract_size")]
        public ulong MaxContractSize { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"max_contract_gas")]
        public ulong MaxContractGas { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"max_contract_msg_size")]
        public ulong MaxContractMsgSize { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CodeInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code_id")]
        public ulong CodeId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"code_hash")]
        public byte[] CodeHash { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"creator")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Creator { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ContractInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"creator")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Creator { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"admin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Admin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"code_id")]
        public ulong CodeId { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"init_msg")]
        public byte[] InitMsg { get; set; }

    }
}
