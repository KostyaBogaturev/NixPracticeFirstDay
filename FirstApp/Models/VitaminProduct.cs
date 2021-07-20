using FirstApp.Abstractions;

namespace FirstApp.Models
{
    public class VitaminProduct : Product
    {
        public VitaminProduct()
        {
            Type = ProductType.Vitamin;
        }
    }
}
