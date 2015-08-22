using Bridge.Html5;

namespace Bridge.AngularJS
{
    //[Ignore] set on main definition
    public partial class AngularJSApp
    {
        /// <summary>
        /// Set up the module's controller copying the specified object's elements
        /// to its scope.
        /// </summary>
        /// <param name="name">Name for the controller (ng-controller)</param>
        /// <param name="data">Data to map to the controller's scope</param>
        [Template("{this}.controller({name}, ['$scope', function ($scope) { for (var key in {data:raw}) $scope[key] = {data:raw}[key] }])")]
        public void Controller(string name, object data)
        {
        }

        //TODO: a way to specify the controller like it is done in AngularJS native,
        //      providing a function($scope) { $scope.foo = "foo"; $scope.bar = "bar" }
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