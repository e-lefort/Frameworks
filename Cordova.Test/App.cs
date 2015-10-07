using Bridge;
using Bridge.Cordova;
using Bridge.Cordova.Plugin.Camera.Options.iOS;
using Bridge.Cordova.Plugin.WebSQL;
using Bridge.Html5;
using System;

namespace Cordova.Test
{
    public class App
    {
        [Ready]
        public static void Main()
        {
            Index index = Application<Index>.GetInstance();
            Application<Index>.AddEventListener(Events.SearchButton, index.OnSearchButton, false);
        }
    }
}