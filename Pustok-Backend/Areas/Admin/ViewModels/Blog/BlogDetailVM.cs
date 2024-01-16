namespace Pustok_Backend.Areas.Admin.ViewModels.Blog
{
    public class BlogDetailVM
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

        public List<Models.Tag> Tags { get; set; }
    }
}
