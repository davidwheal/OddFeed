using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MongoDB.Bson.IO;

namespace Daw.Common.Mapper.Entities
{
    /// <summary>
    /// One of these for each feed element, so the Regex has to
    /// work for all incoming names
    /// </summary>
    public abstract class AEntity
    {
    
        /// <summary>
        /// Use a guid for each map
        /// </summary>
        public string _id { get; set; }                  
         
       

        /// <summary>
        /// This is the name I want to see in the feed
        /// </summary>
        public string MappedName { get; set; }

        /// <summary>
        /// The known date of the event
        /// If known this will be used in the feed to replace the data incoming
        /// </summary>
        public DateTime? MappedDate { get; set; }

        /// <summary>
        /// If this Regex returns success against the incoming name then
        /// use this map
        /// </summary>
        public string RegexPattern { get; set; }

        /// <summary>
        /// Success or fail determines use of this map
        /// </summary>
        /// <param name="incomingName"></param>
        /// <returns></returns>
        public bool IsMatch(string incomingName)
        {
            var reg = new Regex(RegexPattern);
            return reg.IsMatch(incomingName);
        }

    }
}
