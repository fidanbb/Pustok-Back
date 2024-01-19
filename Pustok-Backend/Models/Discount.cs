namespace Pustok_Backend.Models
{
    public class Discount:BaseEntity
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
