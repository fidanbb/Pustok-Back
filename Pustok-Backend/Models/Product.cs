namespace Pustok_Backend.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Rate { get; set; } = 5;
        public int SaleCount { get; set; }
        public int StockCount { get; set; }
        public string Sku { get; set; }
        public List<ProductImage> Images { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
