using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraNetExtensions.StringExt;
using TerraSharp.Core.Constants;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace TerraSharp.Core.Staking
{
    public class Entry
    {
        public readonly int initial_balance;
        public readonly int balance;
        public readonly decimal shares_dst;
        public readonly double creation_height;
        public readonly DateTime completion_time;

        public Entry(
            int initial_balance,
            int balance,
            decimal shares_dst,
            double creation_height,
            DateTime completion_time
            )
        {
            this.initial_balance = initial_balance;
            this.balance = balance;
            this.shares_dst = shares_dst;
            this.creation_height = creation_height;
            this.completion_time = completion_time;
        }

        public static Entry FromAmino(EntryAminoArgs data)
        {
            return new Entry(
                int.Parse(data.Redelegation_Entry.Initial_Balance),
                int.Parse(data.Balance),
                decimal.Parse(data.Redelegation_Entry.Shares_Dst),
                double.Parse(data.Redelegation_Entry.Creation_Height),
                TerraStringExtensions.GetISODateTimeFromString(data.Redelegation_Entry.Completion_Time));
        }

        public static Entry FromData(EntryDataArgs data)
        {
            return new Entry(
              int.Parse(data.Redelegation_Entry.Initial_Balance),
              int.Parse(data.Balance),
              decimal.Parse(data.Redelegation_Entry.Shares_Dst),
              double.Parse(data.Redelegation_Entry.Creation_Height),
              TerraStringExtensions.GetISODateTimeFromString(data.Redelegation_Entry.Completion_Time));
        }

        public static Entry FromProto(PROTO.RedelegationEntryResponse data)
        {
            return new Entry(
                 int.Parse(data.RedelegationEntry.InitialBalance),
                 int.Parse(data.Balance),
                 decimal.Parse(data.RedelegationEntry.SharesDst),
                 data.RedelegationEntry.CreationHeight,
                 data.RedelegationEntry.CompletionTime.Value);
        }

        public EntryAminoArgs ToAmino()
        {
            return new EntryAminoArgs()
            {
                Balance = this.balance.ToString(),
                Redelegation_Entry = new EntryValueCommonArgs()
                {
                    Completion_Time = TerraStringExtensions.GetISOStringFromDate(this.completion_time),
                    Creation_Height = this.creation_height.ToString(),
                    Initial_Balance = this.initial_balance.ToString(),
                    Shares_Dst = this.shares_dst.ToString()
                }
            };
        }

        public EntryDataArgs ToData()
        {
            return new EntryDataArgs()
            {
                Balance = this.balance.ToString(),
                Redelegation_Entry = new EntryValueCommonArgs()
                {
                    Completion_Time = TerraStringExtensions.GetISOStringFromDate(this.completion_time),
                    Creation_Height = this.creation_height.ToString(),
                    Initial_Balance = this.initial_balance.ToString(),
                    Shares_Dst = this.shares_dst.ToString()
                }
            };
        }

        public PROTO.RedelegationEntry ToProtoWithType()
        {
            return new PROTO.RedelegationEntry()
            {
                CompletionTime = this.completion_time,
                CreationHeight = (long)this.creation_height,
                InitialBalance = this.initial_balance.ToString(),
                SharesDst = this.shares_dst.ToString()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class EntryAminoArgs
    {
        public EntryValueCommonArgs Redelegation_Entry { get; set; }
        public string Balance { get; set; }
    }

    public class EntryDataArgs
    {
        public string Balance { get; set; }
        public EntryValueCommonArgs Redelegation_Entry { get; set; }
    }

    public class EntryValueCommonArgs
    {
        public string Initial_Balance { get; set; }
        public string Shares_Dst { get; set; }
        public string Creation_Height { get; set; }
        public string Completion_Time { get; set; }
    }
}
