using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extensions to allow handling AngularJS on pages.
    /// </summary>
    [Ignore]
    public static partial class AngularJSExtensions
    {
        #region ngApp / Module
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
        public static void SetNGApp(this Element el, Module app)
        {
        }

        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it.
        /// </summary>
        /// <param name="el">Element to be bound to the module/app</param>
        /// <param name="value">The name of the module/app</param>
        /// <remarks>Will add 'ng-app=value' to the element.</remarks>
        [Template("{el}.setAttribute('ng-app', {value})")]
        public static void SetNGApp(this Element el, string value)
        {
        }

        /// <summary>
        /// Removes the binding of the module to the page's node if any.
        /// </summary>
        /// <param name="el">Element to have the module unbound from</param>
        [Template("{el}.removeAttribute('ng-app')")]
        public static void RemoveNGApp(this Element el)
        {
        }
        #endregion

        #region ngController
        /// <summary>
        /// Binds a controller to the HTML element. The controller's module must
        /// have this element into its scope or it will be ignored.
        /// </summary>
        /// <param name="el">Element to be bound to the controller</param>
        /// <param name="value">The name of the controller</param>
        [Template("{el}.setAttribute('ng-controller', {value})")]
        public static void SetNGController(this Element el, string value)
        {
        }

        /// <summary>
        /// Drops the NG controller from the specified element.
        /// </summary>
        /// <param name="el">Element to drop the ngController from.</param>
        [Template("{el}.removeAttribute('ng-controller')")]
        public static void RemoveNGController(this Element el)
        {
        }

        // TODO: support instance of the controller referenced/cycled thru
        //       the module's controller list
        #endregion

        #region ngModel
        /// <summary>
        /// Gets the NG model name.
        /// </summary>
        /// <returns>The NG model name.</returns>
        /// <param name="el">Element to get the ngModel name from</param>
        [Template("{el}.getAttribute('ng-model')")]
        public static string GetNGModel(this Element el)
        {
            return null;
        }

        /// <summary>
        /// Sets the NG model reference to the specified element.
        /// </summary>
        /// <param name="el">Element to get the ngModel reference.</param>
        /// <param name="modelName">Name for the model applied.</param>
        [Template("{el}.setAttribute('ng-model', {modelName})")]
        public static void SetNGModel(this Element el, string modelName)
        {
        }

        /// <summary>
        /// Drops the NG model attribute from the element.
        /// </summary>
        /// <param name="el">
        /// Element to have the ngModel attribute removed.
        /// </param>
        [Template("{el}.removeAttribute('ng-model')")]
        public static void RemoveNGModel(this Element el)
        {
        }
        #endregion
    }
}