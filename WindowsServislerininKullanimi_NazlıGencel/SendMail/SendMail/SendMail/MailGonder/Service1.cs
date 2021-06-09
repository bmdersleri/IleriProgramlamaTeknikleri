using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace MailGonder
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if(timer==null)
            {
                timer = new Timer();
            }
            timer.Interval = 60000;
            timer.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed (object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            MailGonder();
            timer.Start();

        }

        protected override void OnStop()
        {
        }
        public void MailGonder()
        {
            //mail gönderme  kodları 
        }
    }
}
