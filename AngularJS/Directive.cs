using System;

namespace Bridge.AngularJS
{
    //[Ignore] set on main definition
    public partial class AngularJSApp
    {
        // TODO: Offer a similar approach from controllers to allow simpler
        //       directive matching and changing without passing function.
        // (for example, an specific for just providing value to the returned
        //  template object property!)

        /// <summary>
        /// Applies the builder function to the
        /// </summary>
        /// <param name="directiveName"></param>
        /// <param name="builder"></param>
        public void Directive(string directiveName, Func<object> builder)
        {
        }
    }
}