using System.IO;
using CsvHelper;
using Daw.Common.Exports;

namespace Daw.Services.WindowsService.Exports
{
    public class CsvExport : IExport
    {
        public void Export(string fileName)
        {
            using (TextWriter writer = File.CreateText(fileName))
            {
                var csv = new CsvWriter(writer);
                csv.WriteField("Sport");
                csv.WriteField("Feed");
                csv.WriteField("Fixtures Only?");
                csv.NextRecord();
                foreach (var kvp in Engine.DataRoot)
                {
                    csv.WriteField(kvp.Value.TheSport.Name);
                    csv.WriteField(kvp.Value.TheFeedDefinition.name);
                    csv.WriteField(kvp.Value.TheFeedDefinition.fixturesonly);
                    csv.NextRecord();
                }
                
            }


        }
    }
}
