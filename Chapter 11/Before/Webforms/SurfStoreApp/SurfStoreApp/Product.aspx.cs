using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                ProductLogic productLogic = new ProductLogic();
                List<ProductDetail> productsForCategory = productLogic.GetProductDetailByCategory(category);

                foreach (ProductDetail product in productsForCategory)
                {
                    phProductImages.Controls.Add(BuildHtml(category, product.ImageUrl, product.ProductDescription));
                }
            }
        }

        /// <summary>
        /// Builds the HTML that displays the images.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="imageDescription">The image description.</param>
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