namespace Pustok_Backend.Areas.Admin.ViewModels.BlogComment
{
    public class BlogCommentVM
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Message { get; set; }
        public string AppUserId { get; set; }
    }
}
