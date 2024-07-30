using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace logger
{
    internal static class logging
    {
        public static void WriteLog() 
        {
            string logPath = ConfigurationManager.AppSettings["path_log"];
            
        }    
    }
}
