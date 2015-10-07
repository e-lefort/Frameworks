using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Cordova.Plugin.WebSQL
{
    public partial class SqlTransaction
    {
        [Template("executeSql({0},{1},{2},{3})")]
        public void ExecuteSql(string sql, object[] arguments, Action<SqlTransaction, SqlResultSet> successCallback, Action<SqlTransaction, SqlError> errorCallback)
        {

        }
    }
}
