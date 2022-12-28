namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"starting_proposal_id")]
        public ulong StartingProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"deposits")]
        public global::System.Collections.Generic.List<Deposit> Deposits { get; } = new global::System.Collections.Generic.List<Deposit>();

        [global::ProtoBuf.ProtoMember(3, Name = @"votes")]
        public global::System.Collections.Generic.List<Vote> Votes { get; } = new global::System.Collections.Generic.List<Vote>();

        [global::ProtoBuf.ProtoMember(4, Name = @"proposals")]
        public global::System.Collections.Generic.List<Proposal> Proposals { get; } = new global::System.Collections.Generic.List<Proposal>();

        [global::ProtoBuf.ProtoMember(5, Name = @"deposit_params")]
        public DepositParams DepositParams { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"voting_params")]
        public VotingParams VotingParams { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"tally_params")]
        public TallyParams TallyParams { get; set; }
    }
}
