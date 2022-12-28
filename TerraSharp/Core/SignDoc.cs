using Terra.Microsoft.Extensions.ProtoBufs;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Transaction.Upload;
using System.Collections.Generic;

namespace Terra.Microsoft.Client.Core
{
    public class SignDoc
    {
        public readonly string chain_id;
        public readonly double account_number;
        public readonly double sequence;
        public readonly AuthInfo auth_info;
        public readonly TxBody tx_body;

        public SignDoc(
            string chain_id,
            double account_number,
            double sequence,
            AuthInfo auth_info,
            TxBody tx_body)
        {
            this.chain_id = chain_id;
            this.account_number = account_number;
            this.sequence = sequence;
            this.auth_info = auth_info;
            this.tx_body = tx_body;
        }

        public static SignDoc FromData(SignDocDataArgs data)
        {
            return new SignDoc(
                      data.Chain_Id,
                      double.Parse(data.Account_Number),
                      double.Parse(data.Sequence),
                      AuthInfo.FromBytes(TerraStringExtensions.GetBase64BytesFromString(data.Auth_Info_Bytes)),
                      null);
        }

        public PROTO.SignDoc ToProtoWithType(TxUploadMessageData[] messages = null)
        {
            return new PROTO.SignDoc()
            {
                AccountNumber = (ulong)this.account_number,
                BodyBytes = this.tx_body.ToProto(messages),
                AuthInfoBytes = this.auth_info.ToProto(),
                ChainId = this.chain_id
            };
        }

        public byte[] ToProto(TxUploadMessageData[] messages = null)
        {
            var data = this.ToProtoWithType(messages);
            return ProtoExtensions.SerialiseFromData(data);
        }

        public Tx ToUnsignedTx()
        {
            return new Tx(this.tx_body, this.auth_info, new List<string>());
        }

        public SignDocDataArgs ToData()
        {
            return new SignDocDataArgs()
            {
                Account_Number = this.account_number.ToString(),
                Auth_Info_Bytes = TerraStringExtensions.GetBase64FromBytes(this.auth_info.ToProto()),
                Body_Bytes = TerraStringExtensions.GetBase64FromBytes(this.tx_body.ToProto()),
                Chain_Id = this.chain_id,
                Sequence = this.sequence.ToString()
            };
        }

        public SignDocAminoArgs ToAmino()
        {
            return new SignDocAminoArgs()
            {
                Account_Number = this.account_number.ToString(),
                Timeout_Height = this.tx_body.timeout_height.ToString(),
                Fee = this.auth_info.fee.ToAmino(),
                Memo = this.tx_body.memo,
                Msgs = this.tx_body.messages,
                Chain_Id = this.chain_id,
                Sequence = this.sequence.ToString()
            };
        }
    }

    public class SignDocAminoArgs : SignDocCommonArgs
    {
        public string Timeout_Height { get; set; }
        public FeeAminoArgs Fee { get; set; }
        public string Memo { get; set; }
        public object[] Msgs { get; set; }
    }

    public class SignDocDataArgs : SignDocCommonArgs
    {
        public string Auth_Info_Bytes { get; set; }
        public string Body_Bytes { get; set; }
    }

    public class SignDocCommonArgs
    {
        public string Chain_Id { get; set; }
        public string Account_Number { get; set; }
        public string Sequence { get; set; }
    }
}
