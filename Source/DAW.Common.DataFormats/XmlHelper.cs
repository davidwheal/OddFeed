using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAW.Common.DataFormats
{
    public static class XmlHelper
    {
        public static string GetAttributeString(XmlNode n, string name, string defValue)
        {
            if (n.Attributes != null)
            {
                var res = n.Attributes.GetNamedItem(name);
                if (res != null)
                {
                    return res.Value;
                }
            }
            return defValue;
        }

        public static int GetAttributeInt(XmlNode n, string name, int defValue)
        {
            int res;
            if (int.TryParse(GetAttributeString(n, name, defValue.ToString()), out res))
            {
                return res;
            }
            return defValue;
        }
    }
}
