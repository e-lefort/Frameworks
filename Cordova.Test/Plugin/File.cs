using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordova.Test.Plugin
{
    public class File
    {
        public void Run()
        {
            Global.Alert(Bridge.Cordova.Plugin.File.File.ApplicationDirectory);
        }
    }
}
