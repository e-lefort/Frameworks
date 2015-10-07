using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Cordova.Plugin.WebSQL
{
    [Ignore]
    [ObjectLiteral]
    public partial class SqlResultSet
    {
        public readonly long InsertId;
        public readonly long RowsAffected;
        public readonly SQLResultSetRowList Rows;
    }

    [Ignore]
    [ObjectLiteral]
    public partial class SQLResultSetRowList
    {
        public readonly ulong Length;
        public Item Item;
    }

    [Ignore]
    [ObjectLiteral]
    public partial class Item
    {
        public int Index { get; }
    }
}