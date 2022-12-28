using Google.Protobuf.WellKnownTypes;
using ProtoBuf;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Transaction;
using Terra.Microsoft.Rest.Tx.Transaction.Upload;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.v1beta1;

namespace Terra.Microsoft.Client.Core
{
    public class TxBody
    {
        public readonly TxBodyJSONMessages[] messages;
        public readonly string memo;
        public readonly double? timeout_height;

        public TxBody(
            TxBodyJSONMessages[] messages,
            string memo,
            double? timeout_height)
        {
            this.messages = messages;
            this.memo = memo;
            this.timeout_height = timeout_height;
        }

        public static TxBody FromData(TxBodyDataArgs data)
        {
            return new TxBody(data.Messages, data.Memo, data.Timeout_Height);
        }

        public static TxBody FromJSON(TxBodyJSON data)
        {
            return new TxBody(
                data.messages,
                data.memo,
                double.Parse(data.timeout_height));
        }

        public PROTO.TxBody ToProtoWithType(TxUploadMessageData[] messages = null)
        {
            var proto = new PROTO.TxBody()
            {
                Memo = this.memo,
                TimeoutHeight = (ulong)this.timeout_height
            };

            if (messages != null)
            {
                proto.Messages = messages.ToList().ConvertAll(w => new Any()
                {
                    TypeUrl = w.type_url,
                    Value = w.value
                }).ToList();
            }

            return proto;
        }

        public byte[] ToProto(TxUploadMessageData[] messages = null)
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType(messages));
        }

        public TxBodyDataArgs ToData()
        {
            return new TxBodyDataArgs()
            {
                Messages = this.messages,
                Timeout_Height = this.timeout_height,
                Memo = this.memo
            };
        }

        public TxUploadBodyJSON ToJsonForUpload(TxUploadMessageData[] msgs)
        {
            return new TxUploadBodyJSON()
            {
                messages = msgs,
                memo = this.memo,
                timeout_height = this.timeout_height
            };
        }
    }

    public class TxBodyDataArgs
    {
        public TxBodyJSONMessages[] Messages { get; set; }
        public string Memo { get; set; }
        public double? Timeout_Height { get; set; }
    }



}
