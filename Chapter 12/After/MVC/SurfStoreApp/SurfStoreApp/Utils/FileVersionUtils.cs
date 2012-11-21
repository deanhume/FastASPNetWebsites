using System.Web.Mvc;

namespace SurfStoreApp.Utils
{
    public class FileVersionUtils
    {
        /// <summary>
        /// Builds the name of the versioned file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public static string BuildVersionedFileName(string fileName)
        {
            var assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            return string.Format("{0}?v={1}", fileName, assemblyVersion);
        }
    }
}