namespace Pustok_Backend.Areas.Admin.ViewModels.Author
{
    public class AuthorVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<string> ProductTitles { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
