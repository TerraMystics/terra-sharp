using System.Text;

namespace Terra.Microsoft.Extensions.Extension.Bech32
{
    public static class Bech32Extensions
    {
        public static string GetBech32Address(string hrp, byte[] data)
        {
            return Bech32Engine.Encode(hrp, data);
        }
    }
}
