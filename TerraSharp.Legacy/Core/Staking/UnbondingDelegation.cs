using Google.Protobuf.WellKnownTypes;
using System.Linq;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest;
using TerraSharp.Rest.Staking;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;

namespace TerraSharp.Core.Staking
{
    public class UnbondingDelegation
    {
        public readonly string delegator_address;
        public readonly string validator_address;
        public readonly UnbondingDelegationEntry[] entries;

        public UnbondingDelegation(
            string delegator_address,
            string validator_address,
            UnbondingDelegationEntry[] entries)
        {
            this.delegator_address = delegator_address;
            this.validator_address = validator_address;
            this.entries = entries;
        }

        public static UnbondingDelegation FromAmino(UnbondingDelegationAminoArgs data)
        {
            return new UnbondingDelegation(
                data.Delegator_Address,
                data.Validator_Address,
                data.Entries.ToList().ConvertAll(w => UnbondingDelegationEntry.FromAmino(w)).ToArray());
        }

        public static UnbondingDelegation FromData(UnbondingDelegationDataArgs data)
        {
            return new UnbondingDelegation(
                data.Delegator_Address,
                data.Validator_Address,
                data.Entries.ToList().ConvertAll(w => UnbondingDelegationEntry.FromData(w)).ToArray());
        }
        public static UnbondingDelegation FromJSON(UnbondingDelegationDataJSON data)
        {
            return new UnbondingDelegation(
                data.Delegator_Address,
                data.Validator_Address,
                data.Entries.ToList().ConvertAll(w => UnbondingDelegationEntry.FromJSON(w)).ToArray());
        }

        public static UnbondingDelegation FromProto(PROTO.UnbondingDelegation data)
        {
            return new UnbondingDelegation(
                data.DelegatorAddress,
                data.ValidatorAddress,
                data.Entries.ToList().ConvertAll(w => UnbondingDelegationEntry.FromProto(w)).ToArray());
        }
        

        public UnbondingDelegationAminoArgs ToAmino()
        {
            return new UnbondingDelegationAminoArgs()
            {
                Delegator_Address = this.delegator_address,
                Validator_Address = this.validator_address,
                Entries = this.entries.ToList().ConvertAll(w => w.ToAmino()).ToArray()
            };
        }

        public UnbondingDelegationDataArgs ToData()
        {
            return new UnbondingDelegationDataArgs()
            {
                Delegator_Address = this.delegator_address,
                Validator_Address = this.validator_address,
                Entries = this.entries.ToList().ConvertAll(w => w.ToData()).ToArray()
            };
        }

        public PROTO.UnbondingDelegation ToProtoWithType()
        {
            return new PROTO.UnbondingDelegation()
            {
                DelegatorAddress = this.delegator_address,
                Entries = this.entries.ToList().ConvertAll(w => w.ToProtoWithType()),
                ValidatorAddress = this.validator_address
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class UnbondingDelegationAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public UnbondingDelegationEntryAminoArgs[] Entries { get; set; }
    }

    public class UnbondingDelegationValueCommonArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
    }

    public class UnbondingDelegationDataArgs
    {
        public UnbondingDelegationEntryDataArgs[] Entries { get; set; }
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
    }
}
