using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.bank.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Params : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"send_enabled")]
        public global::System.Collections.Generic.List<SendEnabled> SendEnableds { get; } = new global::System.Collections.Generic.List<SendEnabled>();

        [global::ProtoBuf.ProtoMember(2, Name = @"default_send_enabled")]
        public bool DefaultSendEnabled { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SendEnabled : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Denom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"enabled")]
        public bool Enabled { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Input : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"coins")]
        public global::System.Collections.Generic.List<Coin> Coins { get; set; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Output : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"coins")]
        public global::System.Collections.Generic.List<Coin> Coins { get; set; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    [global::System.Obsolete]
    public partial class Supply : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"total")]
        public global::System.Collections.Generic.List<Coin> Totals { get; } = new global::System.Collections.Generic.List<Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DenomUnit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Denom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"exponent")]
        public uint Exponent { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"aliases")]
        public global::System.Collections.Generic.List<string> Aliases { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Metadata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"description")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Description { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"denom_units")]
        public global::System.Collections.Generic.List<DenomUnit> DenomUnits { get; } = new global::System.Collections.Generic.List<DenomUnit>();

        [global::ProtoBuf.ProtoMember(3, Name = @"base")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Base { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"display")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Display { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"symbol")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Symbol { get; set; } = "";

    }
}
