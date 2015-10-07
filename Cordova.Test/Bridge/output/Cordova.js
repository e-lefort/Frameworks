/* global Bridge */

"use strict";

Bridge.define('Bridge.Cordova.IApplication');

Bridge.define('Bridge.Cordova.Application$1', function (T) { return {
    inherits: [Bridge.Cordova.IApplication],
    statics: {
        instance: null,
        getInstance: function () {
            if (Bridge.Cordova.Application$1(T).instance === null) {
                Bridge.Cordova.Application$1(T).instance = new T();
                document.addEventListener("deviceready",function () {
                    Bridge.Cordova.Application$1(T).instance.onDeviceReady();
                    document.addEventListener("pause",Bridge.fn.bind(Bridge.Cordova.Application$1(T).instance, Bridge.Cordova.Application$1(T).instance.onPause),false);
                    document.addEventListener("resume",Bridge.fn.bind(Bridge.Cordova.Application$1(T).instance, Bridge.Cordova.Application$1(T).instance.onResume),false);
                },false);
            }

            return Bridge.Cordova.Application$1(T).instance;
        }
    }
}; });

Bridge.define('Bridge.Cordova.Plugin.Camera.Camera');

Bridge.define('Bridge.Cordova.Plugin.WebSQL.Database', {
    name: null,
    version: null,
    displayName: null,
    size: 0,
    constructor: function (name, version, displayName, size) {
        this.name = name;
        this.version = version;
        this.displayName = displayName;
        this.size = size;
    }
});

Bridge.define('Bridge.Cordova.Plugin.WebSQL.SqlTransaction');

Bridge.define('Bridge.Cordova.Plugin.WebSQL.WebSQL');