using FirstApp.Abstractions;

namespace FirstApp.Models
{
    public class CosmeticProduct : Product
    {
        public CosmeticProduct()
        {
            Type = ProductType.Cosmetic;
        }
    }
}
