using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI;
using SurfStoreApp.Entities;
using SurfStoreApp.Logic;
using SurfStoreApp.Models;

namespace SurfStoreApp.Controllers
{
    public class SurfController : Controller
    {
        [OutputCache(Duration = 100, VaryByParam = "none")]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 86400, VaryByParam = "category", Location = OutputCacheLocation.Client)]
        public ActionResult Product(string category)
        {
            // Check if a category was passed in first.
            if (!string.IsNullOrWhiteSpace(category))
            {
                // Retrieve the products for the category
                ProductLogic productLogic = new ProductLogic();
                List<ProductDetail> productDetails = productLogic.GetProductDetailByCategory(category);

                // Loop through the results and add to our model
                List<ProductModel> productModel = new List<ProductModel>();
                foreach (ProductDetail product in productDetails)
                {
                    productModel.Add(new ProductModel
                    {
                        ImageDescription = product.ProductDescription,
                        ImageUrl = product.ImageUrl
                    });
                }

                // Return the populated model to the view
                return View(productModel);
            }

            // Incorrect parameters were passed in, so return nothing.
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
