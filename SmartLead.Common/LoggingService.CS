using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLead.Common
{
    public static class LoggingService
    {
        /// <summary>
        /// /Logs actions
        /// </summary>
        /// <param name="action">Action to log</param>
        /// <returns></returns>
        public static string LogAction(string action)
        {
            var logtext = "Action: " + action;
            Console.WriteLine(logtext);
            return logtext;

        }
    }

}
