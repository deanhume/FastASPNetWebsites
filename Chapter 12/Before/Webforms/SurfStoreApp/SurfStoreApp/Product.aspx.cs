using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using StackExchange.Profiling;
using SurfStoreApp.Entities;
using SurfStoreApp.Logic;

namespace SurfStoreApp
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the category from the querystring
            string category = Request.QueryString["category"];

            // Check if we received a category
            if (!string.IsNullOrWhiteSpace(category))
            {
                // Display the images
                List<ProductDetail> productsForCategory = new List<ProductDetail>();
                var profiler = MiniProfiler.Current;
                using (profiler.Step("Retrieve Products"))
                {
                    ProductLogic productLogic = new ProductLogic();
                    productsForCategory = productLogic.GetProductDetailByCategory(category);
                }

                using (profiler.Step("Build HTML"))
                {
                    // Loop through each product and build the HTML that we are going to 
                    // return to the web page
                    foreach (ProductDetail product in productsForCategory)
                    {
                        phProductImages.Controls.Add(BuildHtml(category, Utils.CdnUtils.CdnUrl(product.ImageUrl), product.ProductDescription));
                    }
                }
            }
        }

        /// <summary>
        /// Builds the HTML that displays the images.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <param name="imageUrl">The image URL.</param>
        /// <param name="productDescription">The product description.</param>
        /// <returns></returns>
        public Literal BuildHtml(string category, string imageUrl, string productDescription)
        {
            // Build the HTML
            StringBuilder imageHtml = new StringBuilder("<div class=\"span4\"><h2>");
            imageHtml.Append(productDescription);
            imageHtml.Append("</h2>");
            imageHtml.Append("<img src=\"");
            imageHtml.Append(imageUrl);
            imageHtml.Append("\" />");
            imageHtml.Append("</div>");

            return new Literal { Text = imageHtml.ToString() };
        }

        /// <summary>
        /// Retrieves the images based on the category. This is not ideal, but it
        /// demonstrates the basics by printing the images to the page.
        /// </summary>
        /// <param name="category">The category.</param>
        public FileInfo[] RetrieveImages(string category)
        {
            // Read from the directory
            string appDataPath = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "Images");

            string fullPath = Path.Combine(appDataPath, category);

            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            return directoryInfo.GetFiles("*");
        }
    }
}