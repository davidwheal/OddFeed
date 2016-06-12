using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomingFeedQueue
{
    public class QueueItem
    {
        public string Source { get; set; }
        public object Data { get; set; }
        public DateTime Time { get; set; }

        public QueueItem(string source, DateTime time, object data)
        {
            Source = source;
            Time = time;
            Data = data;
        }
    }
}
