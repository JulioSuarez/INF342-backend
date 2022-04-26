using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_CORE.Connection
{
    public class ObtenerConexion : IObtenerConexion
    {
        public SqlConnection ObtenerConexionSql()
        {
            const string conectionString = "";
               return new SqlConnection(conectionString);
        }
    }
}
