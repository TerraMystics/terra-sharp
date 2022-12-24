using System.Collections.Generic;

namespace TerraSharp.Rest.Tx.Transaction
{
    public class TxSearchOptions : PaginationOptions
    {
        public TxSearchOptionsEvents events { get; set; }

    }
    public class TxSearchOptionsEvents
    {
        public KeyValuePair<string, string>[] keyevents { get; set; }
    }

}
