using System;

namespace Bridge.AngularJS
{
    [Ignore]
    public class Module
    {
        public Module()
        {
        }

        #region Controller
        //FIXME: if T is an object with properties (get/set), it tries to bind
        //       the values thru .set<prop>() and no value gets bound to the
        //       controller.
        /// <summary>
        /// Binds to the controller the specified name and function.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="function">
        /// Function. Must have a $-prefixed parameter.
        /// </param>
        /// <typeparam name="T">The Model reference.</typeparam>
        /// <remarks>
        /// Don't use properties on objects (only fields supported).
        /// </remarks>
        [Template("{this}.controller({name}, {function})")]
        public void Controller<T>(string name, Action<T> function)
        {
        }

        /// <summary>
        /// Binds to the controller the specified name and function.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="function">Function.</param>
        /// <typeparam name="T1">The 1st type parameter.</typeparam>
        /// <typeparam name="Services.Http<T2>">The 2nd type parameter.</typeparam>
        [Template("{this}.controller({name}, {function})")]
        public void Controller<T1, T2>(string name, Action<T1, Services.Http<T2>> function)
        {
        }

        /// <summary>
        /// Set up the module's controller copying the specified object's 
        /// elements to its scope. Syntax sugar to map objects into a controller.
        /// </summary>
        /// <param name="name">Name for the controller (ng-controller)</param>
        /// <param name="data">Data to map to the controller's scope</param>
        [Template("{this}.controller({name}, ['$scope', function ($scope) { " +
            "for (var key in {data:raw}) $scope[key] = {data:raw}[key] }])")]
        public void Controller(string name, object data)
        {
        }

        //TODO: An overload with the second parameter as:
        //      1. function($scope, $http)
        //      2. ['$scope', function($scope)]
        //      3. ['$scope', '$http', function ($scope, http)]
        #endregion

        #region Directive
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
        #endregion
    }
}

