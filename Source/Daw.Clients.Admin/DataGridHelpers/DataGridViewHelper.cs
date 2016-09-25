using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daw.Clients.Admin.DataGridHelpers
{
    public static class DataGridViewHelper
    {
        public static bool GetSelectedDetail(int numRequiredRows, DataGridView control, int requiredCellNumber, out List<string> cellValues)
        {
            cellValues = null;
            var rows = control.SelectedRows;
            if (rows.Count != numRequiredRows)
            {
                return false;
            }
            cellValues = new List<string>();
            for (int i = 0; i < numRequiredRows; i++)
            {
                cellValues.Add(rows[i].Cells[requiredCellNumber].Value.ToString());
            }
            return true;
        }
    }
}
