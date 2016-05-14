using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.Entities;

namespace DAW.Adapters.AffiliateFeeds
{
    public abstract class AFeedAdapter
    {
        public abstract EntityRoot ReadFeed(string url, ConstantsAndEnums.SportEnum sport);

    }
}
