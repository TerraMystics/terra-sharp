using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Constants;
using TerraSharp.Core.Extensions;
using TerraSharp.Rest.Gov.Proposals;
using TerraSharp.Rest.Tx.Transaction;
using DEP_COMB = TerraProto.CSharp.third_party.proto.cosmos.gov.v1beta1;

using System.Linq;
using System.Collections.Generic;

namespace TerraSharp.Core
{
    public class Deposit
    {
        public readonly double proposal_id;
        public readonly string depositor;
        public List<Coin> amount { get; set; }

        public Deposit(double proposal_id, string depositor, List<Coin> amount)
        {
            this.amount = amount;
            this.proposal_id = proposal_id;
            this.depositor = depositor;
        }

        public static Deposit FromAmino(DepositAminoArgs data)
        {
            return new Deposit(double.Parse(data.ProposalId), data.Depositor, CoinsExtensions.FromAmino(data.Amount).ToList());
        }

        public static Deposit FromData(DepositDataArgs data)
        {
            return new Deposit(double.Parse(data.ProposalId), data.Depositor, CoinsExtensions.FromData(data.Amount).ToList());
        }

        public static Deposit FromProto(DEP_COMB.Deposit data)
        {
            return new Deposit(data.ProposalId, data.Depositor, CoinsExtensions.FromProto(data.Amounts).ToList());
        }
        public static Deposit FromJSON(ProposalDepositsJSON data)
        {
            return new Deposit(double.Parse(data.proposal_id), data.depositor, CoinsExtensions.FromJSON(data.amount).ToList());
        }
        public static Deposit FromJSON(TxBodyJSONMessages data)
        {
            return new Deposit(data.proposal_id, data.depositor, CoinsExtensions.FromJSON(data.amount).ToList());
        }


        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(new DEP_COMB.Deposit()
            {
                Depositor = this.depositor,
                ProposalId = (ulong)this.proposal_id
            });
        }


        public DepositDataArgs ToData()
        {
            return new DepositDataArgs()
            {
                ProposalId = $"{this.proposal_id}",
                Depositor = this.depositor,
                Amount = CoinsExtensions.ToData(this.amount).ToArray()
            };
        }
        public DepositAminoArgs ToAmino()
        {
            return new DepositAminoArgs()
            {
                ProposalId = $"{this.proposal_id}",
                Depositor = this.depositor,
                Amount = CoinsExtensions.ToAmino(this.amount).ToArray()
            };
        }

        public static Deposit UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<DEP_COMB.Deposit>(msgAny.Value));
        }
    }

    public class DepositAminoArgs
    {
        public string ProposalId { get; set; }
        public string Depositor { get; set; }
        public CoinAminoArgs[] Amount { get; set; }
    }

    public class DepositDataArgs
    {
        public string ProposalId { get; set; }
        public string Depositor { get; set; }
        public CoinDataArgs[] Amount { get; set; }
    }
}
