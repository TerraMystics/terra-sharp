namespace TerraSharp.Rest.Extensions
{
    public static class PaginationOptionExtensions
    {
        public static string GetPaginationRules(this PaginationOptions options)
        {
            //string rules = $"&pagination.count_total={options.Count_total}&pagination.reverse={options.Reverse}";
            //if (!string.IsNullOrWhiteSpace(options.Limit))
            //{
            //    rules = string.Concat(rules, $"&pagination.limit={options.Limit}");
            //}
            //if (!string.IsNullOrWhiteSpace(options.Key))
            //{
            //    rules = string.Concat(rules, $"&pagination.key={options.Key}");
            //}
            //if (!string.IsNullOrWhiteSpace(options.Offset))
            //{
            //    rules = string.Concat(rules, $"&pagination.offset={options.Offset}");
            //}

            //return rules.ToLower();

            return "";
        }
        public static string GetProposalsQueryParameters(string[] events)
        {
            string rules = $"";
            foreach (var evc in events)
            {
                if (!string.IsNullOrWhiteSpace(rules))
                {
                    rules += "&";
                }
                rules += $"events={evc}";
            }

            return rules;
        }
    }
}
