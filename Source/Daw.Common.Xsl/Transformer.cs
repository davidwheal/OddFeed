using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace Daw.Common.Xsl
{
    public static class Transformer
    {
        private static readonly ConcurrentDictionary<string, XslCompiledTransform> TransformsCache = new ConcurrentDictionary<string, XslCompiledTransform>();
        static readonly object LockFlag = new object();

        public static XmlDocument Transform(XmlDocument incoming, string xsltFilename)
        {
            var sb = new MemoryStream();
            try
            {
                var obj = new TransformExtensions();
                var xslArgs = new XsltArgumentList();
                xslArgs.AddExtensionObject("urn:Extensions", obj);
                var xsltSettings = new XsltSettings(false, true);
                XslCompiledTransform myXslTrans;
                lock (LockFlag)
                {
                    if (TransformsCache.TryGetValue(xsltFilename, out myXslTrans))
                    {
                    }
                    else
                    {

                        myXslTrans = new XslCompiledTransform();
                        myXslTrans.Load(xsltFilename, xsltSettings, new XmlUrlResolver());
                        TransformsCache.TryAdd(xsltFilename, myXslTrans);
                    }

                }


                var writerSettings = new XmlWriterSettings()
                {
                    Encoding = Encoding.Unicode,
                    Indent = true
                };
                var results = XmlWriter.Create(sb, writerSettings);
                myXslTrans.Transform(incoming, xslArgs, results);
                sb.Position = 0;
                var sr = new StreamReader(sb);
                var x = new XmlDocument();
                x.LoadXml(sr.ReadToEnd());
                results.Close();
                return x;


            }
            catch (Exception ex)
            {
                // TODO:Logging
            }
            finally
            {
                sb.Dispose();
            }
            return null;
        }

    }
}
