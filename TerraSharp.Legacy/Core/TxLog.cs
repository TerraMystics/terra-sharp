using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using TerraNetExtensions.ProtoBufs;
using TerraSharp.Core.Extensions;
using COMB_ABC = TerraProto.CSharp.third_party.proto.cosmos.ibase.abci.v1beta1;

namespace TerraSharp.Core
{
    public class TxLog
    {
        public readonly EventsByType eventsByType;
        public readonly double msg_index;
        public readonly string log;
        public readonly Event[] events;

        public TxLog(
            double msg_index,
            string log,
            Event[] events)
        {
            this.eventsByType = EventsTypeExtensions.Parse(events);

            this.msg_index = msg_index;
            this.log = log;
            this.events = events;
        }

        public TxLogDataArgs ToData()
        {
            return new TxLogDataArgs()
            {
                Events = this.events.ToList().ConvertAll(w => new TxLogDataEventArgs()
                {
                    Type = w.Type,
                    Attributes = w.Attributes.ToList().ConvertAll(q => new KeyValuePair<string, string>(q.Key, q.Value)).ToArray()
                }).ToArray(),
                Log = this.log,
                MsgIndex = this.msg_index
            };
        }

        public COMB_ABC.ABCIMessageLog ToProtoWithType()
        {
            return new COMB_ABC.ABCIMessageLog()
            {
                Events = this.events.ToList().ConvertAll(w => new COMB_ABC.StringEvent()
                {
                    Attributes = w.Attributes.ToList().ConvertAll(q => new COMB_ABC.Attribute() { Key = q.Key, Value = q.Value }),
                    Type = w.Type
                }),
                Log = this.log,
                MsgIndex = (uint)this.msg_index
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }

        public static TxLog FromData(TxLogDataArgs data)
        {
            return new TxLog(data.MsgIndex, data.Log, data.Events.ToList().ConvertAll(w =>
            {
                return new Event()
                {
                    Type = w.Type,
                    Attributes = w.Attributes.ToList().ConvertAll(q => new EventKV()
                    {
                        Key = q.Key,
                        Value = q.Value
                    }).ToArray()
                };
            }).ToArray());
        }

        public static TxLog FromProto(COMB_ABC.ABCIMessageLog data)
        {
            return new TxLog(data.MsgIndex, data.Log, data.Events.ToList().ConvertAll(w =>
            {
                return new Event()
                {
                    Type = w.Type,
                    Attributes = w.Attributes.ToList().ConvertAll(q => new EventKV()
                    {
                        Key = q.Key,
                        Value = q.Value
                    }).ToArray()
                };
            }).ToArray());
        }
    }

    public class TxLogDataArgs
    {
        public double MsgIndex { get; set; }
        public string Log { get; set; }
        public TxLogDataEventArgs[] Events { get; set; }
    }

    public class TxLogDataEventArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public KeyValuePair<string, string>[] Attributes { get; set; }
    }
}
