using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extensions to allow handling AngularJS on pages.
    /// </summary>
    [Ignore]
    public static partial class AngularJSExtensions
    {
        /// <summary>
        /// Gets the NG model name.
        /// </summary>
        /// <returns>The NG model name.</returns>
        /// <param name="el">Element to get the ngModel name from</param>
        [Template("{el}.getAttribute('ng-model')")]
        public static string getNGModel(this Element el)
        {
            return null;
        }

        /// <summary>
        /// Sets the NG model reference to the specified element.
        /// </summary>
        /// <param name="el">Element to get the ngModel reference.</param>
        /// <param name="modelName">Name for the model applied.</param>
        [Template("{el}.setAttribute('ng-model', {modelName})")]
        public static void setNGModel(this Element el, string modelName)
        {
        }

        /// <summary>
        /// Drops the NG model attribute from the element.
        /// </summary>
        /// <param name="el">
        /// Element to have the ngModel attribute removed.
        /// </param>
        [Template("{el}.removeAttribute('ng-model')")]
        public static void dropNGModel(this Element el)
        {
        }
    }
}