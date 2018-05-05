using System;
using System.Collections.Generic;
namespace ACM.BL
{
    public class Product
    {
        public Product() {}

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName) && !CurrentPrice.Equals(null);
        }

    }
}
