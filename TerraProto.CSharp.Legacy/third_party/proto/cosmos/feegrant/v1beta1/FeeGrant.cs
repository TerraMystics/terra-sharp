using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.feegrant.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class BasicAllowance : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"spend_limit")]
        public global::System.Collections.Generic.List<Coin> SpendLimits { get; set; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(2, Name = @"expiration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Expiration { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PeriodicAllowance : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"basic")]
        public BasicAllowance Basic { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"period", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? Period { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"period_spend_limit")]
        public global::System.Collections.Generic.List<Coin> PeriodSpendLimits { get; set; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(4, Name = @"period_can_spend")]
        public global::System.Collections.Generic.List<Coin> PeriodCanSpends { get; set; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(5, Name = @"period_reset", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? PeriodReset { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AllowedMsgAllowance : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"allowance")]
        public global::Google.Protobuf.WellKnownTypes.Any Allowance { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"allowed_messages")]
        public global::System.Collections.Generic.List<string> AllowedMessages { get; set; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Grant : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"allowance")]
        public global::Google.Protobuf.WellKnownTypes.Any Allowance { get; set; }

    }
}
