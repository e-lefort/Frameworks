using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Cordova.Plugin.Camera.Options.iOS
{
    [Ignore]
    public enum ArrowDir
    {
        ARROW_UP = 1,
        ARROW_DOWN = 2,
        ARROW_LEFT = 4,
        ARROW_RIGHT = 8,
        ARROW_ANY = 15,
    }

    [Ignore]
    [ObjectLiteral]
    public class CameraPopoverOptions
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ArrowDir ArrowDir { get; set; }
    }
}
