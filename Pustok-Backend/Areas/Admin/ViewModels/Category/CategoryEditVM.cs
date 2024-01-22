using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Category
{
    public class CategoryEditVM
    {
      

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
