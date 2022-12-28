using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;

namespace Terra.Microsoft.Rest.Converters
{
    public class BondStatusConverter
    {
        public static BondStatus GetFromString(string val)
        {
            switch (val)
            {
                case "BOND_STATUS_UNSPECIFIED":
                    return BondStatus.BondStatusUnspecified;
                case "BOND_STATUS_UNBONDED":
                    return BondStatus.BondStatusUnbonded;
                case "BOND_STATUS_UNBONDING":
                    return BondStatus.BondStatusUnbonding;
                case "BOND_STATUS_BONDED":
                    return BondStatus.BondStatusBonded;
            }

            return BondStatus.BondStatusUnspecified;
        }
        public static string GetFromEnum(BondStatus val)
        {
            switch (val)
            {
                case BondStatus.BondStatusUnspecified:
                    return "BOND_STATUS_UNSPECIFIED";
                case BondStatus.BondStatusUnbonded:
                    return "BOND_STATUS_UNBONDED";
                case BondStatus.BondStatusUnbonding:
                    return "BOND_STATUS_UNBONDING";
                case BondStatus.BondStatusBonded:
                    return "BOND_STATUS_BONDED";
            }

            return "BOND_STATUS_UNSPECIFIED";
        }
    }
}