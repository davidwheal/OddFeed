using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Entities.Entities
{
    public class PriceEntity : AEntityBase
    {
        public ConcurrentDictionary<string, string> BookiePrices { get; set; } 

        public PriceEntity(string parentName, string name)
            : base(parentName, name)
        {
        }

        public PriceEntity(string parentName, string name, DateTime? time)
            : base(parentName, name, time)
        {
        }

        public PriceEntity(string name)
            : base(name)
        {
        }
    }
}
