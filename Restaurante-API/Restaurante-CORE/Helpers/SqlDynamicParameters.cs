using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_CORE.Helpers
{
    public class SqlDynamicParameters
    {
        public List<SqlParameter> sqlParameters = new();
        public void Add(string parameterName, object attribute)
        {
            if (attribute is object)
            {
                var propertyType = attribute.GetType();
                var dbType = (propertyType.Name).GetSqlDbType();
                parameterName = parameterName.AddInput();
                SqlParameter sqlParameter = new();
                sqlParameter.ParameterName = parameterName;
                sqlParameter.DbType = dbType;
                sqlParameter.Value = attribute;
                sqlParameter.Direction = ParameterDirection.Input;

                sqlParameters.Add(sqlParameter);
            }
            else
            {
                throw new ArgumentNullException($"{parameterName} no tiene un valor");
            }
        }
    }
}
