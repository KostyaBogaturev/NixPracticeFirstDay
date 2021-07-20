using FirstApp.Abstractions;

namespace FirstApp.Models
{
    class ForChildrenProduct : Product
    {
        public ForChildrenProduct()
        {
            Type = ProductType.ForChildren;
        }
    }
}
