/* global Bridge */

"use strict";

Bridge.define('Cordova.Test.App', {
    statics: {
        config: {
            init: function () {
                Bridge.ready(this.main);
            }
        },
        main: function () {
            var index = Bridge.Cordova.Application$1(Cordova.Test.Index).getInstance();
            document.addEventListener("searchbutton",Bridge.fn.bind(index, index.onSearchButton),false);
        }
    }
});

Bridge.define('Cordova.Test.Index', {
    inherits: function () { return [Bridge.Cordova.Application$1(Cordova.Test.Index)]; },
    onDeviceReady: function () {
        Bridge.global.alert("OnDeviceReady");
    },
    onPause: function () {
        Bridge.global.alert("OnPause");
    },
    onResume: function () {
        Bridge.global.alert("OnResume");
    },
    onMenuButton: function () {
        Bridge.global.alert("OnMenuButton");
    },
    onBackButton: function () {
        Bridge.global.alert("OnBackButton");
    },
    onSearchButton: function () {
        Bridge.global.alert("OnSearchButton");
    },
    onOnline: function () {
        Bridge.global.alert("OnOnline");
    },
    onOffline: function () {
        Bridge.global.alert("OnOffline");
    }
});

