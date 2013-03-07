using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Threading;
using System.Configuration;
using SurfStoreApp.Entities;

namespace SurfStoreApp.Data
{
    public class ProductData
    {
        readonly string _connectionString;

        #region ctor
        public ProductData()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        #endregion

        public List<ProductDetail> GetProductDetailByCategory(string category)
        {
            // The results of the query
            List<ProductDetail> products = new List<ProductDetail>();

            // Build up the query string
            const string query = "SELECT * FROM Product WHERE Category = @category";

            // I have purposely injected this piece of code to slow down here. We are going to use MiniProfiler to trace and detect this.
            Thread.Sleep(5000);

            using (var connection = new SqlCeConnection(_connectionString))
            {
                connection.Open();

                // Build up the SQL command
                SqlCeCommand sqlCommand = new SqlCeCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@category", category);

                using (SqlCeDataReader sqlCeReader = sqlCommand.ExecuteReader())
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
