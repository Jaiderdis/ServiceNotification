using PaymentEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using TransaccionNotificationService.Entities;
using TransactionNotification.Bussines;

namespace TransaccionNotificationService
{
    public partial class Service1 : ServiceBase
    {
        bool band = false;
        DatosTransaccionEntities oDatosTransaccionEntities = new DatosTransaccionEntities();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        private void NotificationT_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
           

            
            EventLog log = new EventLog();
            log.Source = "Notificacion Transaccion";
            if (band)
            {
                return;
            }

            try
            {
                band = true;
                Connection con = new Connection();
                con.ExecStoredProcedure(oDatosTransaccionEntities);
                
                Notification oNotification = new Notification(oDatosTransaccionEntities);
                
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex.Message, EventLogEntryType.Information);
            }
            band = false;
        }
    }
}
