using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EventLogDemo
{
    class Demo2
    {
        public void test()
        {
            EventLog m_EventLog = new EventLog("");
            m_EventLog.Source = "EventLogDemo_Demo2";
            m_EventLog.WriteEntry("Any log information",
                EventLogEntryType.FailureAudit);
        }
    }
}
