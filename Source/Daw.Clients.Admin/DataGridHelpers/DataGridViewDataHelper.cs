using Daw.Common.CoreData.ProcessorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daw.Clients.Admin.DataGridHelpers
{
    public static class DataGridViewDataHelper
    {
        public static void DisplayFeed (Dictionary<string,BaseFeedDto> list, DataGridView dgv)
        {
            var source = new BindingSource();
            source.DataSource = list.Select(o => new { Key = o.Key, name = o.Value.FeedName, Sport = o.Value.Sport, Fixtures = o.Value.FixturesOnly });
            dgv.DataSource = source;
        }
    }
}
