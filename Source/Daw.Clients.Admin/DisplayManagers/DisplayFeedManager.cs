using Daw.Clients.Admin.DataGridHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daw.Clients.Admin.Managers
{
    public static class DisplayFeedManager
    {
        public static bool CanWeShowEventButton (DataGridView dgvFeeds, out string eventKey)
        {
            List<string> list;
            if (DataGridViewHelper.GetSelectedDetail(1, dgvFeeds, 0, out list))
            {
                eventKey = list[0];
                return true;
            }
            eventKey = string.Empty;
            return false;
        }
    }
}
