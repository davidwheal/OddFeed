using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using Daw.Common.Configuration;


namespace XsltTransformer.Helpers
{
    /// <summary>
    /// All dates and times are to be UK
    /// </summary>
    public partial class XslExtensions
    {
        public ScheduleConfigItem MyConfig = null;

        public XslExtensions(ScheduleConfigItem config)
        {
            MyConfig = config;
        }

        public static XmlDocument MarketSubstitutions = null;
        public static XmlDocument EventSubstitutions = null;

        public const string StandardDateTimeFormat = "yyyy-MMM-dd HH:mm";

        public static string CurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public static string CurrentDate()
        {
            return DateTime.Now.ToString("yyyy MMMM dd");
        }


        public string GetSport()
        {
            return MyConfig.sport;
        }

        public string GetFeedName()
        {
            return MyConfig.name;
        }

        public string GetFeedType()
        {
            return MyConfig.feedtype;
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


        public static string ParseBet365EventDate(string datetime)
        {
            try
            {
                // e.g DD/MM/YY HH:MM:SS
                if (String.IsNullOrEmpty(datetime))
                {
                    return "<none>";
                }
                //
                return DateTime.ParseExact(datetime, "dd/MM/yy HH:mm:ss", CultureInfo.InvariantCulture).ToString(StandardDateTimeFormat);
            }
            catch (Exception)
            {
                return "UNKNOWN:" + datetime;
            }

        }

        public string DoEventSubstitutions(string sportAsString, string value)
        {
            ConstantsAndEnums.SportEnum sport;
            if (!Enum.TryParse(sportAsString, true, out sport))
            {
                return "Bad sport enum";
            }
            if (EventSubstitutions == null)
            {
                EventSubstitutions = new XmlDocument();
                EventSubstitutions.Load(@"Substitutions/EventSubstitutions.xml");
            }
            value = DoSubstitutions(sport, value, EventSubstitutions, " ");
            return value;
        }

        public string DoMarketSubstitutions(string sportAsString, string value)
        {
            ConstantsAndEnums.SportEnum sport;
            if (!Enum.TryParse(sportAsString, true, out sport))
            {
                return "Bad sport enum";
            }
            if (MarketSubstitutions == null)
            {
                MarketSubstitutions = new XmlDocument();
                MarketSubstitutions.Load(@"Substitutions/MarketSubstitutions.xml");
            }
            value = DoSubstitutions(sport, value, EventSubstitutions, " ");
            return value;
        }

        private static string DoSubstitutions(ConstantsAndEnums.SportEnum sport, string value, XmlDocument dictionary, string separators)
        {
            var matches = Regex.Matches(value, @"\w+[^\s]*\w+|\w");


            foreach (Match match in matches)
            {
                var word = match.Value;
                try
                {
                    var n = dictionary.SelectSingleNode(string.Format(@"substitutions/{1}/{0}", word, sport.ToString()));
                    if (n != null)
                    {
                        value = value.Replace(match.Value, n.InnerText);
                    }
                }
                catch (XPathException)
                {
                    // Bad format for word, so ignore it

                }

            }
            return value;
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
