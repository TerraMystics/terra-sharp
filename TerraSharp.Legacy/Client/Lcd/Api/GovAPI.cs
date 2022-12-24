using TerraSharp.Rest.Configuration.Environment;
using TerraSharp.Client.Lcd.Constants;
using TerraSharp.Rest.Util;
using TerraSharp.Core.Gov;
using TerraSharp.Rest.Gov.Proposals;
using TerraSharp.Core;
using TerraSharp.Rest.Extensions;
using TerraSharp.Rest.Tx.Transaction;
using TerraSharp.Core.Constants;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;
using TerraSharp.Rest;
using STATUS = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;
using TerraSharp.Rest.Converters;
using TerraSharp.Core.Extensions;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace TerraSharp.Client.Lcd.Api
{
    public class GovAPI : BaseAPI
    {
        public GovAPI(TerraRestfulService apiRequester) : base(apiRequester)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proposalID"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<FinalTallyResult> GetTally(double proposalID, PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_GOV_PROPOSALS,
                $"/{proposalID}/{CosmosGovConstants.TALLY}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<ProposalsResponseContainerValueJSON>(rootPath);
            if (response.Successful)
            {
                return FinalTallyResult.FromJSON(response.Result.tally);
            }

            throw new ArgumentNullException($"");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<ProposalsDepositParams> GetDepositParams(PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_GOV_PARAMS_DEPOSIT);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<ProposalsParams>(rootPath);
            if (response.Successful)
            {
                return ProposalsDepositParams.FromJSON(response.Result.deposit_params);
            }

            throw new ArgumentNullException($"");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<ProposalsVotesParams> GetVotingParams(PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_GOV_PARAMS_VOTING);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<ProposalsParams>(rootPath);
            if (response.Successful)
            {
                return ProposalsVotesParams.FromJSON(response.Result.voting_params);
            }

            throw new ArgumentNullException($"");
        }

        public async Task<ProposalsTallyParams> GetTallyParams(PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_GOV_PARAMS_TALLYING);
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<ProposalsParams>(rootPath);
            if (response.Successful)
            {
                return ProposalsTallyParams.FromJSON(response.Result.tally_params);
            }

            throw new ArgumentNullException($"");
        }

        public async Task<Proposal[]> GetProposals(
            STATUS.ProposalStatus status = STATUS.ProposalStatus.ProposalStatusUnspecified,
            PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_GOV_PROPOSALS, $"?proposal_status={(int)status}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<ProposalsResponseJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.proposals.ToList().ConvertAll(w => Proposal.FromJSON(w)).ToArray();
            }

            throw new ArgumentNullException($"");
        }
        public async Task<Proposal> GetProposal(double proposalID, PaginationOptions options = null)
        {
            string rootPath = string.Concat(
                TerraClientConfiguration.BlockchainResourcePath,
                CosmosBaseConstants.COSMOS_GOV_PROPOSALS,
                $"/{proposalID}");
            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<ProposalsResponseContainerJSON>(rootPath);
            if (response.Successful)
            {
                return Proposal.FromJSON(response.Result.proposal);
            }

            throw new ArgumentNullException($"");
        }


        private async Task<Tx> GetSubmitTxProposal(double proposalID, PaginationOptions options = null)
        {
            var queryParams = PaginationOptionExtensions.GetProposalsQueryParameters(new string[] {
                $"message.action='{CosmosConstants.COSMOS_GOV_MSG_SUBMIT_PROPOSAL}'",
                $"submit_proposal.proposal_id={proposalID}"
            });

            return await this.SearchProposalCreationTx(queryParams, options);
        }

        public async Task<string> GetProposer(double proposalID, PaginationOptions options = null)
        {
            var response = await this.GetSubmitTxProposal(proposalID, options);
            if (response != null)
            {
                return response.body.messages.Single(w => w.type == CosmosConstants.COSMOS_GOV_MSG_SUBMIT_PROPOSAL).proposer;
            }

            throw new ArgumentNullException("failed to fetch submit_proposer tx");
        }

        public async Task<Coin[]> GetInitialDeposit(double proposalID, PaginationOptions options = null)
        {
            var response = await this.GetSubmitTxProposal(proposalID, options);
            if (response != null)
            {
                return CoinsExtensions.FromJSON(response.body.messages.
                    Single(w => w.type == CosmosConstants.COSMOS_GOV_MSG_SUBMIT_PROPOSAL).initial_deposit).ToArray();
            }

            throw new ArgumentNullException("failed to fetch submit_proposer tx");
        }

        public async Task<Deposit[]> GetDeposits(double proposalID, PaginationOptions options = null)
        {
            var response = await this.GetProposal(proposalID);
            if (response != null)
            {
                if (response.status == PROTO.ProposalStatus.ProposalStatusDepositPeriod ||
                    response.status == PROTO.ProposalStatus.ProposalStatusVotingPeriod)
                {
                    string rootPath = string.Concat(
                 TerraClientConfiguration.BlockchainResourcePath,
                 CosmosBaseConstants.COSMOS_GOV_PROPOSALS, $"/{proposalID}/{CosmosGovConstants.DEPOSITS}");

                    var proposal = await this.apiRequester.GetAsync<ProposalsResponseContainerJSON>(rootPath);
                    if (proposal.Successful)
                    {
                        return proposal.Result.proposal.deposits.ToList().ConvertAll(w => Deposit.FromJSON(w)).ToArray();
                    }

                    throw new ArgumentNullException($"");
                }

                var queryParams = PaginationOptionExtensions.GetProposalsQueryParameters(new string[] {
                    $"message.action=\'{CosmosConstants.COSMOS_GOV_MSG_DEPOSIT}\'",
                    $"proposal_deposit.proposal_id={proposalID}"
                });

                var searchedResponse = await this.SearchProposalCreationTx(queryParams, options);
                if (searchedResponse != null)
                {
                    if (searchedResponse.body != null)
                    {
                        List<Deposit> deposit = new List<Deposit>();
                        foreach (var msg in searchedResponse.body.messages)
                        {
                            if (msg.type == CosmosConstants.COSMOS_GOV_MSG_DEPOSIT)
                            {
                                deposit.Add(Deposit.FromJSON(msg));
                            }
                        }

                        return deposit.ToArray();
                    }
                }
            }

            throw new ArgumentNullException($"failed to fetch submit_proposer tx");
        }
        public async Task<Vote[]> GetVotes(double proposalID, PaginationOptions options = null)
        {
            var response = await this.GetProposal(proposalID);
            if (response != null)
            {
                if (response.status == PROTO.ProposalStatus.ProposalStatusDepositPeriod)
                {
                    string rootPath = string.Concat(
                 TerraClientConfiguration.BlockchainResourcePath,
                 CosmosBaseConstants.COSMOS_GOV_PROPOSALS, $"/{proposalID}/{CosmosGovConstants.VOTES}");

                    var proposal = await this.apiRequester.GetAsync<ProposalsResponseContainerJSON>(rootPath);
                    if (proposal.Successful)
                    {
                        return proposal.Result.proposal.votes.ToList().ConvertAll(w => Vote.FromJSON(w)).ToArray();
                    }

                    throw new ArgumentNullException($"");
                }

                var queryParams = PaginationOptionExtensions.GetProposalsQueryParameters(new string[] {
                    $"message.action='{CosmosConstants.COSMOS_GOV_MSG_VOTE}'",
                    $"proposal_vote.proposal_id={proposalID}"
                });

                var searchedResponse = await this.SearchProposalCreationTx(queryParams, options);
                if (searchedResponse != null)
                {
                    if (searchedResponse.body != null)
                    {
                        List<Vote> votes = new List<Vote>();
                        foreach (var msg in searchedResponse.body.messages)
                        {
                            if (msg.type == CosmosConstants.COSMOS_GOV_MSG_VOTE)
                            {
                                votes.Add(new Vote(proposalID, msg.voter, new WeightedVoteOption[] {
                                    new WeightedVoteOption(VoteOptionConverters.GetFromString( msg.option), 1)
                                }));
                            }
                            if (msg.type == CosmosConstants.COSMOS_GOV_MSG_VOTE_WEIGHTED && msg.proposal_id == proposalID)
                            {
                                votes.Add(new Vote(proposalID, msg.voter,
                                    msg.options.ToList().ConvertAll(w => WeightedVoteOption.FromJSON(w)).ToArray()));
                            }
                        }

                        return votes.ToArray();
                    }
                }
            }

            throw new ArgumentNullException($"failed to fetch vote_proposer tx");
        }

        public async Task<Tx> SearchProposalCreationTx(string queryParams, PaginationOptions options = null)
        {
            string rootPath = string.Concat(
             TerraClientConfiguration.BlockchainResourcePath,
             CosmosBaseConstants.COSMOS_TX_TXS,
             $"?{queryParams}");

            if (options != null)
            {
                rootPath += PaginationOptionExtensions.GetPaginationRules(options);
            }

            var response = await this.apiRequester.GetAsync<TxContainerJSON>(rootPath);
            if (response.Successful)
            {
                return response.Result.txs.ToList().ConvertAll(w => Tx.FromJSON(w)).ToArray()[0];
            }

            throw new ArgumentNullException($"");
        }
    }
}
