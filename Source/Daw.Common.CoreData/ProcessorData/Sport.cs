using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.CoreData.ProcessorData
{
    public class Sport : ProcessorDataBase
    {
        public ConcurrentDictionary<string, Event> TheEvents { get; set; }
        public Sport(oddfeed feedObject)
        {
            Name = feedObject.sport;
            TheEvents = new ConcurrentDictionary<string, Event>();
            Assimilate(feedObject);
        }

        public void Assimilate(oddfeed feedObject)
        {
            foreach (var ev in feedObject.@event)
            {
                var mappedEvent = Event.Map(ev);
                var key = Event.CompileKey(ev);
                Event actualEvent;
                if (TheEvents.TryGetValue(key, out actualEvent))
                {
                    actualEvent.Assimilate(ev);
                }
                else
                {
                    actualEvent = new Event(ev);
                    TheEvents.TryAdd(key, actualEvent);
                }
            }
        }


    }
}
