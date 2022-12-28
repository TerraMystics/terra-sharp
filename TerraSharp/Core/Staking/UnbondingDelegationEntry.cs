using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;
using System;

namespace Terra.Microsoft.Client.Core.Staking
{
    public class UnbondingDelegationEntry
    {
        public readonly int initial_balance;
        public readonly int balance;
        public readonly double creation_height;
        public readonly DateTime completion_time;

        public UnbondingDelegationEntry(
            int initial_balance,
            int balance,
            double creation_height,
            DateTime completion_time)
        {
            this.initial_balance = initial_balance;
            this.balance = balance;
            this.creation_height = creation_height;
            this.completion_time = completion_time;
        }

        public static UnbondingDelegationEntry FromAmino(UnbondingDelegationEntryAminoArgs data)
        {
            return new UnbondingDelegationEntry(
                int.Parse(data.Initial_Balance),
                int.Parse(data.Balance),
                double.Parse(data.Creation_Height),
                TerraStringExtensions.GetISODateTimeFromString(data.Completion_Time));
        }

        public static UnbondingDelegationEntry FromData(UnbondingDelegationEntryDataArgs data)
        {
            return new UnbondingDelegationEntry(
            int.Parse(data.Initial_Balance),
            int.Parse(data.Balance),
            double.Parse(data.Creation_Height),
            TerraStringExtensions.GetISODateTimeFromString(data.Completion_Time));
        }

        public static UnbondingDelegationEntry FromJSON(UnbondingDelegationEntryValueCommonArgsJSON data)
        {
            return new UnbondingDelegationEntry(
            int.Parse(data.Initial_Balance),
            int.Parse(data.Balance),
            double.Parse(data.Creation_Height),
            data.Completion_Time);
        }
        public static UnbondingDelegationEntry FromProto(PROTO.UnbondingDelegationEntry data)
        {
            return new UnbondingDelegationEntry(
                 int.Parse(data.InitialBalance),
                 int.Parse(data.Balance),
                 data.CreationHeight,
                 data.CompletionTime.Value);
        }


        public UnbondingDelegationEntryAminoArgs ToAmino()
        {
            return new UnbondingDelegationEntryAminoArgs()
            {
                Completion_Time = TerraStringExtensions.GetISOStringFromDate(this.completion_time),
                Creation_Height = this.creation_height.ToString(),
                Initial_Balance = this.initial_balance.ToString(),
                Balance = this.balance.ToString()
            };
        }

        public UnbondingDelegationEntryDataArgs ToData()
        {
            return new UnbondingDelegationEntryDataArgs()
            {
                Completion_Time = TerraStringExtensions.GetISOStringFromDate(this.completion_time),
                Creation_Height = this.creation_height.ToString(),
                Initial_Balance = this.initial_balance.ToString(),
                Balance = this.balance.ToString()
            };
        }

        public PROTO.UnbondingDelegationEntry ToProtoWithType()
        {
            return new PROTO.UnbondingDelegationEntry()
            {
                Balance = this.balance.ToString(),
                CompletionTime = this.completion_time,
                CreationHeight = (long)this.creation_height,
                InitialBalance = this.initial_balance.ToString()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class UnbondingDelegationEntryAminoArgs : UnbondingDelegationEntryValueCommonArgs
    {
    }

    public class UnbondingDelegationEntryDataArgs : UnbondingDelegationEntryValueCommonArgs
    {
    }

    public class UnbondingDelegationEntryValueCommonArgs
    {
        public string Initial_Balance { get; set; }
        public string Balance { get; set; }
        public string Creation_Height { get; set; }
        public string Completion_Time { get; set; }
    }
}
