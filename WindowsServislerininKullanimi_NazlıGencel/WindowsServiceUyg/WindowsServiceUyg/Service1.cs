using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceUyg
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        private System.Diagnostics.EventLog eventLog;
        protected override void OnStart(string[] args)
        {
            eventLog = new EventLog();
            if(!System.Diagnostics.EventLog.SourceExists("Deneme"))
            {
                System.Diagnostics.EventLog.CreateEventSource("Deneme", "Örnek Log");
            }
            eventLog.Source = "Deneme";
            eventLog.WriteEntry("Servis Başlatıldı", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
        }
    }
}
