using TerraSharp.Rest.Util;

namespace TerraSharp.Client.Lcd.Api
{
    public abstract class BaseAPI
    {
        protected readonly TerraRestfulService apiRequester;
        public BaseAPI(TerraRestfulService apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
