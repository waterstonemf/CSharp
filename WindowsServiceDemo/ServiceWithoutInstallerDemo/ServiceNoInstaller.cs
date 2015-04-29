using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWithoutInstallerDemo
{
    public partial class ServiceNoInstaller : ServiceBase
    {
        public ServiceNoInstaller()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLogUtil.WriteLogEntry("ServiceWithoutInstallerDemo_ServiceNoInstaller", "OnStart");
        }

        protected override void OnStop()
        {
            EventLogUtil.WriteLogEntry("ServiceWithoutInstallerDemo_ServiceNoInstaller", "OnStop");
        }
    }
}
