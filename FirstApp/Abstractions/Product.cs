using FirstApp.Models;
using System.Collections.Generic;

namespace FirstApp.Abstractions
{
    public abstract class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Firm { get; set; }

        public double Cost { get; set; }

        public ProductType Type { get; set; }

        public int Count { get; set; }

        public string Image { get; set; }

        public IEnumerable<Pharmacy> Pharmacies { get; set; }
    }
}
