using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;
using DAW.Common.DataFormats;

namespace Daw.Common.Entities
{
    public class Event : AEntityBase
    {
        public Collection<Market> NextLevel { get; set; }
        public DateTime? Time { get; set; }
        public Location Place { get; set; }
        public DateTime BetTill { get; set; }
        public string Country { get; set; }

        public Event(string parent, string name, DateTime time)
            : base(parent, name, time)
        {
            NextLevel = new Collection<Market>();

        }


        public override AEntityBase Merge(AEntityBase objectToMergeIn)
        {
            throw new NotImplementedException();
        }
    }
}
