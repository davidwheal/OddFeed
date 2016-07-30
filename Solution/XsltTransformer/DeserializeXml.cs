using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using log4net;
using Daw.Common.Core.Data;

namespace XsltTransformer
{
    public static class DeserializeXml
    {
        static XmlSerializer serializer = new XmlSerializer(typeof(oddfeed));
        public static oddfeed Deserialize(XmlDocument doc, ILog logger)
        {
            try
            {
                var xml = doc.InnerXml;
                //if (xml.StartsWith("<?"))
                //{
                //    var pos = xml.IndexOf("?>");
                //    xml = xml.Substring(pos + 2, xml.Length - (pos + 2));
                //}
                XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
                XmlSerializer ser = new XmlSerializer(typeof(oddfeed));
                return (oddfeed)ser.Deserialize(reader);
            }
            catch (Exception ex)
            {
                logger.Fatal(string.Format("Failed deserialize for {0}", ex.Message));
                return null;
            }


        }
    }
}
