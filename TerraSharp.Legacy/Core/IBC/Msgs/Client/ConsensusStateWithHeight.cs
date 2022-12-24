using Google.Protobuf.WellKnownTypes;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Rest.IBC;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.client.v1;

namespace TerraSharp.Core.IBC.Msgs.Client
{
    public class ConsensusStateWithHeight
    {
        public readonly Height height;
        public readonly ConsensusStateJSON consensus_state;

        public ConsensusStateWithHeight(
            Height height,
            ConsensusStateJSON consensus_state)
        {
            this.height = height;
            this.consensus_state = consensus_state;
        }

        public static ConsensusStateWithHeight FromData(ConsensusStateWithHeightDataArgs data)
        {
            return new ConsensusStateWithHeight(
                Height.FromData(data.Height),
                data.Consensus_State);
        }

        public ConsensusStateWithHeightDataArgs ToData()
        {
            return new ConsensusStateWithHeightDataArgs()
            {
                Height = this.height.ToData(),
                Consensus_State = this.consensus_state,
            };
        }
        public static ConsensusStateWithHeight FromJSON(IBCApiConsensusState data)
        {
            return new ConsensusStateWithHeight(
                Height.FromJSON(data.height),
                data.consensus_state);
        }

        public PROTO.ConsensusStateWithHeight ToProtoWithType()
        {
            return new PROTO.ConsensusStateWithHeight()
            {
                Height = this.height.ToProtoWithType(),
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class ConsensusStateWithHeightAminoArgs : ConsensusStateWithHeightCommonArgs
    {
        public HeightAminoArgs Height { get; set; }
    }
    public class ConsensusStateWithHeightDataArgs : ConsensusStateWithHeightCommonArgs
    {
        public HeightDataArgs Height { get; set; }
    }

    public class ConsensusStateWithHeightCommonArgs
    {
        public ConsensusStateJSON Consensus_State { get; set; }
    }
}
