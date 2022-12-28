using System.Collections.Generic;
using System.Linq;

namespace Terra.Microsoft.Client.Core.Extensions
{
    public static class EventsTypeExtensions
    {
        public static EventsByType Parse(Event[] eventAmino)
        {
            var events = new EventsByType();

            foreach (var ev in eventAmino)
            {
                foreach (var attr in ev.Attributes)
                {
                    if (!(events.Types.Any(q => q.Key == ev.Type)))
                    {
                        events.Types.RemoveAll(q => q.Key == ev.Type);
                    }

                    if (!(events.Types.Any(q => q.Value?.Values.Key == attr.Key)))
                    {
                        events.Types.RemoveAll(q => q.Value?.Values.Key == attr.Key);
                    }

                    events.Types.Add(new KeyValuePair<string, EventsByTypeValue>(ev.Type, new EventsByTypeValue()
                    {
                        Values = new KeyValuePair<string, string[]>(attr.Key, new string[] { attr.Value })
                    }));
                }
            }

            return events;
        }
    }
}
