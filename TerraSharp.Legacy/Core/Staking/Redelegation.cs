using Google.Protobuf.WellKnownTypes;
using System.Linq;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Constants;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;

namespace TerraSharp.Core.Staking
{
    public class Redelegation
    {
        public readonly string delegator_address;
        public readonly string validator_src_address;
        public readonly string validator_dst_address;
        public readonly Entry[] entries;

        public Redelegation(
            string delegator_address,
            string validator_src_address,
            string validator_dst_address,
            Entry[] entries)
        {
            this.delegator_address = delegator_address;
            this.validator_src_address = validator_src_address;
            this.validator_dst_address = validator_dst_address;
            this.entries = entries;
        }

        public static Redelegation FromAmino(RedelegationAminoArgs data)
        {
            return new Redelegation(
                data.Redelegation.Delegator_Address,
                data.Redelegation.Validator_Src_Address,
                data.Redelegation.Validator_Dst_Address,
                data.Entries.ToList().ConvertAll(w => Entry.FromAmino(w)).ToArray());
        }

        public static Redelegation FromData(RedelegationDataArgs data)
        {
            return new Redelegation(
                data.Redelegation.Delegator_Address,
                data.Redelegation.Validator_Src_Address,
                data.Redelegation.Validator_Dst_Address,
                data.Entries.ToList().ConvertAll(w => Entry.FromData(w)).ToArray());
        }

        public static Redelegation FromProto(PROTO.RedelegationResponse data)
        {
            return new Redelegation(
                data.Redelegation.DelegatorAddress,
                data.Redelegation.ValidatorSrcAddress,
                data.Redelegation.ValidatorDstAddress,
                data.Entries.ToList().ConvertAll(w => Entry.FromProto(w)).ToArray());
        }

        public RedelegationAminoArgs ToAmino()
        {
            return new RedelegationAminoArgs()
            {
                Redelegation = new RedelegationValueCommonArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Dst_Address = this.validator_dst_address,
                    Validator_Src_Address = this.validator_src_address
                },
                Entries = this.entries.ToList().ConvertAll(w => w.ToAmino()).ToArray()
            };
        }

        public RedelegationDataArgs ToData()
        {
            return new RedelegationDataArgs()
            {
                Redelegation = new RedelegationValueCommonArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Dst_Address = this.validator_dst_address,
                    Validator_Src_Address = this.validator_src_address
                },
                Entries = this.entries.ToList().ConvertAll(w => w.ToData()).ToArray()
            };
        }

        public PROTO.Redelegation ToProtoWithType()
        {
            return new PROTO.Redelegation()
            {
                DelegatorAddress = this.delegator_address,
                Entries = this.entries.ToList().ConvertAll(w => w.ToProtoWithType()),
                ValidatorDstAddress = this.validator_dst_address,
                ValidatorSrcAddress = this.validator_src_address,
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class RedelegationAminoArgs
    {
        public RedelegationValueCommonArgs Redelegation { get; set; }
        public EntryAminoArgs[] Entries { get; set; }
    }

    public class RedelegationValueCommonArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Src_Address { get; set; }
        public string Validator_Dst_Address { get; set; }
    }

    public class RedelegationDataArgs
    {
        public EntryDataArgs[] Entries { get; set; }
        public RedelegationValueCommonArgs Redelegation { get; set; }
    }
}
