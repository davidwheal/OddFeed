using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Mapper.Entities
{
    public abstract class AEntity
    {
        public enum MapPriorityEnum
        {
            Zero,
            Low,
            Medium,
            High
        }


        public string _id { get; set; }                 // Must be unique   
        public string Name { get; set; }                // Annotate the name and use as a secondary index - name + date            
        public MapPriorityEnum Priority { get; set; }
    }
}
