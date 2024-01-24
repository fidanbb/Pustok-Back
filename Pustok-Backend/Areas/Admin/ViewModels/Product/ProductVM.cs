using Pustok_Backend.Models;

namespace Pustok_Backend.Areas.Admin.ViewModels.Product
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string AuthorName { get; set; }
        public List<ProductImage> Images { get; set; }

        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }
        public int Discount { get; set; }
    }
}
