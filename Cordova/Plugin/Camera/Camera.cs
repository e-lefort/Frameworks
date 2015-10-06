using Bridge;
using Bridge.Cordova.Plugin.Camera.Options;
using Bridge.Cordova.Plugin.Camera.Options.iOS;
using System;

namespace Bridge.Cordova.Plugin.Camera
{
    public class CameraOptions
    {
        public int? Quality { get; set; } = 50;
        public DestinationType DestinationType { get; set; } = DestinationType.FILE_URI;
        public SourceType SourceType { get; set; } = SourceType.CAMERA;
        public bool? AllowEdit { get; set; }
        public EncodingType EncodingType { get; set; } = EncodingType.JPEG;
        public int? TargetWidth { get; set; }
        public int? TargetHeight { get; set; }
        public MediaType MediaType { get; set; } = MediaType.PICTURE;
        public bool? CorrectOrientation { get; set; }
        public bool? SaveToPhotoAlbum { get; set; }
        public CameraDirection CameraDirection { get; set; } = CameraDirection.BACK;
        public CameraPopoverOptions PopoverOptions { get; set; }
    }

    public class Camera
    {
        [Template("navigator.camera.getPicture({0},{1},{2})")]
        public static void GetPicture(Action<string> cameraSuccess, Action<string> cameraError, CameraOptions cameraOptions)
        {
        }

        public static void GetPicture(Action<string> cameraSuccess, Action<string> cameraError)
        {
            GetPicture(cameraSuccess, cameraError, new CameraOptions());
        }
    }
}
