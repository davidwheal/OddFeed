using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Daw.Common.CoreData.ProcessorData;
using Daw.Services.WindowsService;

namespace Daw.Common.Exports
{
    public class CsvExport : IExport
    {
        public void Export(string fileName)
        {
            using (TextWriter writer = File.CreateText(fileName))
            {
                var csv = new CsvWriter(writer);
                foreach (var kvp in Engine.DataRoot)
                {
                    csv.WriteField(kvp.Value.TheSport.Name);
                    csv.WriteField(kvp.Value.TheFeedDefinition.name);
                    csv.WriteField(kvp.Value.TheFeedDefinition.fixturesonly);
                }
            }


        }
    }
}
