/* global Bridge */

"use strict";

Bridge.define('Bridge.Cordova.BatteryStatus', {
    statics: {
        batteryCritical: 0,
        batteryLow: 1,
        batteryStatus: 2
    }
});

Bridge.define('Bridge.Cordova.Events', {
    statics: {
        deviceReady: 0,
        pause: 1,
        resume: 2,
        backButton: 3,
        menuButton: 4,
        searchButton: 5,
        startCallButton: 6,
        endcallButton: 7,
        volumeDownButton: 8,
        volumeUpButton: 9
    }
});

Bridge.define('Bridge.Cordova.IApplication');

Bridge.define('Bridge.Cordova.Application$1', function (T) { return {
    inherits: [Bridge.Cordova.IApplication],
    statics: {
        instance: null,
        getInstance: function () {
            if (Bridge.Cordova.Application$1(T).instance === null) {
                Bridge.Cordova.Application$1(T).instance = new T();
                document.addEventListener("deviceready".toString(),function () {
                    Bridge.Cordova.Application$1(T).instance.onDeviceReady();
                    Bridge.Cordova.Application$1(T).addEventListener("pause", Bridge.fn.bind(Bridge.Cordova.Application$1(T).instance, Bridge.Cordova.Application$1(T).instance.onPause), false);
                    Bridge.Cordova.Application$1(T).addEventListener("resume", Bridge.fn.bind(Bridge.Cordova.Application$1(T).instance, Bridge.Cordova.Application$1(T).instance.onResume), false);
                },false);
            }

            return Bridge.Cordova.Application$1(T).instance;
        },
        addEventListener: function (type, listener, useCapture) {
            document.addEventListener(type.toString(),listener,useCapture);
        }
    }
}; });

Bridge.define('Bridge.Cordova.NetworkInformation', {
    statics: {
        online: 0,
        offline: 1
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Camera', {
    statics: {
        getPicture: function (cameraSuccess, cameraError) {
            navigator.camera.getPicture(cameraSuccess,cameraError,new Bridge.Cordova.Plugin.Camera.CameraOptions());
        }
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.CameraOptions', {
    config: {
        properties: {
            Quality: null,
            DestinationType: 0,
            SourceType: 0,
            AllowEdit: null,
            EncodingType: 0,
            TargetWidth: null,
            TargetHeight: null,
            MediaType: 0,
            CorrectOrientation: null,
            SaveToPhotoAlbum: null,
            CameraDirection: 0,
            PopoverOptions: null
        }
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.CameraDirection', {
    statics: {
        fRONT: 0,
        bACK: 1
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.DestinationType', {
    statics: {
        dATA_URL: 0,
        fILE_URI: 1,
        nATIVE_URI: 2
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.EncodingType', {
    statics: {
        jPEG: 0,
        pNG: 1
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.iOS.ArrowDir', {
    statics: {
        aRROW_UP: 1,
        aRROW_DOWN: 2,
        aRROW_LEFT: 4,
        aRROW_RIGHT: 8,
        aRROW_ANY: 15
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.iOS.CameraPopoverOptions', {
    config: {
        properties: {
            X: 0,
            Y: 0,
            Width: 0,
            Height: 0,
            ArrowDir: 0
        }
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.MediaType', {
    statics: {
        pICTURE: 0,
        vIDEO: 1,
        aLLMEDIA: 2
    }
});

Bridge.define('Bridge.Cordova.Plugin.Camera.Options.SourceType', {
    statics: {
        pHOTOLIBRARY: 0,
        cAMERA: 1,
        sAVEDPHOTOALBUM: 2
    }
});