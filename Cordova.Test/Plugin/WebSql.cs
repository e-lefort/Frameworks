using Bridge.Cordova.Plugin.WebSQL;
using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordova.Test.Plugin
{
    public class WebSql
    {
        public void Run()
        {
            var dbSize = 5 * 1024 * 1024; // 5MB
            Database db = WebSQL.OpenDatabase("Todo", "", "Todo manager", dbSize, (database) =>
            {
                Console.Log("db successfully opened or created");
            });
            db.Transaction((tx) =>
            {
                tx.ExecuteSql("CREATE TABLE IF NOT EXISTS todo(ID INTEGER PRIMARY KEY ASC, todo TEXT, added_on TEXT)",
                    new object[] { }, OnSuccess, OnError);
                tx.ExecuteSql("INSERT INTO todo(todo, added_on) VALUES (?,{?)",
                    new object[] { "my todo item", new Date().ToUTCString() }, OnSuccess, OnError);
            });

            Global.Alert(db.Version);
        }

        public void OnSuccess(SqlTransaction transaction, SqlResultSet resultSet)
        {
            Console.Log("Query completed: " + JSON.Stringify(resultSet));
        }

        public void OnError(SqlTransaction transaction, SqlError error)
        {
            Console.Log("Query failed: " + error.Message);
        }
    }
}
