using System;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace SurfStoreApp.Utils
{
    public static class DataUriUtils
    {
        public static MvcHtmlString DrawImage(this HtmlHelper helper, string imageUrl, string alt)
        {
            if (CanBrowserHandleDataUris() & IsFileSizeCorrect(imageUrl))
            {
                // Get the file type
                string fileType = Path.GetExtension(imageUrl);
                if (fileType != null)
                {
                    fileType = fileType.Replace(".", "");
                }

                // Convert the image
                imageUrl = ConvertImageToBase64String(imageUrl);

               return new MvcHtmlString(String.Format("<img alt=\"{0}\" " +
                                     "src=\"data:image/{1};base64,{2}\" />", alt,
                                     fileType, imageUrl));
            }

            return new MvcHtmlString(String.Format("<img alt=\"{0}\" src=\"{1}\" />", alt, imageUrl));
        }

        /// <summary>
        /// Determine if the size of the file matches the minimum requirements.
        /// The size of the image needs to be less than 32KB.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        private static bool IsFileSizeCorrect(string imageUrl)
        {
            string imagepath = HttpContext.Current.Server.MapPath(imageUrl);

            // determine the length
            long fileLength = new FileInfo(imagepath).Length;

            return fileLength < 32768;
        }

        /// <summary>
        /// Converts the image to base64 string.
        /// </summary>
        /// <param name="imageUrl">The image URL.</param>
        /// <returns></returns>
        private static string ConvertImageToBase64String(string imageUrl)
        {
            string imagepath = HttpContext.Current.Server.MapPath(imageUrl);

            using (Image image = Image.FromFile(imagepath))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Convert Image to byte[]
                    image.Save(memoryStream, image.RawFormat);
                    byte[] imageBytes = memoryStream.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }


        /// <summary>
        /// Determines if the browser is able to handle Data URIs based on its version.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance [can browser handle data uris]; otherwise, <c>false</c>.
        /// </returns>
        private static bool CanBrowserHandleDataUris()
        {
            float browserVersion = -1;

            HttpRequest httpRequest = HttpContext.Current.Request;
            HttpBrowserCapabilities browser = httpRequest.Browser;

            if (browser.Browser == "IE")
            {
                browserVersion = (float) (browser.MajorVersion + browser.MinorVersion);
            }

            if (browserVersion > 8 || browserVersion == -1)
            {
                return true;
            }

            return false;
        }
    }
}