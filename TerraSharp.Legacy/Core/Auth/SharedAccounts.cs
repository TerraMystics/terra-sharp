using Google.Protobuf.WellKnownTypes;
using TerraProto.CSharp.proto.keys;

namespace TerraSharp.Core.Auth
{
    public abstract class SharedAccounts
    {
        public abstract double GetAccountNumber();
        public abstract double GetSequenceNumber();
        public abstract KeysDto GetPublicKey();
    }

}
