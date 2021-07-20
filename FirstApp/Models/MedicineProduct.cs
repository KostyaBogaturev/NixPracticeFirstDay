using FirstApp.Abstractions;

namespace FirstApp.Models
{
    public class MedicineProduct : Product
    {
        public MedicineProduct()
        {
            Type = ProductType.Medicine;
        }
    }
}
