namespace Pustok_Backend.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<BlogTag> BlogTags { get; set; }
        public List<ProductTag> ProductTags { get; set; }

    }
}
