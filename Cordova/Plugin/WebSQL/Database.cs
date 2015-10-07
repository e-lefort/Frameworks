using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Cordova.Plugin.WebSQL
{
    public partial class Database
    {
        public readonly string Name;
        public readonly string Version;
        public readonly string DisplayName;
        public readonly int Size;

        public Database(string name, string version, string displayName, int size)
        {
            this.Name = name;
            this.Version = version;
            this.DisplayName = displayName;
            this.Size = size;
        }
    }
    public partial class Database
    {
        [Template("transaction({0},{1},{2})")]
        public void Transaction(Action<SqlTransaction> transaction, Action<SqlError> errorCallback, Delegate successCallback)
        {
        }

        [Template("transaction({0},{1})")]
        public void Transaction(Action<SqlTransaction> transaction, Action<SqlError> errorCallback)
        {
        }

        [Template("transaction({0})")]
        public void Transaction(Action<SqlTransaction> transaction)
        {
        }

        [Template("readTransaction({0},{1},{2})")]
        public void ReadTransaction(Action<SqlTransaction> transaction, Action<SqlError> errorCallback, Delegate successCallback)
        {
        }

        [Template("readTransaction({0},{1})")]
        public void ReadTransaction(Action<SqlTransaction> transaction, Action<SqlError> errorCallback)
        {
        }

        [Template("readTransaction({0})")]
        public void ReadTransaction(Action<SqlTransaction> transaction)
        {
        }
    }
}
