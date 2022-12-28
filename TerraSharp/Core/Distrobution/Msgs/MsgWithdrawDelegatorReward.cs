using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.distribution.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Terra.Microsoft.Client.Key.Data.SimplePublicKey;
using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Rest.Tx.Transaction;

namespace Terra.Microsoft.Client.Core.Distrobution.Msgs
{
    public class MsgWithdrawDelegatorReward : SignerData
    {
        public readonly string delegator_address;
        public readonly string validator_address;

        public MsgWithdrawDelegatorReward(string delegator_address, string validator_address)
        {
            this.delegator_address = delegator_address;
            this.validator_address = validator_address;
        }

        public static MsgWithdrawDelegatorReward FromAmino(MsgWithdrawDelegatorRewardAminoArgs data)
        {
            return new MsgWithdrawDelegatorReward(data.Value.Delegator_Address, data.Value.Validator_Address);
        }

        public static MsgWithdrawDelegatorReward FromData(MsgWithdrawDelegatorRewardDataArgs data)
        {
            return new MsgWithdrawDelegatorReward(data.Delegator_Address, data.Validator_Address);
        }

        public static MsgWithdrawDelegatorReward FromProto(PROTO.MsgWithdrawDelegatorReward data)
        {
            return new MsgWithdrawDelegatorReward(data.DelegatorAddress, data.ValidatorAddress);
        }

        public MsgWithdrawDelegatorRewardAminoArgs ToAmino()
        {
            return new MsgWithdrawDelegatorRewardAminoArgs()
            {
                Value = new MsgWithdrawDelegatorRewardValueAminoArgs()
                {
                    Delegator_Address = this.delegator_address,
                    Validator_Address = this.validator_address,
                }
            };
        }

        public MsgWithdrawDelegatorRewardDataArgs ToData()
        {
            return new MsgWithdrawDelegatorRewardDataArgs()
            {
                Delegator_Address = this.delegator_address,
                Validator_Address = this.validator_address,
            };
        }

        public PROTO.MsgWithdrawDelegatorReward ToProtoWithType()
        {
            return new PROTO.MsgWithdrawDelegatorReward()
            {
                DelegatorAddress = this.delegator_address,
                ValidatorAddress = this.validator_address
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_DISTRIBUTION_MSG_WITHDRAW_DELEGATOR_REWARDS,
                Value = this.ToProto()
            };
        }

        public static MsgWithdrawDelegatorReward UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgWithdrawDelegatorReward>(msgAny.Value));

        }
    }

    public class MsgWithdrawDelegatorRewardAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgWithdrawDelegatorRewardValueAminoArgs Value { get; set; }
        public MsgWithdrawDelegatorRewardAminoArgs()
        {
            this.Type = DistributionConstants.DISTRIBUTION_MSG_WITHDRAW_DELEGATIONREWARD;
        }
    }

    public class MsgWithdrawDelegatorRewardValueAminoArgs
    {
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }
    }

    public class MsgWithdrawDelegatorRewardDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Delegator_Address { get; set; }
        public string Validator_Address { get; set; }

        public MsgWithdrawDelegatorRewardDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_DISTRIBUTION_MSG_WITHDRAW_DELEGATOR_REWARDS;
        }
    }
}
