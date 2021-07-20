using FirstApp.Abstractions;
using FirstApp.Contracts;
using System;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public class Administrator : User, IAdministrator
    {
        public Administrator()
        {
            Role = Roles.Administrator;
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
