using Google.Protobuf.WellKnownTypes;
using System.Linq;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Constants;
using PROTO = TerraProto.CSharp.third_party.proto.ibc.core.client.v1;

namespace TerraSharp.Core.IBC.Msgs.Client
{
    public class ClientConsensusStates
    {
        public readonly string client_id;
        public readonly ConsensusStateWithHeight[] consensus_states;

        public ClientConsensusStates(
            string client_id,
            ConsensusStateWithHeight[] consensus_states)
        {
            this.client_id = client_id;
            this.consensus_states = consensus_states;
        }

        public static ClientConsensusStates FromData(ClientConsensusStatesDataArgs data)
        {
            return new ClientConsensusStates(
                data.Client_Id,
                data.Consensus_States.ToList().ConvertAll(w => ConsensusStateWithHeight.FromData(w)).ToArray());
        }

        public ClientConsensusStatesDataArgs ToData()
        {
            return new ClientConsensusStatesDataArgs()
            {
                Client_Id = this.client_id,
                Consensus_States = this.consensus_states.ToList().ConvertAll(w => w.ToData()).ToArray()
            };
        }

        public PROTO.ClientConsensusStates ToProtoWithType()
        {
            return new PROTO.ClientConsensusStates()
            {
                ClientId = this.client_id,
                ConsensusStates = this.consensus_states.ToList().ConvertAll(w => w.ToProtoWithType())
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }
    public class ClientConsensusStatesAminoArgs : ClientConsensusStatesCommonArgs
    {
        public ConsensusStateWithHeightAminoArgs[] Consensus_States { get; set; }
    }
    public class ClientConsensusStatesDataArgs : ClientConsensusStatesCommonArgs
    {
        public ConsensusStateWithHeightDataArgs[] Consensus_States { get; set; }
    }

    public class ClientConsensusStatesCommonArgs
    {
        public string Client_Id;
    }
}
