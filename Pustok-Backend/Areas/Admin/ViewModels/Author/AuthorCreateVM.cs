using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Author
{
    public class AuthorCreateVM
    {
        [Required]
        public string FullName { get; set; }
    }
}
