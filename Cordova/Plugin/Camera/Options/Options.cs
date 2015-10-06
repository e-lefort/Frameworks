using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Cordova.Plugin.Camera.Options
{
    public enum CameraDirection
    {
        FRONT = 0,
        BACK = 1,
    }

    public enum MediaType
    {
        PICTURE = 0,
        VIDEO = 1,
        ALLMEDIA = 2,
    }

    public enum EncodingType
    {
        JPEG = 0,
        PNG = 1,
    }

    public enum SourceType
    {
        PHOTOLIBRARY = 0,
        CAMERA = 1,
        SAVEDPHOTOALBUM = 2,
    }

    public enum DestinationType
    {
        DATA_URL = 0,
        FILE_URI = 1,
        NATIVE_URI = 2,
    }
}
