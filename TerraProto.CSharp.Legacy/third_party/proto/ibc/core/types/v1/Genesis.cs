using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Microsoft.ProtoBufs.third_party.proto.ibc.core.types.v1
{
    [global::ProtoBuf.ProtoContract()]
    public partial class GenesisState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_genesis")]
        public ibc.core.client.v1.GenesisState ClientGenesis { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"connection_genesis")]
        public ibc.core.connection.v1.GenesisState ConnectionGenesis { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"channel_genesis")]
        public ibc.core.channel.v1.GenesisState ChannelGenesis { get; set; }
    }
}
