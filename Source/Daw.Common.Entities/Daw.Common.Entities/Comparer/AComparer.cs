using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Entities.Comparer
{
    public abstract class AComparer
    {
        public const int MaxEquality = 100;
        public const int MinEquality = 0;

        public abstract AEntityBase LocateBestMatch(AEntityBase o1, List<AEntityBase> o2);

      

        public virtual int Compare(AEntityBase o1, AEntityBase o2)
        {
            if (o1.Name == o2.Name)
            {
                return MaxEquality;
            }
            return MinEquality;
        }


        

    }
}
