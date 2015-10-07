using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *    https://github.com/apache/cordova-plugin-file
 */

namespace Bridge.Cordova.Plugin.File
{
    [Ignore]
    public partial class File
    {
        /* Read-only directory where the application is installed. */
        [Template("cordova.file.applicationDirectory")]
        public static readonly string ApplicationDirectory;

        /* Root of app's private writable storage */
        [Template("cordova.file.applicationStorageDirectory")]
        public static readonly string ApplicationStorageDirectory;

        /* Where to put app-specific data files. */
        [Template("cordova.file.dataDirectory")]
        public static readonly string DataDirectory;

        /* Cached files that should survive app restarts. Apps should not rely on the OS to delete files in here. */
        [Template("cordova.file.cacheDirectory")]
        public static readonly string CacheDirectory;

        /* Android: the application space on external storage. */
        [Template("cordova.file.externalApplicationStorageDirectory")]
        public static readonly string ExternalApplicationStorageDirectory;

        /* Android: Where to put app-specific data files on external storage. */
        [Template("cordova.file.externalDataDirectory")]
        public static readonly string ExternalDataDirectory;

        /* Android: the application cache on external storage. */
        [Template("cordova.file.externalCacheDirectory")]
        public static readonly string ExternalCacheDirectory;

        /* Android: the external storage (SD card) root. */
        [Template("cordova.file.externalRootDirectory")]
        public static readonly string ExternalRootDirectory;

        /* iOS: Temp directory that the OS can clear at will. */
        [Template("cordova.file.tempDirectory")]
        public static readonly string TempDirectory;

        /* iOS: Holds app-specific files that should be synced (e.g. to iCloud). */
        [Template("cordova.file.syncedDataDirectory")]
        public static readonly string SyncedDataDirectory;

        /* iOS: Files private to the app, but that are meaningful to other applciations (e.g. Office files) */
        [Template("cordova.file.documentsDirectory")]
        public static readonly string DocumentsDirectory;

        /* BlackBerry10: Files globally available to all apps */
        [Template("cordova.file.sharedDirectory")]
        public static readonly string SharedDirectory;
    }
}
