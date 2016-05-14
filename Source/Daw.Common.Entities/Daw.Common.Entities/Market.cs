using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities
{
    public class Market : AEntityBase
    {
        public Collection<Selection> NextLevel { get; set; }

        public Market(string parent, string name)
            : base(parent, name)
        {
            NextLevel = new Collection<Selection>();
        }



        public override AEntityBase Merge(AEntityBase objectToMergeIn)
        {
            throw new NotImplementedException();
        }
    }
}
