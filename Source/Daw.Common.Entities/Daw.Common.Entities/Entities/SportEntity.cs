using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities.Entities
{
    public class SportEntity : AEntityBase
    {

        public EventCollection Events { get; set; }


        public void Init()
        {
            Events = new EventCollection();

        }


        public SportEntity(string parentName, string name)
            : base(parentName, name)
        {
            Init();
        }

        public SportEntity(string parentName, string name, DateTime? time)
            : base(parentName, name, time)
        {
            Init();
        }

        public SportEntity(string name)
            : base(name)
        {
            Init();
        }
    }
}
