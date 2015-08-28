using Bridge.Html5;
using System.Collections.Generic;

namespace Bridge.AngularJS
{
    /// <summary>
    /// AngularJS Module handler (module is also known as application -- ng-app)
    /// </summary>
    [Ignore]
    public partial class AngularJSApp
    {
        /// <summary>
        /// Initializes a new AngularJS module with the specified name and no
        /// other modules dependencies.
        /// </summary>
        /// <param name="angularAppName">Name of the module name (ngApp)</param>
        [Template("angular.module({angularAppName}, [])")]
        public AngularJSApp(string angularAppName)
        {
        }

        /// <summary>
        /// Initializes a new AngularJS module with the specified name and list 
        /// of modules it depends on.
        /// </summary>
        /// <param name="angularAppName">Name of the module name (ngApp)</param>
        /// <param name="dependencies">
        /// List of module names this module depends on
        /// </param>
        [Template("angular.module({angularAppName}, {controllers})")]
        public AngularJSApp(string angularAppName,
            IEnumerable<string> dependencies)
        {
        }
    }

    //[Ignore] set on main definition
    public static partial class AngularJSExtensions
    {
        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it.
        /// </summary>
        /// <param name="el">Element to be bound to the module/app</param>
        /// <param name="value">The name of the module/app</param>
        /// <remarks>Will add 'ng-app=value' to the element.</remarks>
        [Template("{el}.setAttribute('ng-app', {value})")]
        public static void setNGApp(this Element el, string value)
        {
        }

        /// <summary>
        /// Removes the binding of the module to the page's node if any.
        /// </summary>
        /// <param name="el">Element to have the module unbound from</param>
        [Template("{el}.removeAttribute('ng-app')")]
        public static void dropNGApp(this Element el)
        {
        }

        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it. (adds ng-app= to the HTML element)
        /// </summary>
        /// <param name="el">Element to be bound to the module/app</param>
        /// <param name="app">The instance of the module/app</param>
        /// <remarks>
        /// The name of the module/app filled in ng-app=[name] will be extracted
        /// from the specified instance.
        /// </remarks>
        [Template("{el}.setAttribute('ng-app', {app:raw}.name)")]
        public static void setNGApp(this Element el, AngularJSApp app)
        {
        }
    }
}