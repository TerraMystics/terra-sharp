using System.Text;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Client.Core.Keys.Args;
using Terra.Microsoft.Client.Core.Keys;
using Terra.Microsoft.Client.Core.Keys.Constants;
using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.ProtoBufs.proto.keys;
using System;

namespace Terra.Microsoft.Client.Core.Extensions
{
    public static class PublicKeyExtensions
    {
        public static byte[] pubkeyAminoPrefixSecp256k1 = Encoding.UTF8.GetBytes(string.Concat("eb5ae987", "21"));
        public static byte[] pubkeyAminoPrefixEd25519 = Encoding.UTF8.GetBytes(string.Concat("1624de64", "20"));
        public static byte[] pubkeyAminoPrefixMultisigThreshold = Encoding.UTF8.GetBytes("22c1f7e2");

        public static byte[] GetBase64DataFromKey(string key)
        {
            return TerraStringExtensions
                .GetBytesFromString(TerraStringExtensions.GetBase64FromString(key));
        }

        public static int[] EncodeUVariant(int result)
        {
            if (result > 127)
            {
                throw new Exception("Encoding numbers > 127 is not supported here. Please tell those lazy CosmJS maintainers " +
                    "to port the binary.PutUvarint implementation from the Go standard library and write some tests.");
            }
            return new int[] { result };
        }

        public static bool IsSimpleKey(this KeysDto key)
        {
            return key.TypeUrl == TendermintKeys.TENDERMINT_SIMPLE_PUBKEY;
        }
        public static bool IsValConsPublicKey(this KeysDto key)
        {
            return key.TypeUrl == TendermintKeys.TENDERMINT_VALCONS_PUBKEY;
        }
        public static bool IsLegacyMultiSigKey(this KeysDto key)
        {
            return key.TypeUrl == TendermintKeys.TENDERMINT_LEGACY_MULTISIG_AMINO_PUBKEY;
        }
    }
}
