using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Daw.Common.Entities;
using Daw.Common.Xsl;
using Daw.Common.Xsl.Serialisation;
using DAW.Adapters.AffiliateFeeds.Helpers;
using DAW.Common.DataFormats;

namespace DAW.Adapters.AffiliateFeeds
{
    public class Coral : AFeedAdapter
    {
        //http://xmlfeeds.coral.co.uk/oxi/pub?template=getNextEvents&category=FOOTBALL&numMarkets=5&output=xml
        public override EntityRoot ReadFeed(string url, ConstantsAndEnums.SportEnum sport)
        {
            using (var client = new WebClient())
            {
                string result = client.DownloadString(url);
                var doc = new XmlDocument();
                doc.LoadXml(result);
                var transformedDoc = Transformer.Transform(doc, @"Transforms/Coral.xslt");
#if DEBUG
                transformedDoc.Save(@"c:\arse\transform.xml");
#endif
                var c = XmlDeserialiser.Terraform(transformedDoc.InnerXml);
            }

            return new EntityRoot();
        }
    }
}
