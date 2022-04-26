using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_CORE.Connection
{
    public interface IObtenerConexion
    {
        SqlConnection ObtenerConexionSql(); 
    }
}
