using TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

namespace TerraSharp.Rest.Converters
{
    public static class VoteOptionConverters
    {
        public static VoteOption GetFromString(string val)
        {
            switch (val)
            {
                case "VOTE_OPTION_UNSPECIFIED":
                    return VoteOption.VoteOptionUnspecified;
                case "VOTE_OPTION_YES":
                    return VoteOption.VoteOptionYes;
                case "VOTE_OPTION_ABSTAIN":
                    return VoteOption.VoteOptionAbstain;
                case "VOTE_OPTION_NO":
                    return VoteOption.VoteOptionNo;
                case "VOTE_OPTION_NO_WITH_VETO":
                    return VoteOption.VoteOptionNoWithVeto;
            }

            return VoteOption.VoteOptionUnspecified;
        }
        public static string GetFromEnum(VoteOption val)
        {
            switch (val)
            {
                case VoteOption.VoteOptionUnspecified:
                    return "VOTE_OPTION_UNSPECIFIED";
                case VoteOption.VoteOptionYes:
                    return "VOTE_OPTION_YES";
                case VoteOption.VoteOptionAbstain:
                    return "VOTE_OPTION_ABSTAIN";
                case VoteOption.VoteOptionNo:
                    return "VOTE_OPTION_NO";
                case VoteOption.VoteOptionNoWithVeto:
                    return "VOTE_OPTION_NO_WITH_VETO";
            }

            return "VOTE_OPTION_UNSPECIFIED";
        }
    }


}
