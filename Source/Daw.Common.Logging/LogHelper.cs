using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daw.Common.Logging
{
    public static class LogHelper
    {
        public static void LogException(ILog logger, string caption, Exception ex)
        {
            logger.Fatal(caption);
            logger.Fatal(ex.StackTrace);
            logger.Fatal(ex.Message);
            while (ex.InnerException != null)
            {
                logger.Fatal(ex.InnerException.Message);
                ex = ex.InnerException;
            }

        }
    }
}
