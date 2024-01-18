using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor
{
    public class BlogAuthorEditVM
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}
