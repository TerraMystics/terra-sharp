using Newtonsoft.Json;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Transaction;
using COMB_TX = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.ibase.abci.v1beta1;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Terra.Microsoft.Client.Core
{

    public class TxInfo
    {
        public readonly double height;
        public readonly string txhash;
        public readonly string raw_log;
        public readonly TxLog[] logs;
        public readonly double gas_wanted;
        public readonly double gas_used;
        public readonly Tx tx;
        public readonly DateTime timestamp;
        public readonly double? code;
        public readonly string codespace;

        public TxInfo(
            double height,
            string txhash,
            string raw_log,
            TxLog[] logs,
            double gas_wanted,
            double gas_used,
            Tx tx,
            DateTime timestamp,
            double? code,
            string codespace)
        {
            this.height = height;
            this.txhash = txhash;
            this.raw_log = raw_log;
            this.logs = logs;
            this.gas_wanted = gas_wanted;
            this.gas_used = gas_used;
            this.tx = tx;
            this.timestamp = timestamp;
            this.code = code;
            this.codespace = codespace;
        }

        public static TxInfo FromData(TxInfoData data)
        {
            return new TxInfo(
                data.Height,
                data.TxHash,
                data.RawLog,
                data.Logs.ToList().ConvertAll(w => TxLog.FromData(w)).ToArray(),
                data.GasWanted,
                data.GasUsed,
                Tx.FromData(data.Tx),
                TerraStringExtensions.GetISODateTimeFromString(data.Timestamp),
                data.Code,
                data.Codespace);
        }
    }

    public class EventKV
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Event
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public EventKV[] Attributes { get; set; }
    }

    public class EventsByType
    {
        public List<KeyValuePair<string, EventsByTypeValue>> Types { get; set; }

        public EventsByType()
        {
            this.Types = new List<KeyValuePair<string, EventsByTypeValue>>();
        }
    }

    public class EventsByTypeValue
    {
        public KeyValuePair<string, string[]> Values { get; set; }
    }


    public class TxInfoData
    {
        public double Height { get; set; }
        public string TxHash { get; set; }
        public string Codespace { get; set; }
        public double Code { get; set; }
        public string Data { get; set; }
        public string RawLog { get; set; }
        public TxLogDataArgs[] Logs { get; set; }
        public string Info { get; set; }
        public double GasWanted { get; set; }
        public double GasUsed { get; set; }
        public TxDataArgs Tx { get; set; }
        public string Timestamp { get; set; }
    }
}
