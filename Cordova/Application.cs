using Bridge;
using System;
using System.Collections.Generic;

namespace Bridge.Cordova
{
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    public enum Events
    {
        DeviceReady,
        Pause,
        Resume,
        BackButton,
        MenuButton,
        SearchButton,
        StartCallButton,
        EndcallButton,
        VolumeDownButton,
        VolumeUpButton
    }

    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    public enum BatteryStatus
    {
        BatteryCritical,
        BatteryLow,
        BatteryStatus,
    }

    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    public enum NetworkInformation
    {
        Online,
        Offline,
    }

    public interface IApplication
    {
        void OnDeviceReady();
        void OnPause();
        void OnResume();
        void OnMenuButton();
        void OnBackButton();
        void OnSearchButton();
        void OnOnline();
        void OnOffline();
    }

    public abstract class Application<T> : IApplication where T : Application<T>
    {
        private static T instance; 
        public static T GetInstance()
        {
                if(instance == null)
                {
                    instance = Activator.CreateInstance<T>();
                    Application<T>.AddEventListener(Events.DeviceReady, () => {
                        instance.OnDeviceReady();
                        Application<T>.AddEventListener(Events.Pause, instance.OnPause, false);
                        Application<T>.AddEventListener(Events.Resume, instance.OnResume, false);
                    }, false);
                }

                return instance;
        }

        [Template("document.addEventListener({0},{1},{2})")]
        public static void AddEventListener(string type, Action listener, bool? useCapture)
        {
        }

        [Template("document.addEventListener({0},{1},{2})")]
        public static void AddEventListener(Enum type, Action listener, bool? useCapture)
        {

        }

        public abstract void OnDeviceReady();
        public abstract void OnPause();
        public abstract void OnResume();
        public abstract void OnMenuButton();
        public abstract void OnBackButton();
        public abstract void OnSearchButton();
        public abstract void OnOnline();
        public abstract void OnOffline();
    }
}