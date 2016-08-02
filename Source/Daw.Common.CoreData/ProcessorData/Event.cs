using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.CoreData.ProcessorData
{
    public class Event : ProcessorDataBase
    {
        public Event(oddfeedEvent feedObject)
        {
            
        }

        public void Assimilate(oddfeedEvent feedObject)
        {
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
            return string.Format("{0}{1}", source.name, source.date);
        }
    }
}
