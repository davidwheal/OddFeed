using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;

namespace Daw.Common.Entities.Entities
{
    public class SelectionEntity : AEntityBase
    {

        public PriceCollection Prices { get; set; }



        public SelectionEntity(string parentName, string name)
            : base(parentName, name)
        {
        }

        public SelectionEntity(string parentName, string name, DateTime? time)
            : base(parentName, name, time)
        {
        }

        public SelectionEntity(string name)
            : base(name)
        {
        }
    }
}
