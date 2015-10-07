using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *    https://github.com/MSOpenTech/cordova-plugin-websql
 */

namespace Bridge.Cordova.Plugin.WebSQL
{
    public partial class WebSQL
    {
        [Template("openDatabase({0},{1},{2},{3},{4})")]
        public static Database OpenDatabase(string name, string version, string displayname, int size, Action<Database> creationCallback)
        {
            return null;
        }

        [Template("openDatabase({0},{1},{2},{3})")]
        public static Database OpenDatabase(string name, string version, string displayname, int size)
        {
            return null;
        }
    }
}
