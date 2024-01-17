using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.BlogComment
{
    public class BlogCommentCreateVM
    {
        public int BlogId { get; set; }

        [Required]
        public string Message { get; set; }
        public string AppUserId { get; set; }
    }
}
