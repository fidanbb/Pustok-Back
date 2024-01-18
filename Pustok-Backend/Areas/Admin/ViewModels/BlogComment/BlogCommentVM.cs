namespace Pustok_Backend.Areas.Admin.ViewModels.BlogComment
{
    public class BlogCommentVM
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
