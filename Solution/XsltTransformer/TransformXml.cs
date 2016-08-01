using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;
using Daw.Common.CoreData;
using Daw.Common.CoreData.IncomingData;
using IncomingFeedQueue;
using log4net;
using Microsoft.SqlServer.Server;
using XsltTransformer.Helpers;

namespace XsltTransformer
{
    public static class TransformXml
    {
        static readonly object lockFlag = new object();

        

        public static XmlDocument XsltTransform(QueueItem<XmlPacket> packet, ILog logger)
        {
#if DEBUG
            Directory.CreateDirectory("Feeds");
            packet.Data.Xml.Save(string.Format(@"Feeds/{0}_{1}_{2}.xml", packet.Data.ConfigItem.bookie,
                packet.Data.ConfigItem.sport, packet.Data.ConfigItem.name));
#endif
            var sb = new MemoryStream();
            try
            {
                var xslArgs = new XsltArgumentList();
                xslArgs.AddExtensionObject("urn:OddsFeedXslExtensions", new XslExtensions(packet.Data.ConfigItem));
                var xsltSettings = new XsltSettings(false, true);
                XslCompiledTransform myXslTrans;

                lock (lockFlag)
                {
                    myXslTrans = new XslCompiledTransform();
                    myXslTrans.Load(@"Transforms/" + packet.Data.ConfigItem.transform, xsltSettings, new XmlUrlResolver());
                }

                // Set up the encoding I want
                var writerSettings = new XmlWriterSettings()
                {
                    Encoding = Encoding.Unicode,
                    Indent = true
                };
                var results = XmlWriter.Create(sb, writerSettings);
                myXslTrans.Transform(packet.Data.Xml, xslArgs, results);
                sb.Position = 0;
                var sr = new StreamReader(sb);
                var x = new XmlDocument();
                x.LoadXml(sr.ReadToEnd());
#if DEBUG
                Directory.CreateDirectory("TransformOutputs");
                x.Save(string.Format(@"TransformOutputs/{0}_{1}_{2}.xml", packet.Data.ConfigItem.bookie,
                packet.Data.ConfigItem.sport, packet.Data.ConfigItem.name));
#endif
                results.Close();
                return x;


            }
            catch (Exception ex)
            {
                logger.Fatal("TransformXml" + packet.Data.ConfigItem.transform, ex);
            }
            finally
            {
                sb.Dispose();
            }
            return null;
        }
    }
}
