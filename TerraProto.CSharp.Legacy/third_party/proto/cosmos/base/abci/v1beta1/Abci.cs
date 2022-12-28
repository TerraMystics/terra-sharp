using Terra.Microsoft.ProtoBufs.third_party.proto.tendermint.abci;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.abci.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class TxResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"txhash")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Txhash { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"codespace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Codespace { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"code")]
        public uint Code { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"data")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Data { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"raw_log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RawLog { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"logs")]
        public global::System.Collections.Generic.List<ABCIMessageLog> Logs { get; } = new global::System.Collections.Generic.List<ABCIMessageLog>();

        [global::ProtoBuf.ProtoMember(8, Name = @"info")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Info { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"gas_wanted")]
        public long GasWanted { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"gas_used")]
        public long GasUsed { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"tx")]
        public global::Google.Protobuf.WellKnownTypes.Any Tx { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"timestamp")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Timestamp { get; set; } = "";

        [global::ProtoBuf.ProtoMember(13, Name = @"events")]
        public global::System.Collections.Generic.List<Event> Events { get; } = new global::System.Collections.Generic.List<Event>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ABCIMessageLog : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"msg_index")]
        public uint MsgIndex { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Log { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"events")]
        public global::System.Collections.Generic.List<StringEvent> Events { get; set; } = new global::System.Collections.Generic.List<StringEvent>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StringEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Type { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"attributes")]
        public global::System.Collections.Generic.List<Attribute> Attributes { get; set; } = new global::System.Collections.Generic.List<Attribute>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Attribute : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Key { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Value { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GasInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"gas_wanted")]
        public ulong GasWanted { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"gas_used")]
        public ulong GasUsed { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Result : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        public byte[] Data { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"log")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Log { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"events")]
        public global::System.Collections.Generic.List<Event> Events { get; } = new global::System.Collections.Generic.List<Event>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SimulationResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"gas_info")]
        public GasInfo GasInfo { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"result")]
        public Result Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"msg_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MsgType { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxMsgData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        public global::System.Collections.Generic.List<MsgData> Datas { get; } = new global::System.Collections.Generic.List<MsgData>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SearchTxsResult : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"total_count")]
        public ulong TotalCount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"count")]
        public ulong Count { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"page_number")]
        public ulong PageNumber { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"page_total")]
        public ulong PageTotal { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"limit")]
        public ulong Limit { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"txs")]
        public global::System.Collections.Generic.List<TxResponse> Txs { get; } = new global::System.Collections.Generic.List<TxResponse>();

    }
}
