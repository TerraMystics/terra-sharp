using Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;

namespace Terra.Microsoft.Rest.Converters
{
    public class BroadcastModeConverter
    {
        public static BroadcastMode GetFromString(string val)
        {
            switch (val)
            {
                case "BROADCAST_MODE_UNSPECIFIED":
                    return BroadcastMode.BroadcastModeUnspecified;
                case "BROADCAST_MODE_BLOCK":
                    return BroadcastMode.BroadcastModeBlock;
                case "BROADCAST_MODE_SYNC":
                    return BroadcastMode.BroadcastModeSync;
                case "BROADCAST_MODE_ASYNC":
                    return BroadcastMode.BroadcastModeAsync;
            }

            return BroadcastMode.BroadcastModeUnspecified;
        }

        public static string GetFromEnum(BroadcastMode val)
        {
            switch (val)
            {
                case BroadcastMode.BroadcastModeUnspecified:
                    return "BROADCAST_MODE_UNSPECIFIED";
                case BroadcastMode.BroadcastModeBlock:
                    return "BROADCAST_MODE_BLOCK";
                case BroadcastMode.BroadcastModeSync:
                    return "BROADCAST_MODE_SYNC";
                case BroadcastMode.BroadcastModeAsync:
                    return "BROADCAST_MODE_ASYNC";
            }

            return "BROADCAST_MODE_UNSPECIFIED";
        }
    }
}
