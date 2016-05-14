using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;
using GeneratedClass;

namespace Daw.Common.Entities
{
    public class EntityRoot
    {
        public SportCollection NextLevel { get; set; }

        public EntityRoot()
        {
            NextLevel = new SportCollection();
        }

        /// <summary>
        /// Creates a root fom the contents of a feed
        /// </summary>
        /// <param name="affiliateFeed"></param>
        public EntityRoot(terraformed affiliateFeed)
        {
            // TODO:
            //affiliateFeed.Items[0].sport;l
        }

    }
}
