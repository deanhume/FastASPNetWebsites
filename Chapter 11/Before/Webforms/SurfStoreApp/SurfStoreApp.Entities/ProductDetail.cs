using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfStoreApp.Entities
{
    public class ProductDetail
    {
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
    }
}
