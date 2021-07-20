using FirstApp.Abstractions;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public class Pharmacy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
