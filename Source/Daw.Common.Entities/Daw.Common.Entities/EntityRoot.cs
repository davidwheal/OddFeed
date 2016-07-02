using System.Xml;
using Daw.Common.Entities.Collections;

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
        public EntityRoot(XmlDocument doc)
        {
            // TODO:
            //affiliateFeed.Items[0].sport;l
        }

    }
}
