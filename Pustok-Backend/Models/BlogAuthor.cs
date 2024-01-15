namespace Pustok_Backend.Models
{
    public class BlogAuthor:BaseEntity
    {
        public string FullName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
