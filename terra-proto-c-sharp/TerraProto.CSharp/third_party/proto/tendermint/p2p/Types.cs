﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace tendermint.types
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NetAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"ip")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Ip { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"port")]
        public uint Port { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtocolVersion : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"p2p")]
        public ulong P2p { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"block")]
        public ulong Block { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"app")]
        public ulong App { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DefaultNodeInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"protocol_version")]
        public ProtocolVersion ProtocolVersion { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"default_node_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DefaultNodeId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"listen_addr")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ListenAddr { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"network")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Network { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"channels")]
        public byte[] Channels { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"moniker")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Moniker { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"other")]
        public DefaultNodeInfoOther Other { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DefaultNodeInfoOther : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx_index")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TxIndex { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"rpc_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RpcAddress { get; set; } = "";
    }
}
#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion