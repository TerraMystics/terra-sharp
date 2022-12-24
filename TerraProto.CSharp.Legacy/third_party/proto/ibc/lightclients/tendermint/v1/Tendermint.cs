using Ics23;
using tendermint.types;
using TerraProto.CSharp.third_party.proto.ibc.core.client.v1;
using TerraProto.CSharp.third_party.proto.ibc.core.commitment.v1;
using TerraProto.CSharp.third_party.proto.tendermint.types;

namespace TerraProto.CSharp.third_party.proto.ibc.lightclients.tendermint.v1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ClientState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"chain_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChainId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"trust_level")]
        public Fraction TrustLevel { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"trusting_period", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? TrustingPeriod { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"unbonding_period", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? UnbondingPeriod { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"max_clock_drift", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.TimeSpan? MaxClockDrift { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"frozen_height")]
        public Height FrozenHeight { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"latest_height")]
        public Height LatestHeight { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"proof_specs")]
        public global::System.Collections.Generic.List<ProofSpec> ProofSpecs { get; } = new global::System.Collections.Generic.List<ProofSpec>();

        [global::ProtoBuf.ProtoMember(9, Name = @"upgrade_path")]
        public global::System.Collections.Generic.List<string> UpgradePaths { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(10, Name = @"allow_update_after_expiry")]
        public bool AllowUpdateAfterExpiry { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"allow_update_after_misbehaviour")]
        public bool AllowUpdateAfterMisbehaviour { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ConsensusState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"timestamp", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"root")]
        public MerkleRoot Root { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"next_validators_hash")]
        public byte[] NextValidatorsHash { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Misbehaviour : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"header_1")]
        public Header Header1 { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"header_2")]
        public Header Header2 { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Header : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signed_header")]
        public SignedHeader SignedHeader { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_set")]
        public ValidatorSet ValidatorSet { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"trusted_height")]
        public Height TrustedHeight { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"trusted_validators")]
        public ValidatorSet TrustedValidators { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Fraction : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"numerator")]
        public ulong Numerator { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"denominator")]
        public ulong Denominator { get; set; }

    }
}
