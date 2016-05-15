using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Mapper.Entities
{
    public class EventMap : AEntity
    {
        public DateTime? Date { get; set; }

        public string MappedName { get; set; }
        public DateTime? MappedDate { get; set; }


    }
}
