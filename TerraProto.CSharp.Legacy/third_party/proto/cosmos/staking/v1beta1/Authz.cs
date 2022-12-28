using cosmos.ibase.v1beta1;
using terra.market.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public enum AuthorizationType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"AUTHORIZATION_TYPE_UNSPECIFIED")]
        AuthorizationTypeUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"AUTHORIZATION_TYPE_DELEGATE")]
        AuthorizationTypeDelegate = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"AUTHORIZATION_TYPE_UNDELEGATE")]
        AuthorizationTypeUndelegate = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"AUTHORIZATION_TYPE_REDELEGATE")]
        AuthorizationTypeRedelegate = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StakeAuthorization_Validators : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        public string[] Address { get; set; }
    }


    [global::ProtoBuf.ProtoContract()]
    public partial class StakeAuthorization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_tokens")]
        public Coin MaxTokens { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"allow_list")]
        public Validators AllowList
        {
            get => __pbn__validators.Is(2) ? ((Validators)__pbn__validators.Object) : default;
            set => __pbn__validators = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
        }
        public bool ShouldSerializeAllowList() => __pbn__validators.Is(2);
        public void ResetAllowList() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__validators, 2);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__validators;

        [global::ProtoBuf.ProtoMember(3, Name = @"deny_list")]
        public Validators DenyList
        {
            get => __pbn__validators.Is(3) ? ((Validators)__pbn__validators.Object) : default;
            set => __pbn__validators = new global::ProtoBuf.DiscriminatedUnionObject(3, value);
        }
        public bool ShouldSerializeDenyList() => __pbn__validators.Is(3);
        public void ResetDenyList() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__validators, 3);

        [global::ProtoBuf.ProtoMember(4, Name = @"authorization_type")]
        public AuthorizationType AuthorizationType { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class Validators : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"address")]
            public global::System.Collections.Generic.List<string> Addresses { get; set; } = new global::System.Collections.Generic.List<string>();

        }
    }
}
