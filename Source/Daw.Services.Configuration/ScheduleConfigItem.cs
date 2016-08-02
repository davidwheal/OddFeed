using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Configuration
{
    public partial class ScheduleConfigItem
    {
        public string CalcKey()
        {
            return string.Format("{0}{1}{2}", sport, name, fixturesonly);
        }
        
    }
}
