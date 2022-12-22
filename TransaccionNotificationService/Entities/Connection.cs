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

        public List<string> ExecStoredProcedure(DatosTransaccionEntities oDatosTransaccionEntities)
        {
            TransaccionEntities Te = new TransaccionEntities();
            
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                // Ejecutar el procedimiento almacenado
                var results = connection.Query<TransaccionEntities>(
                    "SP_TransaccionesXNotificar",
                    new { param1 = "value1", param2 = "value2" },
                    commandType: CommandType.StoredProcedure
                );

                // Iterar a través de los resultados y hacer algo con ellos
                foreach (var result in results)
                {
                    // Trabajar con el objeto result aquí
                }
            }


            return data;
        }


         

    }


}
