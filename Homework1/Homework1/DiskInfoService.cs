using DiskInfoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public partial class DiskInfoService : ServiceBase
    {
        private ServiceHost _diskInfoHost;

        public DiskInfoService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_diskInfoHost != null)
            {
                _diskInfoHost.Close();
            }

            // Create the host and specify a URL for an HTTP binding.
            _diskInfoHost = new ServiceHost(typeof(DiskInfo),
                new Uri("http://localhost:8081/DiskInfoLibrary"));
            _diskInfoHost.AddDefaultEndpoints();

            // Open the host.
            _diskInfoHost.Open();
        }

        protected override void OnStop()
        {
            if (_diskInfoHost != null)
                _diskInfoHost.Close();
        }
    }
}
