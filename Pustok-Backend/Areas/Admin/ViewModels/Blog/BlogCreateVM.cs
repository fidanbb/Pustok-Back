﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Blog
{
    public class BlogCreateVM
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }

        public int AuthorId { get; set; }
        public IList<SelectListItem> Tags { get; set; }
    }
}
