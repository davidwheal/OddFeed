using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.CoreData.ProcessorData
{
    [DataContract]
    public class EventDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Date { get; set; }
       
        public EventDto()
        {
        }

        public EventDto(Event ev)
        {
            Name = ev.Name;
            Date = ev.Date;
        }

    }
    public class Event : ProcessorDataBase
    {

        public ConcurrentDictionary<string, Market> TheMarkets { get; set; }

        public string Date { get; set; }
        public Event(oddfeedEvent feedObject)
        {
            Name = feedObject.name;
            Date = feedObject.date;
            TheMarkets = new ConcurrentDictionary<string, Market>();
            Assimilate(feedObject);
        }

        public void Assimilate(oddfeedEvent feedObject)
        {
            foreach (var mk in feedObject.market)
            {
                var mappedMarket = Market.Map(mk);
                var key = Market.CompileKey(mappedMarket);
                Market actualMarket;
                if (TheMarkets.TryGetValue(key, out actualMarket))
                {
                    actualMarket.Assimilate(mappedMarket);
                }
                else
                {
                    actualMarket = new Market(mappedMarket);
                    TheMarkets.TryAdd(key, actualMarket);
                }
            }
        }

        /// <summary>
        /// Mapper
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static oddfeedEvent Map(oddfeedEvent source)
        {
            return source;
        }

        public static string CompileKey(oddfeedEvent source)
        {
            return string.Format("{0}:{1}", source.name, source.date);
        }
    }
}
