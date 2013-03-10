using System.Collections.Generic;
using SurfStoreApp.Data;
using SurfStoreApp.Entities;

namespace SurfStoreApp.Logic
{
    public class ProductLogic
    {
        public List<ProductDetail> GetProductDetailByCategory(string category)
        {
            // Retrieve the products
            ProductData productData = new ProductData();
            return productData.GetProductDetailByCategory(category);
        }
    }
}
