using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities.Entities
{
    public class EventEntity : AEntityBase
    {
        public string Venue { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Stop { get; set; }

        public MarketCollection Markets { get; set; }


        public EventEntity(string parentName, string name)
            : base(parentName, name)
        {
        }

        public EventEntity(string parentName, string name, DateTime? time)
            : base(parentName, name, time)
        {
        }

        public EventEntity(string name)
            : base(name)
        {
        }
    }
}
