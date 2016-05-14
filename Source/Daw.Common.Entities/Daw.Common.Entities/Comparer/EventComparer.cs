using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Entities;

namespace Daw.Common.Entities.Comparer
{
    public class EventComparer : AComparer
    {
        public override AEntityBase LocateBestMatch(AEntityBase unknownEntity, List<AEntityBase> entityList)
        {
            AEntityBase currentBestMatch;
            int currentBestMatchValue = MinEquality;
            foreach (var entity in entityList)
            {
                var m = Compare(unknownEntity, entity);
                if (m == MaxEquality)
                {
                    return entity;
                }
                if (m > currentBestMatchValue)
                {
                    currentBestMatch = entity;
                    currentBestMatchValue = m;
                }
            }


            return null;
        }

        public override int Compare(AEntityBase o1, AEntityBase o2)
        {
            if (base.Compare(o1, o2) == MaxEquality)
            {
                return MaxEquality;
            }
            var e1 = (EventEntity)o1;
            var e2 = (EventEntity)o2;
            // Date
            int match = MinEquality;
            if (ComparerHelper.CompareEventDates(e1.Start, e2.Start))
            {
                match += 20;
            }
            // Venue
            var matchStrength = ComparerHelper.FuzzyCompare(e1.Venue, e2.Venue);
            if (matchStrength == ComparerHelper.MatchStrengthEnum.Equal)
            {
                match += 20;
            }
            if (matchStrength == ComparerHelper.MatchStrengthEnum.Strong)
            {
                match += 10;
            }
            // Name
            // Compare with different ordering of words ??
            matchStrength = ComparerHelper.FuzzyCompare(e1.Name, e2.Name);
            if (matchStrength == ComparerHelper.MatchStrengthEnum.Equal)
            {
                match += 20;
            }
            if (matchStrength == ComparerHelper.MatchStrengthEnum.Strong)
            {
                match += 10;
            }
            return match;
            //if (e1.)
            // Date
            // Name
        }
    }
}
