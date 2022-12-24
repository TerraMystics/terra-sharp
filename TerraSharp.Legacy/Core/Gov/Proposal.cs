using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.StringExt;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Distrobution.Proposals;
using TerraSharp.Core.Extensions;
using TerraSharp.Core.Gov.Proposals;
using TerraSharp.Core.IBC.Proposals;
using TerraSharp.Core.Params.Proposals;
using TerraSharp.Core.Upgrade.Proposals;
using TerraSharp.Rest.Converters;
using TerraSharp.Rest.Gov.Proposals;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TerraSharp.Core.Gov
{
    public class Proposal
    {
        public readonly double id;
        public readonly PROTO.ProposalStatus status;
        public readonly FinalTallyResult final_tally_result;
        public readonly DateTime submit_time;
        public readonly DateTime deposit_end_time;
        public readonly List<Coin> total_deposit;
        public readonly DateTime voting_start_time;
        public readonly DateTime voting_end_time;
        public readonly ProposalContent content;

        public Proposal(
            double id,
            PROTO.ProposalStatus status,
            FinalTallyResult final_tally_result,
            DateTime submit_time,
            DateTime deposit_end_time,
            List<Coin> total_deposit,
            DateTime voting_start_time,
            DateTime voting_end_time,
            ProposalContent content)
        {
            this.id = id;
            this.status = status;
            this.final_tally_result = final_tally_result;
            this.submit_time = submit_time;
            this.deposit_end_time = deposit_end_time;
            this.total_deposit = total_deposit;
            this.voting_start_time = voting_start_time;
            this.voting_end_time = voting_end_time;
            this.content = content;
        }

        public static object FromAmino(object data)
        {
            string typeVersion = data.GetType().GetProperty("Type").GetValue(data, null) as string;
            switch (typeVersion)
            {
                case ProposalConstants.TEXT_SOFTWARE:
                    return TextProposal.FromAmino(data as TextProposalAminoArgs);
                case ProposalConstants.COMMUNITY_POOL_SPENDPOOL_PROPOSAL:
                    return CommunityPoolSpendProposal.FromAmino(data as CommunityPoolSpendProposalAminoArgs);
                case ProposalConstants.PARAMETER_CHANGE_SOFTWARE_UPGRADE_PROPOSAL:
                    return ParameterChangeProposal.FromAmino(data as ParameterChangeProposalAminoArgs);
                case ProposalConstants.SOFTWARE_UPGRADE_PROPOSAL:
                    return SoftwareUpgradeProposal.FromAmino(data as SoftwareUpgradeProposalAminoArgs);
                case ProposalConstants.CANCEL_SOFTWARE_UPGRADE_PROPOSAL:
                    return CancelSoftwareUpgradeProposal.FromAmino(data as CancelSoftwareUpgradeProposalAminoArgs);
                case ProposalConstants.IBC_CLIENTUPDATE_PROPOSAL:
                    return ClientUpdateProposal.FromAmino(data as ClientUpdateProposalAminoArgs);
            }

            return null;
        }

        public static object FromData(object data)
        {
            string typeVersion = data.GetType().GetProperty("Type").GetValue(data, null) as string;
            switch (typeVersion)
            {
                case ProposalConstants.TEXT_SOFTWARE:
                    return TextProposal.FromData(data as TextProposalDataArgs);
                case ProposalConstants.COMMUNITY_POOL_SPENDPOOL_PROPOSAL:
                    return CommunityPoolSpendProposal.FromData(data as CommunityPoolSpendProposalDataArgs);
                case ProposalConstants.PARAMETER_CHANGE_SOFTWARE_UPGRADE_PROPOSAL:
                    return ParameterChangeProposal.FromData(data as ParameterChangeProposalDataArgs);
                case ProposalConstants.SOFTWARE_UPGRADE_PROPOSAL:
                    return SoftwareUpgradeProposal.FromData(data as SoftwareUpgradeProposalDataArgs);
                case ProposalConstants.CANCEL_SOFTWARE_UPGRADE_PROPOSAL:
                    return CancelSoftwareUpgradeProposal.FromData(data as CancelSoftwareUpgradeProposalDataArgs);
                case ProposalConstants.IBC_CLIENTUPDATE_PROPOSAL:
                    return ClientUpdateProposal.FromData(data as ClientUpdateProposalDataArgs);
            }

            return null;
        }

        public static Proposal FromJSON(ProposalsResponseContainerValueJSON data)
        {
            return new Proposal(
                double.Parse(data.proposal_id),
                ProposalStatusConverters.GetFromString(data.status),
                FinalTallyResult.FromJSON(data.final_tally_result),
                data.submit_time,
                data.deposit_end_time,
                CoinsExtensions.FromJSON(data.total_deposit).ToList(),
                data.voting_start_time,
                data.voting_end_time,
                data.content);
        }


        public static object FromProto(Any data)
        {
            string typeVersion = data.GetType().GetProperty("TypeUrl").GetValue(data, null) as string;
            switch (typeVersion)
            {
                case ProposalConstants.TEXT_SOFTWARE:
                    return TextProposal.UnPackAny(data);
                case ProposalConstants.COMMUNITY_POOL_SPENDPOOL_PROPOSAL:
                    return CommunityPoolSpendProposal.UnPackAny(data);
                case ProposalConstants.PARAMETER_CHANGE_SOFTWARE_UPGRADE_PROPOSAL:
                    return ParameterChangeProposal.UnPackAny(data);
                case ProposalConstants.SOFTWARE_UPGRADE_PROPOSAL:
                    return SoftwareUpgradeProposal.UnPackAny(data);
                case ProposalConstants.CANCEL_SOFTWARE_UPGRADE_PROPOSAL:
                    return CancelSoftwareUpgradeProposal.UnPackAny(data);
                case ProposalConstants.IBC_CLIENTUPDATE_PROPOSAL:
                    return ClientUpdateProposal.UnPackAny(data);
            }

            throw new Exception($"Proposal content ${typeVersion} not recognized");
        }

        public ProposalAminoArgs ToAmino()
        {
            return new ProposalAminoArgs()
            {
                Content = this.content,
                Deposit_End_Time = this.deposit_end_time.GetISOStringFromDate(),
                Final_Tally_Result = this.final_tally_result,
                Status = this.status,
                Submit_Time = this.submit_time.GetISOStringFromDate(),
                Voting_End_Time = this.voting_end_time.GetISOStringFromDate(),
                Voting_Start_Time = this.voting_start_time.GetISOStringFromDate(),
                Total_Deposit = this.total_deposit,
                Id = this.id
            };
        }

        public ProposalDataArgs ToData()
        {
            return new ProposalDataArgs()
            {
                Content = this.content,
                Deposit_End_Time = this.deposit_end_time.GetISOStringFromDate(),
                Final_Tally_Result = this.final_tally_result,
                Status = this.status,
                Submit_Time = this.submit_time.GetISOStringFromDate(),
                Voting_End_Time = this.voting_end_time.GetISOStringFromDate(),
                Voting_Start_Time = this.voting_start_time.GetISOStringFromDate(),
                Total_Deposit = this.total_deposit,
                Id = this.id
            };
        }

        public ProposalAminoArgs ToProto()
        {
            throw new NotImplementedException("");
        }
    }

    public class FinalTallyResult
    {
        public long Yes { get; set; }
        public long Abstain { get; set; }
        public long No { get; set; }
        public long No_With_Veto { get; set; }

        public static FinalTallyResult FromJSON(ProposalsFinallTallyResults data)
        {
            return new FinalTallyResult()
            {
                Yes = long.Parse(data.yes),
                Abstain = long.Parse(data.abstain),
                No = long.Parse(data.no),
                No_With_Veto = long.Parse(data.no_with_veto)
            };
        }
    }

    public class ProposalAminoArgs : CommonProposalArgs
    {
    }

    public class ProposalDataArgs : CommonProposalArgs
    {

    }

    public class CommonProposalArgs
    {
        public ProposalContent Content { get; set; }
        public double Id { get; set; }
        public PROTO.ProposalStatus Status { get; set; }
        public FinalTallyResult Final_Tally_Result { get; set; }
        public string Submit_Time { get; set; }
        public string Deposit_End_Time { get; set; }
        public List<Coin> Total_Deposit { get; set; }
        public string Voting_Start_Time { get; set; }
        public string Voting_End_Time { get; set; }
    }
}
