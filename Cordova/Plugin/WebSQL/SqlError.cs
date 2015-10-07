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
    public partial class SqlError
    {
        public ushort Code { get; }
        public string Message { get; }
    }

    [Ignore]
    public partial class SqlError
    {
        public ushort UNKNOWN_ERR { get; }
        public ushort DATABASE_ERR { get; }
        public ushort VERSION_ERR { get; }
        public ushort TOO_LARGE_ERR { get; }
        public ushort QUOTA_ERR { get; }
        public ushort SYNTAX_ERR { get; }
        public ushort CONSTRAINT_ERR { get; }
        public ushort TIMEOUT_ERR { get; }
    }
}
