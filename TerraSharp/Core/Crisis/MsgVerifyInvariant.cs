using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crisis.v1beta1;
using Terra.Microsoft.Client.Core.Constants;
using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Rest.Tx.Block;
using Newtonsoft.Json;
using Terra.Microsoft.Rest.Tx.Transaction;

namespace Terra.Microsoft.Client.Core.Crisis
{
    public class MsgVerifyInvariant : SignerData
    {
        public readonly string sender;
        public readonly string invariantModuleName;
        public readonly string invariantRoute;

        public MsgVerifyInvariant(string sender, string invariantModuleName, string invariantRoute)
        {
            this.sender = sender;
            this.invariantModuleName = invariantModuleName;
            this.invariantRoute = invariantRoute;
        }
        public static MsgVerifyInvariant FromProto(PROTO.MsgVerifyInvariant data)
        {
            return new MsgVerifyInvariant(data.Sender, data.InvariantModuleName, data.InvariantRoute);
        }
        public static MsgVerifyInvariant FromData(MsgVerifyInvariantDataArgs data)
        {
            return new MsgVerifyInvariant(data.Sender, data.InvariantModuleName, data.InvariantRoute);
        }
        public static MsgVerifyInvariant FromAmino(MsgVerifyInvariantAminoArgs data)
        {
            return new MsgVerifyInvariant(data.Value.Sender, data.Value.InvariantModuleName, data.Value.InvariantRoute);
        }
        //public TxBodyJSONMessages ToJson()
        //{
        //    return new TxBodyJSONMessages()
        //    {
        //        invari = this.withdraw_address,
        //        delegator_address = this.delegator_address,
        //        type = this.ToData().Type,
        //    };
        //}

        public MsgVerifyInvariantDataArgs ToData()
        {
            return new MsgVerifyInvariantDataArgs()
            {
                Sender = this.sender,
                InvariantRoute = this.invariantRoute,
                InvariantModuleName = this.invariantModuleName,
            };
        }

        public PROTO.MsgVerifyInvariant ToProtoWithType()
        {
            return new PROTO.MsgVerifyInvariant()
            {
                InvariantModuleName = this.invariantModuleName,
                InvariantRoute = this.invariantRoute,
                Sender = this.sender
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
                TypeUrl = CosmosConstants.COSMOS_CRISIS_MSG_VERIFY_INVARIANT,
                Value = this.ToProto()
            };
        }

        public static MsgVerifyInvariant UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgVerifyInvariant>(msgAny.Value));
        }
    }

    public class MsgVerifyInvariantAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgVerifyInvariantValueAminoArgs Value { get; set; }

        public MsgVerifyInvariantAminoArgs()
        {
            this.Type = CrisisConstants.CRISIS_MSG_VERIFY_INVARIANT;
        }
    }
    public class MsgVerifyInvariantValueAminoArgs
    {
        public string Sender { get; set; }
        public string InvariantModuleName { get; set; }
        public string InvariantRoute { get; set; }
    }

    public class MsgVerifyInvariantDataArgs : MsgVerifyInvariantValueAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgVerifyInvariantDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_CRISIS_MSG_VERIFY_INVARIANT;
        }
    }
}
