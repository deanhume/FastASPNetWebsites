using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
