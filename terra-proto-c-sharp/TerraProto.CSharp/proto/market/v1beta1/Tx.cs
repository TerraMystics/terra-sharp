using cosmos.ibase.v1beta1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraProto.CSharp.proto.market.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSwap : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"trader")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Trader { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"offer_coin")]
        public Coin OfferCoin { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"ask_denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AskDenom { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSwapResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"swap_coin")]
        public Coin SwapCoin { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"swap_fee")]
        public Coin SwapFee { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSwapSend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"from_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FromAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"to_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ToAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"offer_coin")]
        public Coin OfferCoin { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"ask_denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AskDenom { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSwapSendResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"swap_coin")]
        public Coin SwapCoin { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"swap_fee")]
        public Coin SwapFee { get; set; }

    }
}
