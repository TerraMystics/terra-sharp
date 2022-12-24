using Google.Protobuf.WellKnownTypes;
using PROTO = TerraProto.CSharp.third_party.proto.cosmos.slashing.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.Tx.Block;
using Newtonsoft.Json;

namespace TerraSharp.Core.Slashing.Msgs
{
    public class MsgUnjail : SignerData
    {
        public readonly string address;

        public MsgUnjail(string address)
        {
            this.address = address;
        }

        public static MsgUnjail FromAmino(MsgUnjailAminoArgs data)
        {
            return new MsgUnjail(data.Value.Address);
        }

        public static MsgUnjail FromData(MsgUnjailDataArgs data)
        {
            return new MsgUnjail(data.Address);
        }

        public static MsgUnjail FromProto(PROTO.MsgUnjail data)
        {
            return new MsgUnjail(data.ValidatorAddr);
        }

        public MsgUnjailAminoArgs ToAmino()
        {
            return new MsgUnjailAminoArgs()
            {
                Value = new MsgUnjailValueAminoArgs()
                {
                    Address = this.address
                }
            };
        }

        public MsgUnjailDataArgs ToData()
        {
            return new MsgUnjailDataArgs()
            {
                Address = this.address
            };
        }

        public PROTO.MsgUnjail ToProtoWithType()
        {
            return new PROTO.MsgUnjail()
            {
                ValidatorAddr = this.address
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
                TypeUrl = CosmosConstants.COSMOS_SLASHING_MSG_UNJAIL,
                Value = this.ToProto()
            };
        }

        public static MsgUnjail UnPackAny(Any msgAny)
        {
            return FromProto(ProtoExtensions.DeserialiseFromBytes<PROTO.MsgUnjail>(msgAny.Value));
        }
    }

    public class MsgUnjailAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public MsgUnjailValueAminoArgs Value { get; set; }
        public MsgUnjailAminoArgs()
        {
            this.Type = SlashingConstants.SLASHING_MSG_UNJAIL;
        }
    }

    public class MsgUnjailValueAminoArgs
    {
        public string Address { get; set; }
    }

    public class MsgUnjailDataArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Address { get; set; }

        public MsgUnjailDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_SLASHING_MSG_UNJAIL;
        }
    }
}
