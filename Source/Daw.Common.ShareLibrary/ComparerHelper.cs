using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyString;

namespace Daw.Common.Entities.Comparer
{
    public static class ComparerHelper
    {
        public enum MatchStrengthEnum
        {
            Equal,
            Strong,
            Not
        }


        public static bool CompareEventDates(DateTime? d1, DateTime? d2)
        {
            if (d1 == null || d2 == null)
            {
                // Unknown dates
                return false;
            }
            return d1 == d2;
        }



        /// <summary>
        /// Returns true if the words are fairly similar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static MatchStrengthEnum FuzzyCompareWords(string s1, string s2)
        {
            if (s1 == s2)
                return MatchStrengthEnum.Equal;

            var options = new List<FuzzyStringComparisonOptions>();
            options.Add(FuzzyStringComparisonOptions.UseJaccardDistance);
            options.Add(FuzzyStringComparisonOptions.UseNormalizedLevenshteinDistance);
            options.Add(FuzzyStringComparisonOptions.UseOverlapCoefficient);
            options.Add(FuzzyStringComparisonOptions.UseLongestCommonSubsequence);
            options.Add(FuzzyStringComparisonOptions.CaseSensitive);
            var ret = s1.ApproximatelyEquals(s2, options, FuzzyStringComparisonTolerance.Strong);
            if (ret) return MatchStrengthEnum.Strong; else return MatchStrengthEnum.Not;
        }

        public static MatchStrengthEnum FuzzyCompare(string s1, string s2)
        {
            s1 = System.Text.RegularExpressions.Regex.Replace(s1, "[(),.]", " ");
            s2 = System.Text.RegularExpressions.Regex.Replace(s2, "[(),.]", " ");

            // to split the text with SPACE delimiter
            var splittedS1 = s1.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
            var splittedS2 = s2.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
            var matchCount = 0;
            bool notExact = false;
            foreach (var token in splittedS1)
            {
                foreach (var token1 in splittedS2)
                {
                    var match = FuzzyCompareWords(token, token1);
                    if (match == MatchStrengthEnum.Strong || match == MatchStrengthEnum.Equal)
                    {
                        matchCount++;
                    }
                    if (match == MatchStrengthEnum.Strong)
                    {
                        notExact = true;
                    }
                }
            }
            if (matchCount >= Math.Min(splittedS1.Length, splittedS2.Length))
            {
                return (notExact) ? MatchStrengthEnum.Strong : MatchStrengthEnum.Equal;
            }
            return MatchStrengthEnum.Not;
        }
    }
}
