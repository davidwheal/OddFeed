using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Entities;

namespace Daw.Common.Entities.Collections
{
    public class PriceCollection : ACollection<PriceEntity>
    {
        public override void Merge(AEntityBase objectToMerge)
        {
            throw new NotImplementedException();
        }
    }
}
