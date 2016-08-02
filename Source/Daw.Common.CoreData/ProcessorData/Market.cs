using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.CoreData.ProcessorData
{
    public class Market : ProcessorDataBase
    {
        public ConcurrentDictionary<string, Market> TheMarkets { get; set; }

        public Market(oddfeedEventMarket feedObject)
        {
            TheMarkets=new ConcurrentDictionary<string, Market>();
        }

        public void Assimilate(oddfeedEventMarket feedObject)
        {
        }

        /// <summary>
        /// Mapper
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static oddfeedEventMarket Map(oddfeedEventMarket source)
        {
            return source;
        }

        public static string CompileKey(oddfeedEventMarket source)
        {
            return string.Format("{0}", source.name);
        }
    }
}
