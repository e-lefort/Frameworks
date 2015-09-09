namespace Bridge.AngularJS
{
    [Ignore]
    [Name("angular")]
    public class Angular
    {
        public Angular()
        {
        }

        [Template("{this}.module({name}, [])")]
        public static Module Module(string name)
        {
            return null;
        }

        public static Module Module(string name, string[] dependencies)
        {
            return null;
        }
    }
}

