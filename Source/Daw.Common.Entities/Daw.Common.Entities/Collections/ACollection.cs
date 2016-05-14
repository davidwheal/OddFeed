using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Entities.Collections
{
    public abstract class ACollection<T> where T : AEntityBase
    {

        public ConcurrentDictionary<string, T> Data { get; set; }


        public abstract void Merge(AEntityBase objectToMerge);



        /// <summary>
        /// At start of processinga feed call this and save the result
        /// </summary>
        /// <param name="feedKey"></param>
        /// <returns></returns>
        public List<string> StartLoading(string feedKey)
        {
            var remainingItems = new List<string>();
            // Get all of the entities in the collection that have my unique feedItemKey
            foreach (var item in Data)
            {
                if (item.Value.IsInFeed(feedKey))
                {
                    remainingItems.Add(item.Value.Key);
                }
            }
            return remainingItems;
        }

        /// <summary>
        /// At end of loading call this passing in the return from start loading
        /// </summary>
        public void EndLoading(string feedKey, List<string> remainingItems)
        {
            // Remove feedItemKey from those that have not been processed
            foreach (var key in remainingItems)
            {
                Data[key].RegisterNotInFeed(feedKey);
            }
        }

        public void ProcessItem(string feedItemKey, List<string> remainingItems)
        {
            remainingItems.Remove(feedItemKey);
        }


    }
}
