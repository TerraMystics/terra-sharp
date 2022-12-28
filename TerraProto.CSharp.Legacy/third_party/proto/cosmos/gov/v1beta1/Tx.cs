using cosmos.ibase.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSubmitProposal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"content")]
        public global::Google.Protobuf.WellKnownTypes.Any Content { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"initial_deposit")]
        public global::System.Collections.Generic.List<Coin> InitialDeposits { get; set; } = new global::System.Collections.Generic.List<Coin>();

        [global::ProtoBuf.ProtoMember(3, Name = @"proposer")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Proposer { get; set; } = "";
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSubmitProposalResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgVote : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"option")]
        public VoteOption Option { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgVoteResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgVoteWeighted : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"options")]
        public global::System.Collections.Generic.List<WeightedVoteOption> Options { get; set; } = new global::System.Collections.Generic.List<WeightedVoteOption>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgVoteWeightedResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDeposit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"depositor")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Depositor { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public global::System.Collections.Generic.List<Coin> Amounts { get; set; } = new global::System.Collections.Generic.List<Coin>();
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDepositResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
}
