using cosmos.ibase.v1beta1;
using Google.Protobuf.WellKnownTypes;
using ProtoBuf;
using System.ComponentModel;
using System.Xml.Linq;
using terra.market.v1beta1;
using Terra.Microsoft.ProtoBufs.proto.keys;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crypto.secp256k1;
using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Tx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"body")]
        public TxBody Body { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"auth_info")]
        public AuthInfo AuthInfo { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signatures")]
        public global::System.Collections.Generic.List<string> Signatures { get; set; } = new global::System.Collections.Generic.List<string>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxRaw : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"body_bytes")]
        public byte[] BodyBytes { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"auth_info_bytes")]
        public byte[] AuthInfoBytes { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"signatures")]
        public global::System.Collections.Generic.List<byte[]> Signatures { get; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignDoc : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"body_bytes")]
        public byte[] BodyBytes { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"auth_info_bytes")]
        public byte[] AuthInfoBytes { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"chain_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChainId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"account_number")]
        public ulong AccountNumber { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxBody : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"messages")]
        public global::System.Collections.Generic.List<Any> Messages { get; set; } = new global::System.Collections.Generic.List<Any>();

        [global::ProtoBuf.ProtoMember(2, Name = @"memo")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Memo { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"timeout_height")]
        public ulong TimeoutHeight { get; set; }

        [global::ProtoBuf.ProtoMember(1023, Name = @"extension_options")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> ExtensionOptions { get; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();

        [global::ProtoBuf.ProtoMember(2047, Name = @"non_critical_extension_options")]
        public global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any> NonCriticalExtensionOptions { get; } = new global::System.Collections.Generic.List<global::Google.Protobuf.WellKnownTypes.Any>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AuthInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signer_infos")]
        public global::System.Collections.Generic.List<SignerInfo> SignerInfos { get; set; } = new global::System.Collections.Generic.List<SignerInfo>();

        [global::ProtoBuf.ProtoMember(2, Name = @"fee")]
        public Fee Fee { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignerInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        public Any PublicKey { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"mode_info")]
        public ModeInfo ModeInfo { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"sequence")]
        public ulong Sequence { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModeInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public Single single
        {
            get => __pbn__sum.Is(1) ? ((Single)__pbn__sum.Object) : default;
            set => __pbn__sum = new global::ProtoBuf.DiscriminatedUnionObject(1, value);
        }
        public bool ShouldSerializesingle() => __pbn__sum.Is(1);
        public void Resetsingle() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__sum, 1);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__sum;

        [global::ProtoBuf.ProtoMember(2)]
        public Multi multi
        {
            get => __pbn__sum.Is(2) ? ((Multi)__pbn__sum.Object) : default;
            set => __pbn__sum = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
        }
        public bool ShouldSerializemulti() => __pbn__sum.Is(2);
        public void Resetmulti() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__sum, 2);

        [global::ProtoBuf.ProtoContract()]
        public partial class Single : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"mode")]
            public SignMode Mode { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Multi : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"bitarray")]
            public CompactBitArray Bitarray { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"mode_infos")]
            public global::System.Collections.Generic.List<ModeInfo> ModeInfos { get; set; } = new global::System.Collections.Generic.List<ModeInfo>();

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Fee : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"amount")]
        public global::System.Collections.Generic.List<Coin> Amounts { get; set; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(2, Name = @"gas_limit")]
        public ulong GasLimit { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"payer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Payer { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";
    }
}
