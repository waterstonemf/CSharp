using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ServiceWithoutInstallerDemo
{
    class EventLogUtil
    {
        public static void WriteLogEntry(string source, string logContent)
        {
            EventLog log = new EventLog();
            log.Source = source;

            log.WriteEntry(logContent);
        }
    }
}
