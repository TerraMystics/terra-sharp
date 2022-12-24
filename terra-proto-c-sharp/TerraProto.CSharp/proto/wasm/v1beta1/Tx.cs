using cosmos.ibase.v1beta1;

namespace TerraProto.CSharp.proto.wasm.v1beta1
{
    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgStoreCodeResponse> StoreCodeAsync(MsgStoreCode value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgMigrateCodeResponse> MigrateCodeAsync(MsgMigrateCode value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgInstantiateContractResponse> InstantiateContractAsync(MsgInstantiateContract value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgExecuteContractResponse> ExecuteContractAsync(MsgExecuteContract value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgMigrateContractResponse> MigrateContractAsync(MsgMigrateContract value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgUpdateContractAdminResponse> UpdateContractAdminAsync(MsgUpdateContractAdmin value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<MsgClearContractAdminResponse> ClearContractAdminAsync(MsgClearContractAdmin value, global::ProtoBuf.Grpc.CallContext context = default);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgStoreCode : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"wasm_byte_code")]
        public byte[] WasmByteCode { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgStoreCodeResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code_id")]
        public ulong CodeId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgMigrateCode : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code_id")]
        public ulong CodeId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"wasm_byte_code")]
        public byte[] WasmByteCode { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgMigrateCodeResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgInstantiateContract : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"admin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Admin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"code_id")]
        public ulong CodeId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"init_msg")]
        public byte[] InitMsg { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"init_coins")]
        public global::System.Collections.Generic.List<Coin> InitCoins { get; set; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgInstantiateContractResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"contract_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ContractAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgExecuteContract : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"contract")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Contract { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"execute_msg")]
        public byte[] ExecuteMsg { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"coins")]
        public global::System.Collections.Generic.List<Coin> Coins { get; set; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgExecuteContractResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgMigrateContract : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"admin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Admin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"contract")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Contract { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"new_code_id")]
        public ulong NewCodeId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"migrate_msg")]
        public byte[] MigrateMsg { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgMigrateContractResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUpdateContractAdmin : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"admin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Admin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"new_admin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NewAdmin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"contract")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Contract { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUpdateContractAdminResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgClearContractAdmin : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"admin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Admin { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"contract")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Contract { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgClearContractAdminResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
