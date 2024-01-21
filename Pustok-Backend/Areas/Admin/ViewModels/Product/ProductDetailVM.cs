using Pustok_Backend.Models;

namespace Pustok_Backend.Areas.Admin.ViewModels.Product
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public string Sku { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public List<ProductImage> Images { get; set; }
        public List<Models.ProductComment> ProductComments { get; set; }
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<Models.Tag> Tags { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
