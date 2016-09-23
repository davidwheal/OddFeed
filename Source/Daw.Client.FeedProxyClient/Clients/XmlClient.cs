using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Daw.Client.WebServices.Clients
{
    public static class XmlClient
    {
        public static XmlDocument LoadXmlFromUrl (string url)
        {
            //System.Net.WebClient wc = new System.Net.WebClient();
            //byte[] raw = wc.DownloadData(url);

            //string webData = System.Text.Encoding.UTF8.GetString(raw);

            var result = new XmlDocument();
            result.Load(url);
            return result;
        }
    }
}
