using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor
{
    public class BlogAuthorCreateVM
    {
        [Required]
        public string FullName { get; set; }
    }
}
