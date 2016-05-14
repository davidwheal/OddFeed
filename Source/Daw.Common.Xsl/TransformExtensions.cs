using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Daw.Common.Entities;

namespace Daw.Common.Xsl
{
    public class TransformExtensions
    {
        private const string SplitTeamNamesOutPattern = @"\s+(v|versus)\s+";
        private const string HomeTeam = "[Home]";
        private const string AwayTeam = "[Away]";

        public static string ExtractSport(string sport)
        {
            if (sport.ToUpper().Contains("FOOTBALL"))
                return ConstantsAndEnums.SportEnum.Football.ToString();
            throw new Exception(string.Format("Unknown Sport {0}", sport));
        }

        public static bool GenericFlag(string flag)
        {
            var ucFlag = flag.ToUpper();
            if (ucFlag == "N" || ucFlag == "FALSE" || ucFlag == "0" || string.IsNullOrEmpty(ucFlag))
                return false;
            return true;
        }

        public static string ExtractTeamNames(string name)
        {
            var split = Regex.Split(name, SplitTeamNamesOutPattern, RegexOptions.IgnoreCase);
            if (split.Length == 3)
            {
                return split[0] + " v " + split[2];
            }
            return name;
        }

        public static string SubstituteTeamNames(string name, string eventName)
        {
            var split = Regex.Split(eventName, SplitTeamNamesOutPattern, RegexOptions.IgnoreCase);
            if (split.Length == 3)
            {
                name = name.Replace(split[0], HomeTeam);
                name = name.Replace(split[2], AwayTeam);
            }
            return name;
        }

        public static DateTime CompileCoralEventTime(string date, string time)
        {
            DateTime result;
            var sum = date + " " + time;
            if (DateTime.TryParseExact(sum, "yyyy-MM-dd HH:mm:ss", new CultureInfo("en-GB"), DateTimeStyles.None, out result))
            {
                return result;
            }
            else
            {
                return DateTime.MinValue;
            }
        }
    }
}
