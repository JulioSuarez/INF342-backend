using Restaurante_CORE.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_CORE.Connection
{
    public interface IReadConexion
    {
        Task<IEnumerable<T>> ObtenerDatos<T>(SqlDynamicParameters sqlDynamicParameters, string query);
    }
}
