namespace Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor
{
    public class BlogAuthorVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<string> BlogTitles { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
