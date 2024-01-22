using Pustok_Backend.Models;

namespace Pustok_Backend.ViewModels
{
    public class ProductModalVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int Discount { get; set; }
        public string Sku { get; set; }
        public List<string> Images { get; set; }
        public List<string> Tags { get; set; }
    }
}
