using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PaymentEntities;

namespace TransaccionNotificationService.Entities
{

    public class Connection
    {
        
        public string ConnectionString { get; set; }

        public Connection()
        {
            this.ConnectionString = ConfigurationSettings.AppSettings["DB"].ToString();

        }

        public List<string> ExecStoedProcedure(DatosTransaccionEntities oDatosTransaccionEntities)
        {
            using (var connection = new SqlConnection(this.ConnectionString))
            {

                var results = connection.Query<TransaccionEntities>(
                 "AdelantoServiceNotify",
                   commandType: CommandType.StoredProcedure
                ).ToList();

            }

            return new List<string>();
        }

    }


}
