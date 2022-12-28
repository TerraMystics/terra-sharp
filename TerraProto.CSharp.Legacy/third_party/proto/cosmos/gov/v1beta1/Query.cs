using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.query.v1beta1;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.gov.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryProposalRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryProposalResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal")]
        public Proposal Proposal { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryProposalsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_status")]
        public ProposalStatus ProposalStatus { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"depositor")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Depositor { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryProposalsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposals")]
        public global::System.Collections.Generic.List<Proposal> Proposals { get; } = new global::System.Collections.Generic.List<Proposal>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryVoteRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"voter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Voter { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryVoteResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"vote")]
        public Vote Vote { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryVotesRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryVotesResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"votes")]
        public global::System.Collections.Generic.List<Vote> Votes { get; } = new global::System.Collections.Generic.List<Vote>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"params_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ParamsType { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryParamsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"voting_params")]
        public VotingParams VotingParams { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"deposit_params")]
        public DepositParams DepositParams { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"tally_params")]
        public TallyParams TallyParams { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDepositRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"depositor")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Depositor { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDepositResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"deposit")]
        public Deposit Deposit { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDepositsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryDepositsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"deposits")]
        public global::System.Collections.Generic.List<Deposit> Deposits { get; } = new global::System.Collections.Generic.List<Deposit>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryTallyResultRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proposal_id")]
        public ulong ProposalId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryTallyResultResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tally")]
        public TallyResult Tally { get; set; }

    }


    public partial interface IQuery
    {
        global::System.Threading.Tasks.ValueTask<QueryProposalResponse> ProposalAsync(QueryProposalRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryProposalsResponse> ProposalsAsync(QueryProposalsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryVoteResponse> VoteAsync(QueryVoteRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryVotesResponse> VotesAsync(QueryVotesRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryParamsResponse> ParamsAsync(QueryParamsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryDepositResponse> DepositAsync(QueryDepositRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryDepositsResponse> DepositsAsync(QueryDepositsRequest value, global::ProtoBuf.Grpc.CallContext context = default);
        global::System.Threading.Tasks.ValueTask<QueryTallyResultResponse> TallyResultAsync(QueryTallyResultRequest value, global::ProtoBuf.Grpc.CallContext context = default);
    }
}
