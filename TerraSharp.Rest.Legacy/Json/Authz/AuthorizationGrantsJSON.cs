namespace Terra.Microsoft.Rest.Authz
{
    public class AuthorizationGrantsJSON
    {
        public AuthorizationGrantValueJSON[] grants { get; set; }
        public PaginationJson pagination { get; set; }
    }
}
