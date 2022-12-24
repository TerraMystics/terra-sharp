using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Extensions;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TerraSharp.Core.Gov.Msgs
{
    public class MsgDeposit : SignerData
    {
        public readonly double proposal_id;
        public readonly string depositor;
        public readonly List<Coin> amount;

        public MsgDeposit(double proposal_id, string depositor, List<Coin> amount)
        {
            this.proposal_id = proposal_id;
            this.depositor = depositor;
            this.amount = amount;
        }

        public static MsgDeposit FromAmino(MsgDepositAminoArgs data)
        {
            return new MsgDeposit(double.Parse(data.Value.Proposal_id), data.Value.Depositor, CoinsExtensions.FromAmino(data.Value.Amount).ToList());
        }

        public static MsgDeposit FromData(MsgDepositDataArgs data)
        {
            return new MsgDeposit(double.Parse(data.Proposal_id), data.Depositor, CoinsExtensions.FromData(data.Amount).ToList());
        }

        public static MsgDeposit FromProto(PROTO.MsgDeposit data)
        {
            return new MsgDeposit(data.ProposalId, data.Depositor, CoinsExtensions.FromProto(data.Amounts).ToList());
        }

        public MsgDepositAminoArgs ToAmino()
        {
            return new MsgDepositAminoArgs()
            {
                Value = new MsgDepositValueAminoArgs()
                {
                    Depositor = this.depositor,
                    Proposal_id = this.proposal_id.ToString(),
                    Amount = CoinsExtensions.ToAmino(this.amount).ToArray(),
                }
            };
        }

        public MsgDepositDataArgs ToData()
        {
            return new MsgDepositDataArgs()
            {
                Depositor = this.depositor,
                Proposal_id = this.proposal_id.ToString(),
                Amount = CoinsExtensions.ToData(this.amount).ToArray(),
            };
        }

        public PROTO.MsgDeposit ToProtoWithType()
        {
            return new PROTO.MsgDeposit()
            {
                Amounts = CoinsExtensions.ToProto(this.amount).ToList(),
                Depositor = this.depositor,
                ProposalId = (ulong)this.proposal_id
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
                TypeUrl = CosmosConstants.COSMOS_GOV_MSG_DEPOSIT,
                Value = this.ToProto()
            };
        }

        public static MsgDeposit UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgDeposit>(msgAny.Value));
        }
    }

    public class MsgDepositAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgDepositValueAminoArgs Value { get; set; }
        public MsgDepositAminoArgs()
        {
            this.Type = GovConstants.MSG_DEPOSIT;
        }
    }

    public class MsgDepositValueAminoArgs
    {
        public string Proposal_id { get; set; }
        public string Depositor { get; set; }
        public CoinAminoArgs[] Amount { get; set; }
    }

    public class MsgDepositDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Proposal_id { get; set; }
        public string Depositor { get; set; }
        public CoinDataArgs[] Amount { get; set; }

        public MsgDepositDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_GOV_MSG_DEPOSIT;
        }
    }
}
