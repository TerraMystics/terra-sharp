using System.Text;

namespace Terra.Microsoft.Extensions.StringExt
{
    public static class JsonWebExtensions
    {
        public static string RemoveNull(this string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                StringBuilder jsonFormatter = new StringBuilder();
                jsonFormatter.Append(json);
                jsonFormatter.Replace("\\", string.Empty);
                return jsonFormatter.ToString().Trim('"');
            }
            else
                return json;
        }
    }
}
