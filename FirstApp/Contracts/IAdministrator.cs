using FirstApp.Abstractions;
using System.Collections.Generic;

namespace FirstApp.Contracts
{
    public interface IAdministrator
    {
        void Create(Product product);

        void Remove(int id);

        void Update(int id,Product product);

        IEnumerable<Product> GetAll();
    }
}
