﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceDemo
{
    partial class Service2 : ServiceBase
    {
        public Service2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLogUtil.WriteLogEntry("WindowsServiceDemo_Service2", "OnStart");
        }

        protected override void OnStop()
        {
            EventLogUtil.WriteLogEntry("WindowsServiceDemo_Service2", "OnStop");
        }
    }
}
