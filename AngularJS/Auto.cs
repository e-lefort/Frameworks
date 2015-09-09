using System;

namespace Bridge.AngularJS
{
    [Ignore]
    [Name("auto")]
    public class Auto
    {
        public Auto()
        {
        }
    }
}

namespace Bridge.AngularJS.Services
{
    [Ignore]
    public class Injector
    {
        public static object Get(string name, string caller = default(string))
        {
            return default(object);
        }

        public static object Invoke(Action fn, object self = default(object),
            object locals = default(object))
        {
            return default(object);
        }

        public static bool Has(string name)
        {
            return default(bool);
        }

        public static object Instantiate(Action type, object locals = default(object))
        {
            return default(object);
        }

        public static string[] Annotate(Action fn, bool strictDi = false)
        {
            return default(string[]);
        }
    }
}