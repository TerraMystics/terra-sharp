using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Constants;
using TerraSharp.Rest.Staking;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.staking.v1beta1;

namespace TerraSharp.Core.Staking
{
    public class Delegation
    {
        public readonly string delegator_address;
        public readonly string validator_address;
        public readonly decimal shares;
        public readonly Coin balance;

        public Delegation(
            string delegator_address,
            string validator_address,
            decimal shares,
            Coin balance)
        {
            this.delegator_address = delegator_address;
            this.validator_address = validator_address;
            this.shares = shares;
            this.balance = balance;
        }

        public static Delegation FromAmino(DelegationAminoArgs data)
        {
            return new Delegation(
                data.Delegation.Delegator_Address,
                data.Delegation.Validator_Address,
                decimal.Parse(data.Delegation.Shares),
                Coin.FromAmino(data.Balance));
        }

        public static Delegation FromData(DelegationDataArgs data)
        {
            return new Delegation(
                   data.Delegation.Delegator_Address,
                   data.Delegation.Validator_Address,
                   decimal.Parse(data.Delegation.Shares),
                   Coin.FromData(data.Balance));
        }
        public static Delegation FromJSON(StakingDelegationResponse data)
        {
            return new Delegation(
                   data.delegation.Delegator_Address,
                   data.delegation.Validator_Address,
                   decimal.Parse(data.delegation.Shares),
                   Coin.FromJSON(data.balance));
        }

        public static Delegation FromProto(PROTO.DelegationResponse data)
        {
            return new Delegation(
                  data.Delegation.DelegatorAddress,
                  data.Delegation.ValidatorAddress,
                  decimal.Parse(data.Delegation.Shares),
                  null);
        }

        public DelegationAminoArgs ToAmino()
        {
            return new DelegationAminoArgs()
            {
                Delegation = new DelegationValueAminoArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Address = this.validator_address,
                    Shares = this.shares.ToString(),
                },
                Balance = this.balance.ToAmino(),
            };
        }

        public DelegationDataArgs ToData()
        {
            return new DelegationDataArgs()
            {
                Delegation = new DelegationValueDataArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Address = this.validator_address,
                    Shares = this.shares.ToString(),
                },
                Balance = this.balance.ToData(),
            };
        }

        public PROTO.Delegation ToProtoWithType()
        {
            return new PROTO.Delegation()
            {
                DelegatorAddress = this.delegator_address,
                Shares = this.shares.ToString(),
                ValidatorAddress = this.validator_address
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class DelegationAminoArgs
    {
        public DelegationValueAminoArgs Delegation { get; set; }
        public CoinAminoArgs Balance { get; set; }
    }

    public class DelegationValueAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public string Shares { get; set; }
    }
    public class DelegationValueDataArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
        public string Shares { get; set; }
    }

    public class DelegationDataArgs
    {
        public CoinDataArgs Balance { get; set; }
        public DelegationValueDataArgs Delegation { get; set; }
    }
}
