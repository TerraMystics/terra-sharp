namespace TerraProto.CSharp.third_party.proto.cosmos.evidence.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSubmitEvidence : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"submitter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Submitter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"evidence")]
        public global::Google.Protobuf.WellKnownTypes.Any Evidence { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSubmitEvidenceResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(4, Name = @"hash")]
        public byte[] Hash { get; set; }

    }

    public partial interface IMsg
    {
        global::System.Threading.Tasks.ValueTask<MsgSubmitEvidenceResponse> SubmitEvidenceAsync(MsgSubmitEvidence value, global::ProtoBuf.Grpc.CallContext context = default);
    }

}
