using Bridge.Html5;

namespace Bridge.AngularJS
{
    //[Ignore] set on main definition
    public static partial class AngularJSExtensions
    {
        /// <summary>
        /// Sets the NG repeat to the element with the specified free text
        /// expression.
        /// </summary>
        /// <param name="el">Element to apply the ngRepeat to</param>
        /// <param name="expression">Valid ngRepeat AngularJS expression</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{el}.setAttribute('ng-repeat', {expression})")]
        public static void setNGRepeat(this Element el, string expression)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable and iterated array names.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to</param>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{el}.setAttribute('ng-repeat', '{variable:raw} in {array:raw}')")]
        public static void setNGRepeat(this Element el, string variable,
            string array)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and filter input field.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to</param>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{el}.setAttribute('ng-repeat', '{variable:raw} in {array:raw} | filter:{filterInputField:raw}')")]
        public static void setNGRepeat(this Element el, string variable,
            string array, string filterInputField)
        {
        }

        [Template("{el}.setAttribute('ng-repeat', '{variable:raw} in {array:raw} | " +
                  "filter: ' + {filterInputField} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public static void setNGRepeat(this Element el, string variable,
            string array, string filterInputField, string orderByInputField)
        {
        }

        /// <summary>
        /// Drops the NG repeat from the specified element.
        /// </summary>
        /// <param name="el">Element to drop the ngRepeat from.</param>
        [Template("{el}.removeAttribute('ng-repeat')")]
        public static void dropNGRepeat(this Element el)
        {
        }

        // TODO: a way to represent both the loop and filter with actual 
        //       variables' references not string variables.
    }
}