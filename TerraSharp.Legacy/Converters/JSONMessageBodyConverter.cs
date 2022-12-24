using System;
using TerraSharp.Core.Authz.Msgs;
using TerraSharp.Core.Bank.Msgs;
using TerraSharp.Core.Crisis;
using TerraSharp.Core.Distrobution.Msgs;
using TerraSharp.Core.Feegrant.Msgs;
using TerraSharp.Core.Gov.Msgs;
using TerraSharp.Core.IBC.Msgs.Channel;
using TerraSharp.Core.IBC.Msgs.Client;
using TerraSharp.Core.IBC.Msgs.Connection;
using TerraSharp.Core.IBCTransfer.Msgs;
using TerraSharp.Core.Market.Msgs;
using TerraSharp.Core.Oracle.Msgs;
using TerraSharp.Core.Slashing.Msgs;
using TerraSharp.Core.Staking.Msgs;
using TerraSharp.Core.Wasm.Msgs;
using TerraSharp.Rest.Tx.Transaction.Upload;

namespace TerraSharp.Converters
{
    /// <summary>
    /// Json Message Converter used for Generating Protobufs for the associated message
    /// </summary>
    public class JSONMessageBodyConverter
    {
        public static TxUploadMessageData GetJsonFromBody(object data)
        {
            if (data is MsgExecAuthorized)
            {
                var c = (MsgExecAuthorized)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgGrantAuthorization)
            {
                var c = (MsgGrantAuthorization)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgRevokeAuthorization)
            {
                var c = (MsgRevokeAuthorization)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgMultiSend)
            {
                var c = (MsgMultiSend)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgSend)
            {
                var c = (MsgSend)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgVerifyInvariant)
            {
                var c = (MsgVerifyInvariant)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgFundCommunityPool)
            {
                var c = (MsgFundCommunityPool)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgSetWithdrawAddress)
            {
                var c = (MsgSetWithdrawAddress)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgWithdrawDelegatorReward)
            {
                var c = (MsgWithdrawDelegatorReward)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgWithdrawValidatorCommission)
            {
                var c = (MsgWithdrawValidatorCommission)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgGrantAllowance)
            {
                var c = (MsgGrantAllowance)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgRevokeAllowance)
            {
                var c = (MsgRevokeAllowance)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgDeposit)
            {
                var c = (MsgDeposit)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgVote)
            {
                var c = (MsgVote)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgVoteWeighted)
            {
                var c = (MsgVoteWeighted)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }

            if (data is MsgTransfer)
            {
                var c = (MsgTransfer)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgAcknowledgement)
            {
                var c = (MsgAcknowledgement)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgChannelCloseConfirm)
            {
                var c = (MsgChannelCloseConfirm)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgChannelCloseInit)
            {
                var c = (MsgChannelCloseInit)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgChannelOpenAck)
            {
                var c = (MsgChannelOpenAck)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgChannelOpenConfirm)
            {
                var c = (MsgChannelOpenConfirm)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgChannelOpenInit)
            {
                var c = (MsgChannelOpenInit)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgChannelOpenTry)
            {
                var c = (MsgChannelOpenTry)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgRecvPacket)
            {
                var c = (MsgRecvPacket)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgTimeout)
            {
                var c = (MsgTimeout)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgTimeoutOnClose)
            {
                var c = (MsgTimeoutOnClose)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgCreateClient)
            {
                var c = (MsgCreateClient)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgSubmitMisbehavior)
            {
                var c = (MsgSubmitMisbehavior)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgUpdateClient)
            {
                var c = (MsgUpdateClient)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgUpgradeClient)
            {
                var c = (MsgUpgradeClient)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }


            if (data is MsgConnectionOpenAck)
            {
                var c = (MsgConnectionOpenAck)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }

            if (data is MsgConnectionOpenConfirm)
            {
                var c = (MsgConnectionOpenConfirm)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgConnectionOpenInit)
            {
                var c = (MsgConnectionOpenInit)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgConnectionOpenTry)
            {
                var c = (MsgConnectionOpenTry)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }


            if (data is MsgTransfer)
            {
                var c = (MsgTransfer)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgSwap)
            {
                var c = (MsgSwap)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgSwapSend)
            {
                var c = (MsgSwapSend)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }



            if (data is MsgAggregateExchangeRatePrevote)
            {
                var c = (MsgAggregateExchangeRatePrevote)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgAggregateExchangeRateVote)
            {
                var c = (MsgAggregateExchangeRateVote)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgDelegateFeedConsent)
            {
                var c = (MsgDelegateFeedConsent)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgUnjail)
            {
                var c = (MsgUnjail)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }


            if (data is MsgBeginRedelegate)
            {
                var c = (MsgBeginRedelegate)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgCreateValidator)
            {
                var c = (MsgCreateValidator)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgDelegate)
            {
                var c = (MsgDelegate)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgEditValidator)
            {
                var c = (MsgEditValidator)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgUndelegate)
            {
                var c = (MsgUndelegate)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }



            if (data is MsgClearContractAdmin)
            {
                var c = (MsgClearContractAdmin)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgExecuteContract)
            {
                var c = (MsgExecuteContract)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgInstantiateContract)
            {
                var c = (MsgInstantiateContract)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgMigrateCode)
            {
                var c = (MsgMigrateCode)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgMigrateContract)
            {
                var c = (MsgMigrateContract)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };

            }
            if (data is MsgStoreCode)
            {
                var c = (MsgStoreCode)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }
            if (data is MsgUpdateContractAdmin)
            {
                var c = (MsgUpdateContractAdmin)data;
                return new TxUploadMessageData()
                {
                    type_url = c.ToData().Type,
                    value = c.ToProto()
                };
            }

            throw new ArgumentNullException("Could not determine the type of JSON");
        }
    }
}