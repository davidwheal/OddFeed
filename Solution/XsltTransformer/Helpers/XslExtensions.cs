using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsltTransformer.Helpers
{
    public class XslExtensions
    {
        public static string CurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public static string CurrentDate()
        {
            return DateTime.Now.ToString("yyy MMMM dd");
        }

    }
}
