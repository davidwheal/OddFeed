using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Mapper.Entities
{
    public class MarketMap : AEntity
    {
        public string MappedName { get; set; }
        public string AssociatedParent { get; set; }
    }
}
