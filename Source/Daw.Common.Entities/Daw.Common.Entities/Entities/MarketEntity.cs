using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities.Entities
{
    public class MarketEntity : AEntityBase
    {

        public SelectionCollection Selections { get; set; }



        public MarketEntity(string parentName, string name)
            : base(parentName, name)
        {
        }

        public MarketEntity(string parentName, string name, DateTime? time)
            : base(parentName, name, time)
        {
        }

        public MarketEntity(string name)
            : base(name)
        {
        }
    }
}
