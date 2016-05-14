using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.Common.DataFormats
{
    public static class DateTimeExtensionMethods
    {
        public static string ToOddFeedString(this DateTime value)
        {
            return string.Format("{0:yyyyMMMMdd HHmmss}", value);
        }
    }
}
