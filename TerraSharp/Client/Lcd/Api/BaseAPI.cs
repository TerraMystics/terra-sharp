using Terra.Microsoft.Rest.Util;

namespace Terra.Microsoft.Client.Client.Lcd.Api
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
