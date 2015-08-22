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
        /// Sets the NG model reference to the specified element.
        /// </summary>
        /// <param name="el">Element to get the ngModel reference.</param>
        /// <param name="modelName">Name for the model applied.</param>
        [Template("{el}.setAttribute('ng-model', {modelName})")]
        public static void setNGModel(this InputElement el, string modelName)
        {
        }

        /// <summary>
        /// Drops the NG model attribute from the element.
        /// </summary>
        /// <param name="el">
        /// Element to have the ngModel attribute removed.
        /// </param>
        [Template("{el}.removeAttribute('ng-model')")]
        public static void dropNGModel(this InputElement el)
        {
        }
    }
}