using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsltTransformer.Helpers
{
    /// <summary>
    /// All dates and times are to be UK
    /// </summary>
    public class XslExtensions
    {
        public const string StandardDateTimeFormat = "yyyy-MMM-dd HH:mm";

        public static string CurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public static string CurrentDate()
        {
            return DateTime.Now.ToString("yyyy MMMM dd");
        }

        public static string ParseBetfredEventDate(string datetime)
        {
            try
            {
                // e.g 201610391415
                if (String.IsNullOrEmpty(datetime))
                {
                    return "<none>";
                }
                //
                return DateTime.ParseExact(datetime, "yyyyMMddHHmm", CultureInfo.InvariantCulture).ToString(StandardDateTimeFormat);
            }
            catch (Exception)
            {
                return "UNKNOWN:" + datetime;
            }

        }

        /// <summary>
        /// Translate a true false value into a standard representation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetFlag(string value)
        {
            switch (value.ToUpper())
            {
                case "1":
                    return "t";
                case "0":
                    return "f";
                case "TRUE":
                    return "t";
                case "FALSE":
                    return "f";
                default:
                    return value;
            }
        }
    }
}
