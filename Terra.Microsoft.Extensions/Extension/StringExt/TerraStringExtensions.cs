using RandomStringCreator;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Terra.Microsoft.Extensions.StringExt
{
    public static class TerraStringExtensions
    {
        private const string ISO_REGEX = "/\\.000Z$/";
        public static bool ContainsIgnoreCase(this string source, string verify) => source.ToLower().Contains(verify.ToLower());

        /// <summary>
        /// Return either the attribute string or a default value.
        /// </summary>
        /// <param name="result">The processed string.</param>
        /// <param name="defaultString">The default string to process.</param>
        /// <returns>Return either the "result" or a default string. If no default string specified, returns "Unknown".</returns>
        public static string GetStringOrDefault(this string result, string defaultString = "Unknown") => string.IsNullOrWhiteSpace(result) ? defaultString : result;

        public static string GenerateCleanStringFromAscii(this string result)
        {
            return Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8,
                Encoding.GetEncoding(
                    Encoding.ASCII.EncodingName,
                    new EncoderReplacementFallback(string.Empty),
                    new DecoderExceptionFallback()
                    ),

                Encoding.UTF8.GetBytes(result)));
        }

        /// <summary>
        /// Get String from a memory Stream.
        /// </summary>
        /// <param name="memoryStream"></param>
        /// <returns></returns>
        public static string GetStringFromStream(Stream memoryStream) => new StreamReader(memoryStream).ReadToEnd();

        /// <summary>
        /// Get bytes from String.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] GetBytesFromString(string text) => Encoding.UTF8.GetBytes(text);
        public static string GetStringFromBase64(string base64) => GetStringFromBytes(System.Convert.FromBase64String(base64));
        public static byte[] GetBytesFromBase64(string base64) => System.Convert.FromBase64String(base64);

        public static string GetJSONFromobject(object data) => Newtonsoft.Json.JsonConvert.SerializeObject(data);

        /// <summary>
        /// Remove any Escape symbols from the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EscapeSingleQuotes(string str) => str.Replace("/g,", "\\");

        /// <summary>
        /// Converts to Base64
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetBase64FromString(string text) => System.Convert.ToBase64String(GetBytesFromString(text));
        public static byte[] GetBase64BytesFromString(string text) => GetBytesFromString(GetBase64FromString(text));
        public static byte[] GetBase64BytesFromBytes(byte[] data) => GetBytesFromString(GetBase64FromBytes(data));
        public static string GetBase64FromBytes(byte[] data) => System.Convert.ToBase64String(data);
        /// <summary>
        /// Converts to Base64
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetStringFromBytes(byte[] data) => System.Text.Encoding.UTF8.GetString(data);
        public static string GetRandomString()
        {
            using (var randomString = new StringCreator())
            {
                return randomString.Get(32);
            }
        }
        public static DateTime GetISODateTimeFromString(this string dateTime)
        {
            return DateTime.Parse(dateTime);
        }
        public static string GetISOStringFromDate(this DateTime date)
        {
            return date.ToString("s").Replace(ISO_REGEX, "Z");
        }
        public static string ToStringHex(this byte[] bytes)
        {
            var hex = BitConverter
                .ToString(bytes)
                .Replace("-", "")
                .ToLower();

            return hex;
        }

        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            if (end < 0)
                end = source.Length;

            var len = end - start;

            // Return new array.
            var res = new T[len];
            for (var i = 0; i < len; i++) res[i] = source[i + start];
            return res;
        }

        public static T[] Slice<T>(this T[] source, int start)
        {
            return Slice<T>(source, start, -1);
        }

        public static byte[] HexToByteArray(this string hex)
        {
            var bytes = Enumerable.Range(0, hex.Length / 2)
                    .Select(x => Convert.ToByte(hex.Substring(x * 2, 2), 16))
                    .ToArray();

            return bytes;
        }

        public static byte[] PaddedByteArray(byte[] bytes, int length)
        {
            var finalBytes = new byte[length];
            Fill(finalBytes, (byte)0);
            Array.Copy(bytes, 0, finalBytes, 0, bytes.Length);

            return finalBytes;
        }

        public static void Fill<T>(this T[] arr, T value)
        {
            for (var i = 0; i < arr.Length; i++)
                arr[i] = value;
        }
    }
}
