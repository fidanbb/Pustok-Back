using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Tag
{
    public class TagEditVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
