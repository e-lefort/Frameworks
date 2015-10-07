using Bridge.Cordova.Plugin.Camera.Options.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordova.Test.Plugin
{
    public class Camera
    {
        public void Run()
        {
            var option = new CameraPopoverOptions()
            {
                X = 5,
                Y = 45,
                Width = 1458
            };
        }
    }
}
