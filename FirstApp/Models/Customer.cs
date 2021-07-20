using FirstApp.Abstractions;
using FirstApp.Contracts;
using System;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public class Customer:User, ICustomer
    {
        public Customer()
        {
            Role = Roles.Customer;
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool MakeOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
