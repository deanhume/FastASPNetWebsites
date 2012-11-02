using System.IO;
using System.Web;

namespace SurfStoreApp.Utils
{
    public class ImageUtils
    {
        /// <summary>
        /// Retrieves the product images based on the category. This is not ideal, but it
        /// demonstrates the basics by printing the images to the page.
        /// </summary>
        /// <param name="category">The category.</param>
        public FileInfo[] RetrieveProductImages(string category)
        {
            // Read from the directory
            string appDataPath = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"Content\Images");

            string fullPath = Path.Combine(appDataPath, category);

            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            return directoryInfo.GetFiles("*");
        }
    }
}