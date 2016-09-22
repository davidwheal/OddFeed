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
                    csv.WriteField("Name");
                    csv.WriteField("Date");
                    csv.NextRecord();
                    foreach (var evvent in kvp.Value.TheSport.TheEvents)
                    {
                        csv.WriteField(evvent.Value.Name);
                        csv.WriteField(evvent.Value.Date);
                        csv.NextRecord();

                    }
                }
                
            }


        }
    }
}
