using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.CoreData.ProcessorData
{
    public class Selection : ProcessorDataBase
    {
        public ConcurrentDictionary<string, Selection> TheSelections { get; set; }

        public Selection(oddfeedEventMarketSel feedObject)
        {
            TheSelections=new ConcurrentDictionary<string, Selection>();
        }

        public void Assimilate(oddfeedEventMarketSel feedObject)
        {
        }
        /// <summary>
        /// Mapper
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static oddfeedEventMarketSel Map(oddfeedEventMarketSel source)
        {
            return source;
        }

        public static string CompileKey(oddfeedEventMarketSel source)
        {
            return string.Format("{0}", source.name);
        }
    }
}
