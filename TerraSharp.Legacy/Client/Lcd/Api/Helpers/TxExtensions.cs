
using System.Linq;
using TerraSharp.Converters;
using TerraSharp.Core;
using TerraSharp.Rest.Tx.Transaction.Upload;

namespace TerraSharp.Client.Lcd.Api.Helpers
{
    internal class TxExtensions
    {
        public static TxUploadValueJSON FromTx(Tx tx, object[] msgs)
        {
            return new TxUploadValueJSON()
            {
                auth_info = tx.auth_info.ToJson(),
                body = tx.body.ToJsonForUpload(msgs.ToList().ConvertAll(w => JSONMessageBodyConverter.GetJsonFromBody(w)).ToArray()),
                signatures = tx.signatures.ToArray(),
            };
        }
    }
}
