using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Daw.Common.Entities;
using DAW.Common.DataFormats;

namespace DAW.Adapters.AffiliateFeeds.Helpers
{
    public static class CoralHelper
    {
        /// <summary>
        /// 2016-01-23 17:00:00
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime? ParseDateTime(string date, string time)
        {
            DateTime result;
            var sum = date + " " + time;
            if (DateTime.TryParseExact(sum, "yyyy-MM-dd HH:mm:ss", new CultureInfo("en-GB"), DateTimeStyles.None, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


       
    }
}
