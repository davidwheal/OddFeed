using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.Common.DataFormats
{
    public static class StringExtensionMethods
    {
        public static DateTime ToOddFeedDateTime(this string value)
        {
            return DateTime.ParseExact(value, "yyyyMMMMdd HHmmss", CultureInfo.InvariantCulture);
        }
    }
}
