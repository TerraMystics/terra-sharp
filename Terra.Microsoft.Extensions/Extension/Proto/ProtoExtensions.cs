using System;
using System.IO;

namespace Terra.Microsoft.Extensions.ProtoBufs
{
    public static class ProtoExtensions
    {
        public static T DeserialiseFromBytes<T>(this byte[] data) => ProtoBuf.Serializer.Deserialize<T>(new MemoryStream(data));
        public static byte[] SerialiseFromData<T>(this T data) where T : class, new()
        {
            using (var stream = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize<T>(stream, data);
                return stream.ToArray();
            }
        }

        public static byte[] SerialiseFromBase64Data(this string data)
        {
            using (var stream = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize(stream, Convert.FromBase64String(data));
                return stream.ToArray();
            }
        }

        public static byte[] MergeDataArrays(this byte[] srcArray1, byte[] srcArray2)
        {
            //Create a new array based on the total number of two array elements to be merged
            byte[] newArray = new byte[srcArray1.Length + srcArray2.Length];

            //Copy the first array to the newly created array
            Array.Copy(srcArray1, 0, newArray, 0, srcArray1.Length);

            //Copy the second array to the newly created array
            Array.Copy(srcArray2, 0, newArray, srcArray1.Length, srcArray2.Length);

            return newArray;
        }
    }
}
