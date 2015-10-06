/* global Bridge */

"use strict";

define("bridge.cordova", ["bridge"], function (_) {
    var exports = { };
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
                        ("pause", Bridge.fn.bind(Bridge.Cordova.Application$1(T).instance, Bridge.Cordova.Application$1(T).instance.onPause), false);
                        ("resume", Bridge.fn.bind(Bridge.Cordova.Application$1(T).instance, Bridge.Cordova.Application$1(T).instance.onResume), false);
                    },false);
                }
    
                return Bridge.Cordova.Application$1(T).instance;
            },
            addEventListener: function (type, listener, useCapture) {
                document.addEventListener(type.toString(),listener,useCapture);
            }
        }
    }; });
    
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
    return exports;
});

