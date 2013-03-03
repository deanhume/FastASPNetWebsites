using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SurfStoreApp.Entities;
using System.Threading;

namespace SurfStoreApp.Data
{
    public class ProductData
    {
        string connectionString;

        public ProductData()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public List<ProductDetail> GetProductDetailByCategory(string category)
        {
            // The results of the query
            List<ProductDetail> products = new List<ProductDetail>();

            // Build up the query string
            // This isn't ideal as it is open to injection attacks, but serves as example code. Prefer stored procedures.
            // It is not possible with SQL CE to use stored procedures at this time as it is an in-memory DB.
            string query = "SELECT * FROM Product WHERE Category = '" + category + "'";

            //Thread.Sleep(5000);

            using (var connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                using (SqlCeDataReader sqlCeReader = new SqlCeCommand(query, connection).ExecuteReader())
                {
                    while (sqlCeReader.Read())
                    {
                        // Build up the object
                        ProductDetail productDetail = new ProductDetail();
                        productDetail.ProductId = Convert.ToInt32(sqlCeReader["ProductId"]);
                        productDetail.ProductDescription = sqlCeReader["ProductDescription"] != null ? sqlCeReader["ProductDescription"].ToString() : string.Empty;
                        productDetail.ImageUrl = sqlCeReader["ImageUrl"] != null ? sqlCeReader["ImageUrl"].ToString() : string.Empty;
                        productDetail.Category = sqlCeReader["Category"] != null ? sqlCeReader["Category"].ToString() : string.Empty; 

                        // Add to the collection
                        products.Add(productDetail);
                    }
                }
            }

            return products;
        }
    }
}
