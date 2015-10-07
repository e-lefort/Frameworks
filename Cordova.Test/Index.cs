using Bridge.Cordova;
using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordova.Test
{
    public class Index : Application<Index>
    {
        public override void OnDeviceReady()
        {
            Global.Alert("OnDeviceReady");
        }

        public override void OnPause()
        {
            Global.Alert("OnPause");
        }

        public override void OnResume()
        {
            Global.Alert("OnResume");
        }

        public override void OnMenuButton()
        {
            Global.Alert("OnMenuButton");
        }

        public override void OnBackButton()
        {
            Global.Alert("OnBackButton");
        }

        public override void OnSearchButton()
        {
            Global.Alert("OnSearchButton");
        }

        public override void OnOnline()
        {
            Global.Alert("OnOnline");
        }

        public override void OnOffline()
        {
            Global.Alert("OnOffline");
        }
    }
}
