using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RegistroIntegral_BLL.Helpers
{
    
    public static class StringHelper
    {
        /// <summary>
        /// This is shorthand for string.IsNullOrEmpty(str)
        /// </summary>
        public static bool IsEmpty(this string originalString)
        {
            return string.IsNullOrEmpty(originalString);
        }
        /// <summary>
        /// This is shorthand for (not) !string.IsNullOrEmpty(str)
        /// </summary>
        public static bool IsntEmpty(this string originalString)
        {
            return !string.IsNullOrEmpty(originalString);
        }
        /// <summary> This Extension Method will check for null and return the provided default if the object is null. Otherwise, it will return the object's .ToString() result
        /// </summary>
        /// <param name="defaultIfNull">If the Object is null, what default should be provided instead?</param>
        public static string ToStringOr(this object originalObject, string defaultIfNull = "")
        {
            if (originalObject == null)
            {
                return defaultIfNull;
            }
            return originalObject.ToString();
        }
        /// <summary> This extension method will return the same string with HtmlEncoding applied
        /// This is a shortcut to HttpUtility.HtmlEncode(theString)
        /// </summary>
        public static string AsHtmlEncoded(this string theString)
        {
            // NOTE That knockout data-bindings sometimes html-encode  strings also. 
            //  'value' IS encoded:        <div ><input type="text" data-bind="value: Company" /></div>
            //  'text'  IS encoded:        <div data-bind="    text: Company"></div>
            //  'html' NOT encoded:        <div data-bind="    html: Company"></div>
            return HttpUtility.HtmlEncode(theString);
        }
        /// <summary> This extension method will remove HtmlEncoding from the string, and return the plain text
        /// This is a shortcut to HttpUtility.HtmlDecode(theString)
        /// </summary>
        public static string AsHtmlDecoded(this string theString)
        {
            return HttpUtility.HtmlDecode(theString);
        }
        /// <summary>  This extension method will return the same string with UrlEncoding applied
        /// This is a shortcut to HttpUtility.UrlEncode(theString)
        /// </summary>
        public static string AsUrlEncoded(this string theString)
        {
            return HttpUtility.UrlEncode(theString);
        }
        
        /// <summary>  This extension method will remove the UrlEncoding from the string, and return the plain text.
        /// This is a shortcut to HttpUtility.UrlDecode(theString)
        /// </summary>
        public static string AsUrlDecoded(this string theString)
        {
            return HttpUtility.UrlDecode(theString);
        }
 
 
    }
}