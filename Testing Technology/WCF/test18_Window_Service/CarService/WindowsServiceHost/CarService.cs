using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace WindowsServiceHost
{
    public partial class CarService : ServiceBase
    {
        private ServiceHost _host;
        public CarService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _host = new ServiceHost(typeof(CarService));
            _host.Open();
        }

        protected override void OnStop()
        {
            if(_host!=null)
            {
                _host.Close();
            }
        }
    }
}
