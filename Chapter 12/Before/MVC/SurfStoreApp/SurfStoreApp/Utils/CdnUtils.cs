using System;
using System.Configuration;
using System.Web.Mvc;

namespace SurfStoreApp.Utils
{
    public static class CdnUtils
    {
        /// <summary>
        /// This extension method is used to generate a URL path
        /// for the CDN depending whether or not we are in release
        /// or debug mode.
        /// </summary>
        /// <param name="helper">The HTML helper that is being used.</param>
        /// <param name="contentPath">The path of the content. Normally starts with a ~</param>
        /// <returns>Returns a full URL based on whether or not in release mode</returns>
        public static string CdnUrl(this HtmlHelper helper, string contentPath)
        {
            // If in release mode
            #if (!DEBUG)

                // remove the leading "~" character
                if (contentPath.StartsWith("~"))
                {
                    contentPath = contentPath.Substring(1);
                }

                // Retrieve the key from the Web.config
                string appSetting = ConfigurationManager.AppSettings["CDNUrl"];

                Uri combinedUri = new Uri(new Uri(appSetting), contentPath);
                contentPath = combinedUri.ToString();
            #endif

            // Create the correct URL
            var url = new UrlHelper(helper.ViewContext.RequestContext);

            return url.Content(contentPath);
        }
    }
}