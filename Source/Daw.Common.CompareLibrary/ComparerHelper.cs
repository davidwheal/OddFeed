using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Entities.Comparer
{
    public static class ComparerHelper
    {
        public static bool CompareEventDates (DateTime? d1, DateTime? d2)
        {
            if (d1==null || d2==null)
            {
                // Unknown dates
                return false;
            }
            return d1 == d2;
        }

        public static int CompareVenues (string v1, string v2)
        {
            var fs = new FuzzyString();
        }
    }
}
