using NBitcoin;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TerraSharp.Key.Extensions
{
    internal static class MnemonicExtension
    {
        public static async Task<KeyValuePair<Mnemonic, string>> PrepareMnemonic(string mnemonicKey)
        {
            Mnemonic mnemo = new Mnemonic(mnemonicKey);
            return new KeyValuePair<Mnemonic, string>(mnemo, mnemonicKey);
        }
        public static async Task<KeyValuePair<Mnemonic, string>> GenerateRandomMnemonic()
        {
            Mnemonic mnemo = new Mnemonic(Wordlist.English, WordCount.TwentyFour);

            return new KeyValuePair<Mnemonic, string>(mnemo, string.Join(" ", mnemo.Words));
        }

        public static async Task<string> GenerateRandomWords(WordCount wordCount = WordCount.TwentyFour)
        {
            Mnemonic mnemo = new Mnemonic(Wordlist.English, wordCount);

            return string.Join(" ", mnemo.Words);
        }
    }
}
