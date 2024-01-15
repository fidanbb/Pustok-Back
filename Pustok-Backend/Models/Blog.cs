namespace Pustok_Backend.Models
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int BlogAuthorId { get; set; }
        public BlogAuthor BlogAuthor { get; set; }

        public List<BlogImage> Images { get; set; }
        public ICollection<BlogTag> BlogTags { get; set; } = new HashSet<BlogTag>();
        public ICollection<BlogComment> BlogComments { get; set; }
    }
}
