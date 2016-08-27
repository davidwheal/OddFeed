using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daw.Common.CoreData.ProcessorData;

namespace Daw.Common.Exports
{
    interface IExport
    {
        void Export(string fileName);
    }
}
