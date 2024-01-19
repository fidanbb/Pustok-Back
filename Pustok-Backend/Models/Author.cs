namespace Pustok_Backend.Models
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }

        public List<Product> Products { get; set; }
    }
}
