namespace TerraProto.CSharp.third_party.proto.cosmos.ibase.reflection.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class ListAllInterfacesRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ListAllInterfacesResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"interface_names")]
        public global::System.Collections.Generic.List<string> InterfaceNames { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ListImplementationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"interface_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InterfaceName { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ListImplementationsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"implementation_message_names")]
        public global::System.Collections.Generic.List<string> ImplementationMessageNames { get; } = new global::System.Collections.Generic.List<string>();

    }

    public partial interface IReflectionService
    {
        global::System.Threading.Tasks.ValueTask<ListAllInterfacesResponse> ListAllInterfacesAsync(ListAllInterfacesRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<ListImplementationsResponse> ListImplementationsAsync(ListImplementationsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
