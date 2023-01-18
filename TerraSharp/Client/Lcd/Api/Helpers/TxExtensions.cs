using Newtonsoft.Json;
using System.Linq;
using Terra.Microsoft.Client.Converters;
using Terra.Microsoft.Client.Core;
using Terra.Microsoft.Rest.Tx.Transaction.Upload;

namespace Terra.Microsoft.Client.Client.Lcd.Api.Helpers
{
    internal class TxExtensions
    {
        public static TxUploadValueJSON FromTx(Tx tx, object[] msgs)
        {
            return new TxUploadValueJSON()
            {
                auth_info = tx.auth_info.ToJson(),
                body = tx.body.ToJsonForUpload(msgs.ToList().ConvertAll(w => JSONMessageBodyConverter.GetJsonFromBody(w)).ToArray()),
                signatures = tx.signatures.ConvertAll(w => JsonConvert.SerializeObject(w)).ToArray(),
            };
        }
    }
}
