using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Entities;

namespace Daw.Common.Entities.Comparer
{
    public class SportComparer : AComparer
    {
        /// <summary>
        /// Award points for a match, the better the match the more points are awarded
        /// </summary>
        /// <param name="unknownEntity"></param>
        /// <param name="entityList"></param>
        /// <returns></returns>
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
                if (m>currentBestMatchValue)
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
            return MinEquality;
        }
    }
}
