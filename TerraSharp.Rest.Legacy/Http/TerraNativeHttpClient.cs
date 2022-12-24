using ModernHttpClient;
using System.Net.Http;

namespace TerraSharp.Rest
{
    public class TerraNativeHttpClient : HttpClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerraNativeHttpClient"/> class.
        /// Native Message Handler.
        /// </summary>
        public TerraNativeHttpClient() : base(new NativeMessageHandler(false, new TLSConfig()), true)
        {
        }
    }
}
