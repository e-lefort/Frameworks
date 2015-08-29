using Bridge.Html5;
using System;

namespace Bridge.AngularJS
{
    //[Ignore] set on main definition
    public partial class AngularJSApp
    {
        /// <summary>
        /// Set up the module's controller copying the specified object's 
        /// elements to its scope.
        /// </summary>
        /// <param name="name">Name for the controller (ng-controller)</param>
        /// <param name="data">Data to map to the controller's scope</param>
        [Template("{this}.controller({name}, ['$scope', function ($scope) { " +
            "for (var key in {data:raw}) $scope[key] = {data:raw}[key] }])")]
        public void Controller(string name, object data)
        {
        }

        //FIXME: if T is an object with properties (get/set), it tries to bind
        //       the values thru .set<prop>() and no value gets bound to the
        //       controller.
        /// <summary>
        /// Binds to the controller the specified name and function.
        /// Broken due to limitations on Bridge and Properties.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="function">
        /// Function. Must have a $-prefixed parameter.
        /// </param>
        /// <typeparam name="T">The Model reference.</typeparam>
        [Template("{this}.controller({name}, {function})")]
        public void Controller<T>(string name, Action<T> function)
        {
        }

        //TODO: An overload with the second parameter as:
        //      1. function($scope, $http)
        //      2. ['$scope', function($scope)]
        //      3. ['$scope', '$http', function ($scope, http)]
    }

    //[Ignore] set on main definition
    public static partial class AngularJSExtensions
    {
        /// <summary>
        /// Binds a controller to the HTML element. The controller's module must
        /// have this element into its scope or it will be ignored.
        /// </summary>
        /// <param name="el">Element to be bound to the controller</param>
        /// <param name="value">The name of the controller</param>
        [Template("{el}.setAttribute('ng-controller', {value})")]
        public static void setNGController(this Element el, string value)
        {
        }

        /// <summary>
        /// Drops the NG controller from the specified element.
        /// </summary>
        /// <param name="el">Element to drop the ngController from.</param>
        [Template("{el}.removeAttribute('ng-controller')")]
        public static void dropNGController(this Element el)
        {
        }

        // TODO: support instance of the controller referenced/cycled thru
        //       the module's controller list
    }
}