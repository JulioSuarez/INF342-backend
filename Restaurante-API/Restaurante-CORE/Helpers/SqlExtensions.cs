using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_CORE.Helpers
{
    public static class SqlExtensions
    {
        public static DbType GetSqlDbType(this string PropertyTypeName)
        {
            return PropertyTypeName switch
            {
                "String" => DbType.String,
                "Int32" => DbType.Int32,
                "Double" => DbType.Double,
                "DateTime" => DbType.Date,
                "Boolean" => DbType.Int32,
                "Identificador" => DbType.Int32,
                _ => throw new ArgumentNullException(PropertyTypeName),
            };
        }
    }
}
