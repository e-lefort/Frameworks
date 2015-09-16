using System;

namespace Bridge.AngularJS
{
    [Ignore]
    public class Module
    {
        #region Fields
        /// <summary>
        /// Holds the list of modules which the injector will load
        /// before the current module is loaded.
        /// </summary>
        public string[] Requires;

        /// <summary>
        /// The name of the module.
        /// </summary>
        public string Name;
        #endregion

        #region Methods
        public Module()
        {
        }

        /// <summary>
        /// Register a provider function with the $injector.
        /// </summary>
        /// <param name="name">Service name.</param>
        /// <param name="providerType">
        /// Construction function for creating new instance of the service.
        /// </param>
        public void Provider(string name, Action providerType)
        {
        }

        /// <summary>
        /// Register a service factory, which will be called to return
        /// the service instance.
        /// </summary>
        /// <param name="name">Service name.</param>
        /// <param name="providerFunction">
        /// Function for creating new instance of the service.
        /// </param>
        public void Factory(string name, Action providerFunction)
        {
        }

        /// <summary>
        /// Register a service constructor, which will be invoked with
        /// new to create the service instance.
        /// </summary>
        /// <param name="name">Service name.</param>
        /// <param name="constructor">
        /// A constructor function that will be instantiated.
        /// </param>
        public void Service(string name, Action constructor)
        {
        }

        /// <summary>
        /// Register a value service with the $injector, such as a string,
        /// a number, an array, an object or a function.
        /// </summary>
        /// <param name="name">Service name.</param>
        /// <param name="instanceObject">Service instance object.</param>
        public void Value(string name, object instanceObject)
        {
        }

        /// <summary>
        /// Register a constant service, such as a string, a number,
        /// an array, an object or a function, with the $injector.
        /// </summary>
        /// <param name="name">Constant name.</param>
        /// <param name="constantValue">Constant value.</param>
        /// <remarks>
        /// Because the constant are fixed, they get applied before
        /// other provide methods.
        /// </remarks>
        public void Constant(string name, object constantValue)
        {
        }

        /// <summary>
        /// Register a service decorator with the $injector.
        /// </summary>
        /// <param name="the">Name of service to decorate.</param>
        /// <param name="instantiateFunction">
        /// Function will be invoked when the service needs to be instantiated
        /// and should return the decorated service instance.
        /// </param>
        public void Decorator(string the, Action instantiateFunction)
        {
        }

        /// <summary>
        /// Defines an animation hook that can be later used with $animate
        /// service and directives that use this service.
        /// </summary>
        /// <remarks>>
        /// Animations take effect only if the ngAnimate module is loaded.
        /// </remarks>
        /// <param name="name">Animantion name.</param>
        /// <param name="animationFactory">
        /// Factory function for creating new instance of an animation.
        /// </param>
        public void Animation(string name, Func<Animation> animationFactory)
        {
        }

        /// <summary>
        /// Define a filter using the specified name and filterFactory.
        /// </summary>
        /// <param name="name">
        /// Filter name - this must be a valid angular expression identifier.
        /// </param>
        /// <param name="filterFactory">
        /// Factory function for creating new instance of filter.
        /// </param>
        public void Filter(string name, Action filterFactory)
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
        /// Register a new directive with the compiler.
        /// </summary>
        /// <param name="directiveName"></param>
        /// <param name="builder"></param>
        public void Directive(string directiveName, Func<object> builder)
        {
        }
        #endregion

        /// <summary>
        /// Register work which needs to be performed on module loading.
        /// </summary>
        /// <param name="configFn">
        /// Function to be executed on module load.
        /// </param>
        /// <typeparam name="T">
        /// The type of the argument passed to the function.
        /// </typeparam>
        /// <seealso cref="Provider Recipe"/>
        /// <remarks>
        /// Useful for service configuration.
        /// </remarks>
        public void Config<T>(Action<T> configFn)
        {
        }

        /// <summary>
        /// Register work which should be performed when the injector
        /// is done loading all modules.
        /// </summary>
        /// <param name="initializationFn">
        /// Function to be executed after injector creation.
        /// </param>
        /// <typeparam name="T">
        /// The type argument passed to the function.
        /// </typeparam>
        /// <remarks>
        /// Useful for application initialization.
        /// </remarks>
        public void Run<T>(Action<T> initializationFn)
        {
        }
        #endregion
    }
}

