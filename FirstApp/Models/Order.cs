using FirstApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public IEnumerable<Product> ProductList { get; set; }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
