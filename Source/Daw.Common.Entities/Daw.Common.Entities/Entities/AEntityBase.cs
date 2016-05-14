using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities.Collections;
using DAW.Common.DataFormats;

namespace Daw.Common.Entities
{
    public abstract class AEntityBase
    {


        public string Name { get; set; }
        public string Key { get; set; }
        public List<string> UniqueIdentifiers { get; set; }

    
        public void RegisterInFeed(string feedKey)
        {
            UniqueIdentifiers.Add(feedKey);
        }

        public void RegisterNotInFeed(string feedKey)
        {
            UniqueIdentifiers.Remove(feedKey);
        }

        public bool IsInAnyFeed()
        {
            return UniqueIdentifiers.Count > 0;
        }

        public bool IsInFeed(string feedKey)
        {
            return UniqueIdentifiers.Contains(feedKey);
        }


        protected AEntityBase(string parentName, string name)
        {
            Key = parentName + "|" + name;
            UniqueIdentifiers = new List<string>();
        }

        protected AEntityBase(string parentName, string name, DateTime? time)
        {
            if (time == null)
            {
                Key = parentName + "|" + name + "|" + DateTime.MinValue.ToOddFeedString();

            }
            else
            {
                Key = parentName + "|" + name + "|" + ((DateTime)time).ToOddFeedString();

            }
            UniqueIdentifiers = new List<string>();
        }

        protected AEntityBase(string name)
        {
            Key = name;
            UniqueIdentifiers = new List<string>();
        }

    }
}
