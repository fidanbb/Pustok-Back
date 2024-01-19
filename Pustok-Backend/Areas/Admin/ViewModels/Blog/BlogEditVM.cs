using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok_Backend.Models;
using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Blog
{
    public class BlogEditVM
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }

        public int BlogAuthorId { get; set; }
        public List<BlogImage> Images { get; set; }
        public List<IFormFile> Photos { get; set; }
        public IList<SelectListItem> Tags { get; set; }
    }
}
