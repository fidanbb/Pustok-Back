using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.ProductComment
{
    public class ProductCommentCreateVM
    {
        public int ProductId { get; set; }

        [Required]
        public string Message { get; set; }

        public int Rate { get; set; }
        public string AppUserId { get; set; }
    }
}
