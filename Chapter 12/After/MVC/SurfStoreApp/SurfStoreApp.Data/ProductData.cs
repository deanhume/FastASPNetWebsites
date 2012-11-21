using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
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

        /// <summary>
        /// Gets the product detail by category.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <returns></returns>
        public List<ProductDetail> GetProductDetailByCategory(string category)
        {
            // The results of the query
            List<ProductDetail> products = new List<ProductDetail>();

            // Build up the query string
            // This isn't ideal as it is open to injection attacks, but serves as example code. Prefer stored procedures.
            string query = "SELECT * FROM Product WHERE Category = '" + category + "'";

            using (var connection = new SqlCeConnection(_connectionString))
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
