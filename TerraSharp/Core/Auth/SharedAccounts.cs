using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.ProtoBufs.proto.keys;

namespace Terra.Microsoft.Client.Core.Auth
{
    public abstract class SharedAccounts
    {
        public abstract double GetAccountNumber();
        public abstract double GetSequenceNumber();
        public abstract KeysDto GetPublicKey();
    }

}
