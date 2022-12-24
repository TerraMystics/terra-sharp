using TerraProto.CSharp.third_party.proto.cosmos.vesting.v1beta1;

namespace TerraProto.CSharp.proto.vesting.v1beta1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class LazyGradedVestingAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_vesting_account")]
        public BaseVestingAccount BaseVestingAccount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"vesting_schedules")]
        public global::System.Collections.Generic.List<VestingSchedule> VestingSchedules { get; set; } = new global::System.Collections.Generic.List<VestingSchedule>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Schedule : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"start_time")]
        public long StartTime { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"end_time")]
        public long EndTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"ratio")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Ratio { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VestingSchedule : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"denom")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Denom { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"schedules")]
        public global::System.Collections.Generic.List<Schedule> Schedules { get; set; } = new global::System.Collections.Generic.List<Schedule>();

    }
}
