using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1;

namespace Terra.Microsoft.Rest.Converters
{
    public static class SignModeConverters
    {
        public static SignMode GetFromString(string val)
        {
            switch (val)
            {
                case "SIGN_MODE_TEXTUAL":
                    return SignMode.SignModeTextual;
                case "SIGN_MODE_UNSPECIFIED":
                    return SignMode.SignModeUnspecified;
                case "SIGN_MODE_DIRECT":
                    return SignMode.SignModeDirect;
                case "SIGN_MODE_LEGACY_AMINO_JSON":
                    return SignMode.SignModeLegacyAminoJson;
            }

            return SignMode.SignModeUnspecified;
        }
        public static string GetFromEnum(SignMode val)
        {
            switch (val)
            {
                case SignMode.SignModeTextual:
                    return "SIGN_MODE_TEXTUAL";
                case SignMode.SignModeUnspecified:
                    return "SIGN_MODE_UNSPECIFIED";
                case SignMode.SignModeDirect:
                    return "SIGN_MODE_DIRECT";
                case SignMode.SignModeLegacyAminoJson:
                    return "SIGN_MODE_LEGACY_AMINO_JSON";
            }

            return "SIGN_MODE_UNSPECIFIED";
        }
    }
}
