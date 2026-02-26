using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utils
{
    internal class Logger
    {
        private static readonly string logFile = "system.log";

        public static void Log(string message)
        {
            File.AppendAllText(logFile,
                $"{DateTime.Now} : {message}{Environment.NewLine}");
        }
    }
}
