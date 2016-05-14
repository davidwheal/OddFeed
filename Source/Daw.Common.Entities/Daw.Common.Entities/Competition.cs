using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities
{
    public class Competition : AEntityBase
    {
        public Collection<Event> NextLevel { get; set; }

        public Competition(string parent, string name, DateTime? fromDate)
            : base(parent, name, fromDate)
        {
            NextLevel = new Collection<Event>();
            Name = name;
        }



        public override AEntityBase Merge(AEntityBase objectToMergeIn)
        {
            throw new NotImplementedException();
        }
    }
}
