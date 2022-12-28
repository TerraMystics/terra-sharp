namespace Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.evidence.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class Equivocation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Time { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"power")]
        public long Power { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"consensus_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ConsensusAddress { get; set; } = "";
    }
}
