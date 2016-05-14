using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities
{
    public class Selection : AEntityBase
    {
        public ConcurrentDictionary<string,Price> NextLevel { get; set; }

        public Selection(string parent, string name)
            : base(parent, name)
        {
            NextLevel = new ConcurrentDictionary<string, Price>();
        }



        public override AEntityBase Merge(AEntityBase objectToMergeIn)
        {
            throw new NotImplementedException();
        }
    }
}
