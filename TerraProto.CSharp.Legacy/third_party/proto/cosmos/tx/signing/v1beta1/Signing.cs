using TerraProto.CSharp.third_party.proto.cosmos.tx.v1beta1;

namespace TerraProto.CSharp.third_party.proto.cosmos.tx.signing.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class SignatureDescriptors : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signatures")]
        public global::System.Collections.Generic.List<SignatureDescriptor> Signatures { get; } = new global::System.Collections.Generic.List<SignatureDescriptor>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignatureDescriptor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        public global::Google.Protobuf.WellKnownTypes.Any PublicKey { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Data data { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"sequence")]
        public ulong Sequence { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class Data : global::ProtoBuf.IExtensible
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

                [global::ProtoBuf.ProtoMember(2, Name = @"signature")]
                public byte[] Signature { get; set; }

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class Multi : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"bitarray")]
                public CompactBitArray Bitarray { get; set; }

                [global::ProtoBuf.ProtoMember(2, Name = @"signatures")]
                public global::System.Collections.Generic.List<SignatureDescriptor.Data> Signatures { get; } = new global::System.Collections.Generic.List<SignatureDescriptor.Data>();

            }
        }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MultiSignature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signatures")]
        public global::System.Collections.Generic.List<byte[]> Signatures { get; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CompactBitArray : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"extra_bits_stored")]
        public uint ExtraBitsStored { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"elems")]
        public byte[] Elems { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum SignMode
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SIGN_MODE_UNSPECIFIED")]
        SignModeUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGN_MODE_DIRECT")]
        SignModeDirect = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGN_MODE_TEXTUAL")]
        SignModeTextual = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGN_MODE_LEGACY_AMINO_JSON")]
        SignModeLegacyAminoJson = 127,
    }
}
