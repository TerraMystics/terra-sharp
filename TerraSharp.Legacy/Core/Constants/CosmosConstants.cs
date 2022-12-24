namespace TerraSharp.Core.Constants
{
    public class CosmosConstants
    {
        public const string COSMOS_AUTH = "/cosmos.auth.v1beta1.BaseAccount";

        public const string COSMOS_FEEGRANT_ALLOWED_MSG_ALLOWANCE = "/cosmos.feegrant.v1beta1.AllowedMsgAllowance";
        public const string COSMOS_FEEGRANT_BASIC_ALLOWANCE = "/cosmos.feegrant.v1beta1.BasicAllowance";
        public const string COSMOS_FEEGRANT_PERIODIC_ALLOWANCE = "/cosmos.feegrant.v1beta1.PeriodicAllowance";
        public const string COSMOS_FEEGRANT_MSG_GRANT_ALLOWANCE = "/cosmos.feegrant.v1beta1.MsgGrantAllowance";
        public const string COSMOS_FEEGRANT_MSG_REVOKE_ALLOWANCE = "/cosmos.feegrant.v1beta1.MsgRevokeAllowance";

        public const string COSMOS_SEND_AUTHORIZATION = "/cosmos.bank.v1beta1.SendAuthorization";
        public const string COSMOS_STAKE_AUTHORIZATION = "/cosmos.staking.v1beta1.StakeAuthorization";
        public const string COSMOS_GENERIC_AUTHORIZATION = "/cosmos.authz.v1beta1.GenericAuthorization";

        public const string COSMOS_MSG_EXEC = "/cosmos.authz.v1beta1.MsgExec";
        public const string COSMOS_MSG_REVOKE = "/cosmos.authz.v1beta1.MsgRevoke";
        public const string COSMOS_MSG_GRANT = "/cosmos.authz.v1beta1.MsgGrant";

        public const string COSMOS_CRISIS_MSG_VERIFY_INVARIANT = "/cosmos.crisis.v1beta1.MsgVerifyInvariant";

        public const string COSMOS_DISTRIBUTION_MSG_FUNDCOMMUNITYPOOL = "/cosmos.distribution.v1beta1.MsgFundCommunityPool";
        public const string COSMOS_DISTRIBUTION_MSG_SETWITHDRAWADDRESS = "/cosmos.distribution.v1beta1.MsgSetWithdrawAddress";
        public const string COSMOS_DISTRIBUTION_MSG_WITHDRAW_DELEGATOR_REWARDS = "/cosmos.distribution.v1beta1.MsgWithdrawDelegatorReward";
        public const string COSMOS_DISTRIBUTION_MSG_WITHDRAW_VALIDATOR_COMMISSION = "/cosmos.distribution.v1beta1.MsgWithdrawValidatorCommission";
        public const string COSMOS_DISTRIBUTION_MSG_COMMUNITY_POOLSPENDPROPOSAL = "/cosmos.distribution.v1beta1.CommunityPoolSpendProposal";

        public const string COSMOS_GOV_MSG_DEPOSIT = "/cosmos.gov.v1beta1.MsgDeposit";
        public const string COSMOS_GOV_MSG_SUBMIT_PROPOSAL = "/cosmos.gov.v1beta1.MsgSubmitProposal";
        public const string COSMOS_GOV_MSG_VOTE = "/cosmos.gov.v1beta1.MsgVote";
        public const string COSMOS_GOV_MSG_VOTE_WEIGHTED = "/cosmos.gov.v1beta1.MsgVoteWeighted";


        public const string COSMOS_CANCEL_SOFTWARE_UPGRADE_PROPOSAL = "/cosmos.upgrade.v1beta1.CancelSoftwareUpgradeProposal";
        public const string COSMOS_TEXT_PROPOSAL_SOFTWARE_UPGRADE_PROPOSAL = "/cosmos.gov.v1beta1.TextProposal";
        public const string COSMOS_PARAMETER_CHANGE_PROPOSAL_SOFTWARE_UPGRADE_PROPOSAL = "/cosmos.params.v1beta1.ParameterChangeProposal";
        public const string COSMOS_SOFTWARE_UPGRADE_PROPOSAL = "/cosmos.upgrade.v1beta1.SoftwareUpgradeProposal";
        public const string COSMOS_ClientUpdate_IBC_SOFTWARE_UPGRADE_PROPOSAL = "/ibc.core.client.v1.ClientUpdateProposal";

        public const string COSMOS_BANK_MSG_MULTISEND = "/cosmos.bank.v1beta1.MsgMultiSend";
        public const string COSMOS_BANK_MSG_SEND = "/cosmos.bank.v1beta1.MsgSend";


        public const string COSMOS_IBC_CHANNEL_CLOSE_CONFIRM = "/ibc.core.channel.v1.MsgChannelCloseConfirm";
        public const string COSMOS_IBC_CHANNEL_CLOSE_INIT = "/ibc.core.channel.v1.MsgChannelCloseInit";
        public const string COSMOS_IBC_CHANNEL_CLOSE_OPEN_ACK = "/ibc.core.channel.v1.MsgChannelOpenAck";
        public const string COSMOS_IBC_CHANNEL_OPEN_CONFIRM = "/ibc.core.channel.v1.MsgChannelOpenConfirm";
        public const string COSMOS_IBC_CHANNEL_OPEN_INIT = "/ibc.core.channel.v1.MsgChannelOpenInit";
        public const string COSMOS_IBC_CHANNEL_OPEN_TRY = "/ibc.core.channel.v1.MsgChannelOpenTry";
        public const string COSMOS_IBC_CHANNEL_MSG_ACKNOWLEDGMENT = "/ibc.core.channel.v1.MsgAcknowledgement";
        public const string COSMOS_IBC_CHANNEL_MSG_RECVPACKET = "/ibc.core.channel.v1.MsgRecvPacket";
        public const string COSMOS_IBC_CHANNEL_MSG_TIMEOUT = "/ibc.core.channel.v1.MsgTimeout";
        public const string COSMOS_IBC_CHANNEL_MSG_TIMEOUT_ON_CLOSE = "/ibc.core.channel.v1.MsgTimeoutOnClose";


        public const string COSMOS_IBC_CHANNEL_MSG_CLIENT_CREATE = "/ibc.core.client.v1.MsgCreateClient";
        public const string COSMOS_IBC_CHANNEL_MSG_SUBMIT_MISBEHAVIOUR = "/ibc.core.client.v1.MsgSubmitMisbehaviour";
        public const string COSMOS_IBC_CHANNEL_MSG_UPDATE_CLIENT = "/ibc.core.client.v1.MsgUpdateClient";
        public const string COSMOS_IBC_CHANNEL_MSG_UPGRADE_CLIENT = "/ibc.core.client.v1.MsgUpgradeClient";

        public const string COSMOS_IBC_CONNECTION_MSG_OPEN_ACK = "/ibc.core.connection.v1.MsgConnectionOpenAck";
        public const string COSMOS_IBC_CONNECTION_MSG_OPEN_CONFIRM = "/ibc.core.connection.v1.MsgConnectionOpenConfirm";
        public const string COSMOS_IBC_CONNECTION_MSG_OPEN_INIT = "/ibc.core.connection.v1.MsgConnectionOpenInit";
        public const string COSMOS_IBC_CONNECTION_MSG_OPEN_TRY = "/ibc.core.connection.v1.MsgConnectionOpenTry";

        public const string COSMOS_IBCTRANSFER_MSG = "/ibc.applications.transfer.v1.MsgTransfer";

        public const string COSMOS_SLASHING_MSG_UNJAIL = "/cosmos.slashing.v1beta1.MsgUnjail";


        public const string COSMOS_STAKING_MSG_BEGIN_REDELEGATE = "/cosmos.staking.v1beta1.MsgBeginRedelegate";
        public const string COSMOS_STAKING_MSG_CREATE_VALIDATOR = "/cosmos.staking.v1beta1.MsgCreateValidator";
        public const string COSMOS_STAKING_MSG_DELEGATE = "/cosmos.staking.v1beta1.MsgDelegate";
        public const string COSMOS_STAKING_MSG_EDIT_VALIDATOR = "/cosmos.staking.v1beta1.MsgEditValidator";
        public const string COSMOS_STAKING_MSG_UNDELEGATE = "/cosmos.staking.v1beta1.MsgUndelegate";
    }
}
