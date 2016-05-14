using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities
{
    public class Sport : AEntityBase
    {
        public Collection<Competition> NextLevelCompetitions { get; set; }
        public Collection<Event> NextLevelEvents { get; set; }


        public Sport(string name)
            : base(name)
        {
            NextLevelCompetitions = new Collection<Competition>();
            NextLevelEvents = new Collection<Event>();

            ConstantsAndEnums.SportEnum result;
            if (!Enum.TryParse(name, true, out result))
            {
                throw new Exception("Invalid Sport");
            }
            Name = name;
        }




        public override AEntityBase Merge(AEntityBase objectToMergeIn)
        {
            throw new NotImplementedException();
        }
    }
}
