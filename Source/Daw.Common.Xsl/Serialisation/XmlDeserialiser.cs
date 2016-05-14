using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Daw.Common.Xsl.Serialisation
{
    public static class XmlDeserialiser
    {
        public static terraformed Terraform(string xmlSTring)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(terraformed));
                using (XmlReader reader = XmlReader.Create(new StringReader(xmlSTring)))
                {
                    return (terraformed)serializer.Deserialize(reader);
                }

            }
            catch (Exception ex)
            {
                //TODO:Log this
            }
            return null;
        }
    }
}
