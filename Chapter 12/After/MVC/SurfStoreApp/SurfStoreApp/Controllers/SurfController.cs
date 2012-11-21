using System.Collections.Generic;
using System.Web.Mvc;
using StackExchange.Profiling;
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

        public ActionResult Product(string category)
        {
            // Check if a category was passed in first.
            if (!string.IsNullOrWhiteSpace(category))
            {
                List<ProductDetail> productDetails;
                var profiler = MiniProfiler.Current; // it's ok if this is null
                using (profiler.Step("Retrieve Products"))
                {
                    // Retrieve the products for the category
                    ProductLogic productLogic = new ProductLogic();
                    productDetails = productLogic.GetProductDetailByCategory(category);
                }

                // Loop through the results and add to our model
                List<ProductModel> productModel = new List<ProductModel>();
                using (profiler.Step("Build Model"))
                {
                    foreach (ProductDetail product in productDetails)
                    {
                        productModel.Add(new ProductModel
                        {
                            ImageDescription = product.ProductDescription,
                            ImageUrl = product.ImageUrl
                        });
                    }
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
