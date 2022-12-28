using System;

namespace Terra.Microsoft.Rest.Authz
{
    public class AuthorizationGrantValueJSON
    {
        public object authorization { get; set; }
        public DateTime expiration { get; set; }
    }
}
