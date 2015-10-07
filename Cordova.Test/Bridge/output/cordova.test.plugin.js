/* global Bridge */

"use strict";

Bridge.define('Cordova.Test.Plugin.Camera', {
    run: function () {
        var option = { x: 5, y: 45, width: 1458 };
    }
});

Bridge.define('Cordova.Test.Plugin.File', {
    run: function () {
        Bridge.global.alert(cordova.file.applicationDirectory);
    }
});

Bridge.define('Cordova.Test.Plugin.WebSql', {
    run: function () {
        var dbSize = 5242880; // 5MB
        var db = openDatabase("Todo","","Todo manager",dbSize,function (database) {
            console.log("db successfully opened or created");
        });
        db.transaction(Bridge.fn.bind(this, function (tx) {
            tx.executeSql("CREATE TABLE IF NOT EXISTS todo(ID INTEGER PRIMARY KEY ASC, todo TEXT, added_on TEXT)",[],Bridge.fn.bind(this, this.onSuccess),Bridge.fn.bind(this, this.onError));
            tx.executeSql("INSERT INTO todo(todo, added_on) VALUES (?,{?)",["my todo item", new Date().toUTCString()],Bridge.fn.bind(this, this.onSuccess),Bridge.fn.bind(this, this.onError));
        }));

        Bridge.global.alert(db.version);
    },
    onSuccess: function (transaction, resultSet) {
        console.log("Query completed: " + JSON.stringify(resultSet));
    },
    onError: function (transaction, error) {
        console.log("Query failed: " + error.message);
    }
});