using System.Collections.Generic;
using SurfStoreApp.Data;
using SurfStoreApp.Entities;
using SurfStoreApp.Logic.Cache;

namespace SurfStoreApp.Logic
{
    public class ProductLogic
    {
        /// <summary>
        /// Gets the product detail by category.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns></returns>
        public List<ProductDetail> GetProductDetailByCategory(string category)
        {
            // Build a cacheKey
            string cacheKey = "GetProductDetailByCategory-" + category;

            // Try and retrieve the data from the cache
            List<ProductDetail> productDetails = DataCaching.Get<List<ProductDetail>>(cacheKey);

            if (productDetails == null)
            {
                // Retrieve from the database
                ProductData productData = new ProductData();
                productDetails = productData.GetProductDetailByCategory(category);

                // Add into cache
                DataCaching.Add(productDetails, cacheKey);
            }

            return productDetails;
        }
    }
}
