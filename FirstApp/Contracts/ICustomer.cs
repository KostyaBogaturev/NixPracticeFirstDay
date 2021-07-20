using FirstApp.Abstractions;
using FirstApp.Models;
using System.Collections.Generic;

namespace FirstApp.Contracts
{
    public interface ICustomer
    {
        IEnumerable<Product> GetAll();

        bool MakeOrder(Order order);
    }
}
